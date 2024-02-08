using Entities;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class UsersManager : IndividualsManager
    {
        // METHODS

        public List<User> list()
        {
            List<User> list = new List<User>();

            try
            {
                _database.setQuery("SELECT UserId, UserName, UserPassword, RoleId, RoleName FROM employees E, users U, roles R WHERE U.UserName = concat(E.LastName, E.EmployeeId) AND U.RoleId = R.Id");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    User user = new User();

                    user.UserId = (int)_database.Reader["UserId"];
                    user.UserName = (string)_database.Reader["UserName"];
                    user.UserPassword = (string)_database.Reader["UserPassword"];
                    user.Role.RoleId = (int)_database.Reader["RoleId"];
                    user.Role.Name = (string)_database.Reader["RoleName"];

                    list.Add(user);
                }

                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }
        }

        public void add(User reg)
        {
            try
            {
                _database.setQuery("INSERT INTO users (UserName, UserPassword, RoleId) VALUES (@UserName, @UserPassword, @RoleId)");
                _database.setParameter("@UserName", reg.UserName);
                _database.setParameter("@UserPassword", reg.UserPassword);
                _database.setParameter("@RoleId", reg.Role.RoleId);
                _database.executeAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }
        }

        public void edit(User reg)
        {
            try
            {
                _database.setQuery("UPDATE users SET UserName = @UserName, UserPassword = @UserPassword, RoleId = @RoleId WHERE UserId = @UserId");
                _database.setParameter("@UserId", reg.UserId);
                _database.setParameter("@UserName", reg.UserName);
                _database.setParameter("@UserPassword", reg.UserPassword);
                _database.setParameter("@RoleId", reg.Role.RoleId);
                _database.executeAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }
        }

        public void delete(int userId)
        {
            try
            {
                _database.setQuery("DELETE FROM users WHERE UserId = @UserId");
                _database.setParameter("@UserId", userId);
                _database.executeAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }
        }

        public User loadUser(Employee employee)
        {
            try
            {
                foreach (User existingUser in list())
                {
                    if (existingUser.UserName == employee.LastName + employee.EmployeeId)
                    {
                        assign(existingUser, employee);
                        return existingUser;
                    }    
                }

                User newUser = new User();
                assign(newUser, employee);
                return newUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void assign(User user, Employee employee)
        {
            user.ActiveStatus = employee.ActiveStatus;
            user.IsPerson = employee.IsPerson;
            user.FirstName = employee.FirstName;
            user.LastName = employee.LastName;
            user.BusinessName = employee.BusinessName;
            user.BusinessDescription = employee.BusinessDescription;
            user.ImageUrl = employee.ImageUrl;
            user.Email = employee.Email;
            user.Phone.Number = employee.Phone.Number;
            user.Phone.Country.PhoneAreaCode = employee.Phone.Country.PhoneAreaCode;
            user.Phone.Province.PhoneAreaCode = employee.Phone.Province.PhoneAreaCode;
            user.Adress.Country = employee.Adress.Country;
            user.Adress.Province = employee.Adress.Province;
            user.Adress.City = employee.Adress.City;
            user.Adress.ZipCode = employee.Adress.ZipCode;
            user.Adress.StreetName = employee.Adress.StreetName;
            user.Adress.StreetNumber = employee.Adress.StreetNumber;
            user.Adress.Flat = employee.Adress.Flat;
            user.TaxCode.Prefix = employee.TaxCode.Prefix;
            user.TaxCode.Number = employee.TaxCode.Number;
            user.TaxCode.Suffix = employee.TaxCode.Suffix;
            user.EmployeeId = employee.EmployeeId;
            user.Admission = employee.Admission;
            user.Position.Title = employee.Position.Title;
            user.Position.Seniority.Name = employee.Position.Seniority.Name;
            user.Position.Department.Name = employee.Position.Department.Name;
        }
    }
}

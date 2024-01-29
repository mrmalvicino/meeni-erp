using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class UsersManager : IndividualsManager
    {
        // METHODS

        public List<User> list()
        {
            List<User> list = new List<User>();

            try
            {
                _database.setQuery("SELECT Id, ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, ImageUrl, Email, PhoneCountry, PhoneArea, PhoneNumber, AdressCountry, AdressProvince, AdressCity, AdressZipCode, AdressStreet, AdressStreetNumber, AdressFlat, LegalIdXX, LegalIdDNI, LegalIdY, CategoryId, Area, Title, Seniority, RoleId, RoleName, PermissionLevel FROM employees E, users U WHERE U.UserName = concat(E.LastName, E.EmployeeId)");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    User user = new User();

                    readIndividual(user);
                    // readEmployee(user); // crear en EmployeesManager

                    user.Role.Id = (int)_database.Reader["RoleId"];
                    user.Role.RoleName = (string)_database.Reader["RoleName"];
                    user.Role.PermissionLevel = (int)_database.Reader["PermissionLevel"];

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

        public void add(Individual reg)
        {
            try
            {
                _database.setQuery("INSERT INTO users (ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, ImageUrl, Email, PhoneCountry, PhoneArea, PhoneNumber, AdressCountry, AdressProvince, AdressCity, AdressZipCode, AdressStreet, AdressStreetNumber, AdressFlat, LegalIdXX, LegalIdDNI, LegalIdY) VALUES (@ActiveStatus, @IsPerson, @FirstName, @LastName, @BusinessName, @BusinessDescription, @ImageUrl, @Email, @PhoneCountry, @PhoneArea, @PhoneNumber, @AdressCountry, @AdressProvince, @AdressCity, @AdressZipCode, @AdressStreet, @AdressStreetNumber, @AdressFlat, @LegalIdXX, @LegalIdDNI, @LegalIdY)");
                setupIndividualParameters(reg);
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
                _database.setQuery("UPDATE users SET ActiveStatus = @ActiveStatus, IsPerson = @IsPerson, FirstName = @FirstName, LastName = @LastName, BusinessName = @BusinessName, BusinessDescription = @BusinessDescription, ImageUrl = @ImageUrl, Email = @Email, PhoneCountry = @PhoneCountry, PhoneArea = @PhoneArea, PhoneNumber = @PhoneNumber, AdressCountry = @AdressCountry, AdressProvince = @AdressProvince, AdressCity = @AdressCity, AdressZipCode = @AdressZipCode, AdressStreet = @AdressStreet, AdressStreetNumber = @AdressStreetNumber, AdressFlat = @AdressFlat, LegalIdXX = @LegalIdXX, LegalIdDNI = @LegalIdDNI, LegalIdY = @LegalIdY WHERE UserId = @UserId");
                _database.setParameter("@UserId", reg.UserId);
                setupIndividualParameters(reg);
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
    }
}

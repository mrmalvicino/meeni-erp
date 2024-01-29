using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                _database.setQuery("SELECT ActiveStatus, EmployeeId, UserId, UserName, UserPassword, RoleId, RoleName, PermissionLevel FROM employees E, users U, categories C, roles R WHERE U.UserName = concat(E.LastName, E.EmployeeId) AND E.CategoryId = C.Id AND U.RoleId = R.Id");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    User user = new User();

                    user.ActiveStatus = (bool)_database.Reader["ActiveStatus"];
                    user.EmployeeId = (int)_database.Reader["EmployeeId"];
                    user.UserId = (int)_database.Reader["UserId"];
                    user.UserName = (string)_database.Reader["UserName"];
                    user.UserPassword = (string)_database.Reader["UserPassword"];
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

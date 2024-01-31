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
                _database.setQuery("SELECT ActiveStatus, EmployeeId, UserId, UserName, UserPassword, RoleId, RoleName FROM employees E, users U, categories C, roles R WHERE U.UserName = concat(E.LastName, E.EmployeeId) AND E.CategoryId = C.Id AND U.RoleId = R.Id");
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
                _database.setParameter("@RoleId", reg.Role.Id);
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
                _database.setParameter("@RoleId", reg.Role.Id);
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

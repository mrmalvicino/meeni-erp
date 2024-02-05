using DAL;
using Entities;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class RolesManager
    {
        // ATTRIBUTES

        private Database _database = new Database();

        // METHODS

        public List<Role> list()
        {
            List<Role> list = new List<Role>();

            try
            {
                _database.setQuery("SELECT Id, RoleName FROM roles");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Role role = new Role();

                    role.Id = (int)_database.Reader["Id"];
                    role.Name = (string)_database.Reader["RoleName"];

                    list.Add(role);
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
        /*
        public void add(Role reg)
        {
            try
            {
                _database.setQuery("INSERT INTO roles (RoleName) VALUES (@RoleName)");
                _database.setParameter("@RoleName", reg.Name);
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

        public void edit(Role reg)
        {
            try
            {
                _database.setQuery("UPDATE roles SET RoleName = @RoleName WHERE Id = @Id");
                _database.setParameter("@Id", reg.Id);
                _database.setParameter("@RoleName", reg.Name);
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

        public void delete(int id)
        {
            try
            {
                _database.setQuery("DELETE FROM roles WHERE Id = @Id");
                _database.setParameter("@Id", id);
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
        }*/
    }
}

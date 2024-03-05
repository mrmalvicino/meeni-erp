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
                _database.setQuery("select RoleId, RoleName from Roles");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Role role = new Role();

                    role.RoleId = (int)_database.Reader["RoleId"];
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
    }
}

using DomainModel;
using Exceptions;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class RolesDAL
    {
        private Database _db;

        public RolesDAL(Database db)
        {
            _db = db;
        }

        public List<Role> List(User user = null)
        {
            List<Role> roles = new List<Role>();

            try
            {
                if (user == null)
                {
                    _db.SetQuery("select * from roles");
                }
                else
                {
                    _db.SetProcedure("sp_list_user_roles");
                    _db.SetParameter("@user_id", user.Id);
                }

                _db.ExecuteRead();

                while (_db.Reader.Read())
                {
                    Role role = new Role();
                    ReadRow(role);
                    roles.Add(role);
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return roles;
        }

        public void CreateUserRole(int userId, int roleId)
        {
            try
            {
                _db.SetProcedure("sp_create_user_role");
                _db.SetParameter("@user_id", userId);
                _db.SetParameter("@role_id", roleId);
                _db.ExecuteAction();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }
        }

        private void ReadRow(Role role)
        {
            role.Id = Convert.ToInt32(_db.Reader["role_id"]);
            role.Name = _db.Reader["role_name"].ToString();
        }
    }
}

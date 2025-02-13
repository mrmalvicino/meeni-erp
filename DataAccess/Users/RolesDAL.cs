using DomainModel.Users;
using Exceptions;
using System;
using System.Collections.Generic;
using Utilities;

namespace DataAccess.Users
{
    public class RolesDAL
    {
        private Database _db;

        public RolesDAL(Database db)
        {
            _db = db;
        }

        public Role Read(int roleId)
        {
            try
            {
                _db.SetQuery("select * from roles where role_id = @role_id");
                _db.SetParameter("@role_id", roleId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    Role role = new Role();
                    ReadRow(role);
                    return role;
                }

                return null;
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

        public List<Role> List(User user = null)
        {
            List<Role> roles = new List<Role>();

            try
            {
                _db.SetProcedure("sp_list_roles");
                _db.SetParameter("@user_id", Helper.GetId(user));
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
            role.Name = _db.Reader["name"].ToString();
        }
    }
}

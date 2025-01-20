using DataAccess;
using DomainModel;
using Exceptions;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class RolesManager
    {
        public enum Ids
        {
            AdminId = 1
        }

        private Role _role;
        private RolesDAL _rolesDAL;

        public RolesManager(Database db)
        {
            _rolesDAL = new RolesDAL(db);
        }

        public Role Read(int roleId)
        {
            if (roleId == 0)
            {
                return null;
            }

            try
            {
                _role = _rolesDAL.Read(roleId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }

            return _role;
        }

        public List<Role> List(User user = null)
        {
            try
            {
                return _rolesDAL.List(user);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public void CreateUserRole(User user, Role role)
        {
            try
            {
                _rolesDAL.CreateUserRole(user.Id, role.Id);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }
    }
}

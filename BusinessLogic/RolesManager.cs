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
            AdminRoleId = 1
        }

        private RolesDAL _rolesDAL;

        public RolesManager(Database db)
        {
            _rolesDAL = new RolesDAL(db);
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

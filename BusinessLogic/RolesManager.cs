using DataAccess;
using DomainModel;
using Exceptions;
using System;

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

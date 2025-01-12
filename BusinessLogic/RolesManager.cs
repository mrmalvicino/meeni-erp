using DataAccess;
using DomainModel;
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

        public RolesManager()
        {
            _rolesDAL = new RolesDAL();
        }

        public void CreateUserRole(User user, Role role)
        {
            try
            {
                _rolesDAL.CreateUserRole(user.Id, role.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

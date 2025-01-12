using DataAccess;
using DomainModel;
using System;

namespace BusinessLogic
{
    public class UsersManager
    {
        private UsersDAL _usersDAL;
        private RolesManager _rolesManager;

        public UsersManager()
        {
            _usersDAL = new UsersDAL();
            _rolesManager = new RolesManager();
        }

        public int Create(User user, Organization organization)
        {
            try
            {
                user.Id = _usersDAL.Create(user, organization);

                foreach (Role role in user.Roles)
                {
                    _rolesManager.CreateUserRole(user, role);
                }

                return user.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

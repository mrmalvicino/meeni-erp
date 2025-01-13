using DataAccess;
using DomainModel;
using Exceptions;
using System;
using System.Transactions;

namespace BusinessLogic
{
    public class UsersManager
    {
        private User _user;
        private UsersDAL _usersDAL;
        private RolesManager _rolesManager;

        public UsersManager(Database db)
        {
            _usersDAL = new UsersDAL(db);
            _rolesManager = new RolesManager(db);
        }

        public int Create(User user, Organization organization)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    user.Id = _usersDAL.Create(user, organization);

                    foreach (Role role in user.Roles)
                    {
                        _rolesManager.CreateUserRole(user, role);
                    }

                    scope.Complete();

                    return user.Id;
                }
            }
            catch (Exception ex)
            {
                throw new TransactionScopeException(ex);
            }
        }

        public User Read(int userId)
        {
            if (userId == 0)
            {
                return null;
            }

            try
            {
                _user = _usersDAL.Read(userId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }

            _user.Roles = _rolesManager.List(_user);

            return _user;
        }

        public int FindId(User user)
        {
            try
            {
                return _usersDAL.FindId(user);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public int FindOrganizationId(User user)
        {
            try
            {
                return _usersDAL.FindOrganizationId(user);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }
    }
}

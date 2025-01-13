using DataAccess;
using DomainModel;
using Exceptions;
using System;
using System.Transactions;

namespace BusinessLogic
{
    public class UsersManager
    {
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

                    foreach (Role role in user.Roles) // va en DAL? En tal caso cambiar TransactionScopeException
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
            try
            {
                return _usersDAL.Read(userId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
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

using DataAccess;
using DomainModel;
using Exceptions;
using System;
using System.Transactions;
using Utilities;

namespace BusinessLogic
{
    public class UsersManager
    {
        private User _user;
        private UsersDAL _usersDAL;
        private Employee _employee;
        private EmployeesManager _employeesManager;
        private RolesManager _rolesManager;

        public UsersManager(Database db)
        {
            _usersDAL = new UsersDAL(db);
            _employeesManager = new EmployeesManager(db);
            _rolesManager = new RolesManager(db);
        }

        public int Create(User user, int internalOrganizationId)
        {
            user.Id = _employeesManager.Create(user, internalOrganizationId);

            try
            {
                using (var scope = new TransactionScope())
                {
                    user.Id = _usersDAL.Create(user);

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

            _employee = _employeesManager.Read(_user.Id);
            Helper.AssignPerson(_user, _employee);

            return _user;
        }

        public void Update(User user, int internalOrganizationId)
        {
            _employeesManager.Update(user, internalOrganizationId);

            try
            {
                _usersDAL.Update(user);
                // Falta editar roles de usuario
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
    }
}

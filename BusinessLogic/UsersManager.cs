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
            try
            {
                using (var transaction = new TransactionScope())
                {
                    user.Id = _employeesManager.Create(user, internalOrganizationId);
                    Validate(user);
                    user.Id = _usersDAL.Create(user);

                    foreach (Role role in user.Roles)
                    {
                        _rolesManager.CreateUserRole(user, role);
                    }

                    transaction.Complete();

                    return user.Id;
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
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
            try
            {
                using (var transaction = new TransactionScope())
                {
                    _employeesManager.Update(user);
                    Validate(user);
                    _usersDAL.Update(user);
                    // Falta editar roles de usuario
                    transaction.Complete();
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new TransactionScopeException(ex);
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

        public int FindId(string username, string password)
        {
            try
            {
                return _usersDAL.FindId(username, password);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        private void Validate(User user)
        {
            Validator.ValidateUsername(user.Username);
            Validator.ValidatePassword(user.Password);
        }
    }
}

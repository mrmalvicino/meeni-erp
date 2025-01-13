using DataAccess;
using DomainModel;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Transactions;

namespace BusinessLogic
{
    public class ApplicationManager
    {
        private Database _db;
        private ImagesManager _imagesManager;
        private OrganizationsManager _organizationsManager;
        private PricingPlansManager _pricingPlansManager;
        private RolesManager _rolesManager;
        private UsersManager _usersManager;

        public ImagesManager Images => _imagesManager;
        public OrganizationsManager Organizations => _organizationsManager;
        public PricingPlansManager PricingPlans => _pricingPlansManager;
        public RolesManager Roles => _rolesManager;
        public UsersManager Users => _usersManager;

        public ApplicationManager()
        {
            _db = new Database();
            _imagesManager = new ImagesManager(_db);
            _organizationsManager = new OrganizationsManager(_db);
            _pricingPlansManager = new PricingPlansManager(_db);
            _rolesManager = new RolesManager(_db);
            _usersManager = new UsersManager(_db);
        }

        public void SignUp(User user, Organization organization)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    organization.Id = _organizationsManager.Create(organization);
                    _usersManager.Create(user, organization);
                    transaction.Complete();
                }
                catch (Exception ex)
                {
                    throw new TransactionScopeException(ex);
                }
            }
        }

        public bool Login(User user, Organization organization)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    user.Id = _usersManager.FindId(user);

                    if (0 < user.Id)
                    {
                        user = _usersManager.Read(user.Id);
                        organization.Id = _usersManager.FindOrganizationId(user);
                        organization = _organizationsManager.Read(organization.Id);
                        transaction.Complete();
                        return true;
                    }

                    return false;
                }
                catch (Exception ex)
                {
                    throw new TransactionScopeException(ex);
                }
            }
        }
    }
}

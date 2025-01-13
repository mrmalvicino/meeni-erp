using DataAccess;
using DomainModel;
using System;
using System.Collections.Generic;
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

        public ApplicationManager()
        {
            _db = new Database();
            _imagesManager = new ImagesManager(_db);
            _organizationsManager = new OrganizationsManager(_db);
            _pricingPlansManager = new PricingPlansManager(_db);
            _rolesManager = new RolesManager(_db);
            _usersManager = new UsersManager(_db);
        }

        public List<PricingPlan> GetPricingPlans()
        {
            return _pricingPlansManager.List();
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
                    Console.WriteLine($"Error: {ex.Message}");
                    throw;
                }
            }
        }
    }
}

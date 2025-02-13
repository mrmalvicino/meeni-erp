using DataAccess;
using DataAccess.Organizations;
using DomainModel.Organizations;
using DomainModel.Base;
using BusinessLogic.Base;
using Exceptions;
using Utilities;
using System;
using System.Transactions;

namespace BusinessLogic.Organizations
{
    public class OrganizationsManager
    {
        private Organization _organization;
        private OrganizationsDAL _organizationsDAL;
        private Entity _entity;
        private EntitiesManager _entitiesManager;
        private PricingPlansManager _pricingPlansManager;

        public OrganizationsManager(Database db)
        {
            _organizationsDAL = new OrganizationsDAL(db);
            _entitiesManager = new EntitiesManager(db);
            _pricingPlansManager = new PricingPlansManager(db);
        }

        public int Create(Organization organization)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    organization.Id = _entitiesManager.Create(organization);
                    organization.PricingPlan.Id = _pricingPlansManager.FindId(organization.PricingPlan);
                    organization.Id = _organizationsDAL.Create(organization);
                    transaction.Complete();
                    return organization.Id;
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new TransactionScopeException(ex);
            }
        }

        public Organization Read(int organizationId)
        {
            if (organizationId == 0)
            {
                return null;
            }

            try
            {
                _organization = _organizationsDAL.Read(organizationId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }

            _organization.PricingPlan = _pricingPlansManager.Read(Helper.GetId(_organization.PricingPlan));

            _entity = _entitiesManager.Read(_organization.Id);
            Helper.AssignEntity(_organization, _entity);

            return _organization;
        }

        public void Update(Organization organization)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    _entitiesManager.Update(organization);
                    organization.PricingPlan.Id = _pricingPlansManager.FindId(organization.PricingPlan);
                    _organizationsDAL.Update(organization);
                    transaction.Complete();
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new TransactionScopeException(ex);
            }
        }

        public void Toggle(int organizationId)
        {
            try
            {
                _organizationsDAL.Toggle(organizationId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }
    }
}

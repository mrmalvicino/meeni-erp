using DataAccess;
using DomainModel;
using Exceptions;
using Utilities;
using System;
using System.Transactions;

namespace BusinessLogic
{
    public class InternalOrganizationsManager
    {
        private InternalOrganization _internalOrganization;
        private InternalOrganizationsDAL _internalOrganizationsDAL;
        private LegalEntity _legalEntity;
        private LegalEntitiesManager _legalEntitiesManager;
        private PricingPlansManager _pricingPlansManager;

        public InternalOrganizationsManager(Database db)
        {
            _internalOrganizationsDAL = new InternalOrganizationsDAL(db);
            _legalEntitiesManager = new LegalEntitiesManager(db);
            _pricingPlansManager = new PricingPlansManager(db);
        }

        public int Create(InternalOrganization internalOrganization)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    internalOrganization.Id = _legalEntitiesManager.Create(internalOrganization);
                    internalOrganization.PricingPlan.Id = _pricingPlansManager.FindId(internalOrganization.PricingPlan);
                    internalOrganization.Id = _internalOrganizationsDAL.Create(internalOrganization);
                    transaction.Complete();
                    return internalOrganization.Id;
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new TransactionScopeException(ex);
            }
        }

        public InternalOrganization Read(int internalOrganizationId)
        {
            if (internalOrganizationId == 0)
            {
                return null;
            }

            try
            {
                _internalOrganization = _internalOrganizationsDAL.Read(internalOrganizationId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }

            _internalOrganization.PricingPlan = _pricingPlansManager.Read(Helper.GetId(_internalOrganization.PricingPlan));

            _legalEntity = _legalEntitiesManager.Read(_internalOrganization.Id);
            Helper.AssignLegalEntity(_internalOrganization, _legalEntity);

            return _internalOrganization;
        }

        public void Update(InternalOrganization internalOrganization)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    _legalEntitiesManager.Update(internalOrganization);
                    internalOrganization.PricingPlan.Id = _pricingPlansManager.FindId(internalOrganization.PricingPlan);
                    _internalOrganizationsDAL.Update(internalOrganization);
                    transaction.Complete();
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new TransactionScopeException(ex);
            }
        }
    }
}

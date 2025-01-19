using DataAccess;
using DomainModel;
using Exceptions;
using Utilities;
using System;

namespace BusinessLogic
{
    public class InternalOrganizationsManager
    {
        private InternalOrganization _internalOrganization;
        private InternalOrganizationsDAL _internalOrganizationsDAL;
        private PricingPlansManager _pricingPlansManager;

        public InternalOrganizationsManager(Database db)
        {
            _internalOrganizationsDAL = new InternalOrganizationsDAL(db);
            _pricingPlansManager = new PricingPlansManager(db);
        }

        public int Create(InternalOrganization internalOrganization)
        {
            try
            {
                return _internalOrganizationsDAL.Create(internalOrganization);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
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

            return _internalOrganization;
        }
    }
}

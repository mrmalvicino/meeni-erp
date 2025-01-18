using DataAccess;
using DomainModel;
using Exceptions;
using Utilities;
using System;

namespace BusinessLogic
{
    public class OrganizationsManager
    {
        private InternalOrganization _organization;
        private OrganizationsDAL _organizationsDAL;
        private ImagesManager _imagesManager;
        private PricingPlansManager _pricingPlansManager;

        public OrganizationsManager(Database db)
        {
            _organizationsDAL = new OrganizationsDAL(db);
            _imagesManager = new ImagesManager(db);
            _pricingPlansManager = new PricingPlansManager(db);
        }

        public int Create(InternalOrganization organization)
        {
            try
            {
                return _organizationsDAL.Create(organization);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public InternalOrganization Read(int organizationId)
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

            _organization.LogoImage = _imagesManager.Read(Helper.GetId(_organization.LogoImage));
            _organization.PricingPlan = _pricingPlansManager.Read(Helper.GetId(_organization.PricingPlan));

            return _organization;
        }
    }
}

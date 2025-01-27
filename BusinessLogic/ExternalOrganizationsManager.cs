using DataAccess;
using DomainModel;
using Exceptions;
using System;
using Utilities;

namespace BusinessLogic
{
    public class ExternalOrganizationsManager
    {
        private ExternalOrganization _externalOrganization;
        private ExternalOrganizationsDAL _externalOrganizationsDAL;
        private LegalEntity _legalEntity;
        private LegalEntitiesManager _legalEntitiesManager;

        public ExternalOrganizationsManager(Database db)
        {
            _externalOrganizationsDAL = new ExternalOrganizationsDAL(db);
            _legalEntitiesManager = new LegalEntitiesManager(db);
        }

        public ExternalOrganization Read(int externalOrganizationId)
        {
            if (externalOrganizationId == 0)
            {
                return null;
            }

            try
            {
                _externalOrganization = _externalOrganizationsDAL.Read(externalOrganizationId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }

            _legalEntity = _legalEntitiesManager.Read(_externalOrganization.Id);
            Helper.AssignLegalEntity(_externalOrganization, _legalEntity);

            return _externalOrganization;
        }

        public int FindInternalId(int externalOrganizationId)
        {
            try
            {
                return _externalOrganizationsDAL.FindInternalId(externalOrganizationId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }
    }
}

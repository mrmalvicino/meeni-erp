using DataAccess;
using DomainModel;
using Exceptions;
using System;
using Utilities;

namespace BusinessLogic
{
    public class StakeholdersManager
    {
        private Stakeholder _externalOrganization;
        private StakeholdersDAL _externalOrganizationsDAL;
        private Entity _legalEntity;
        private EntitiesManager _legalEntitiesManager;

        public StakeholdersManager(Database db)
        {
            _externalOrganizationsDAL = new StakeholdersDAL(db);
            _legalEntitiesManager = new EntitiesManager(db);
        }

        public Stakeholder Read(int externalOrganizationId)
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

using DataAccess;
using DomainModel;
using Exceptions;
using System;
using Utilities;

namespace BusinessLogic
{
    public class StakeholdersManager
    {
        private Stakeholder _stakeholder;
        private StakeholdersDAL _stakeholdersDAL;
        private Entity _entity;
        private EntitiesManager _entitiesManager;

        public StakeholdersManager(Database db)
        {
            _stakeholdersDAL = new StakeholdersDAL(db);
            _entitiesManager = new EntitiesManager(db);
        }

        public Stakeholder Read(int stakeholderId)
        {
            if (stakeholderId == 0)
            {
                return null;
            }

            try
            {
                _stakeholder = _stakeholdersDAL.Read(stakeholderId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }

            _entity = _entitiesManager.Read(_stakeholder.Id);
            Helper.AssignEntity(_stakeholder, _entity);

            return _stakeholder;
        }

        public int FindOrganizationId(int stakeholderId)
        {
            try
            {
                return _stakeholdersDAL.FindOrganizationId(stakeholderId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }
    }
}

using DataAccess;
using DomainModel;
using Exceptions;
using System;
using System.Transactions;
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

        public int Create(Stakeholder stakeholder, int organizationId)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    stakeholder.Id = _entitiesManager.Create(stakeholder);
                    stakeholder.Id = _stakeholdersDAL.Create(stakeholder, organizationId);
                    transaction.Complete();
                    return stakeholder.Id;
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new TransactionScopeException(ex);
            }
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

        public void Update(Stakeholder stakeholder)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    _entitiesManager.Update(stakeholder);
                    _stakeholdersDAL.Update(stakeholder);
                    transaction.Complete();
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new TransactionScopeException(ex);
            }
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

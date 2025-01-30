using DataAccess;
using DomainModel;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Transactions;
using Utilities;

namespace BusinessLogic
{
    public class PartnersManager
    {
        private Partner _partner;
        private PartnersDAL _partnersDAL;
        private Stakeholder _stakeholder;
        private StakeholdersManager _stakeholdersManager;

        public PartnersManager(Database db)
        {
            _partnersDAL = new PartnersDAL(db);
            _stakeholdersManager = new StakeholdersManager(db);
        }

        public int Create(Partner partner, int organizationId)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    partner.Id = _stakeholdersManager.Create(partner, organizationId);
                    _partnersDAL.Create(partner);
                    transaction.Complete();
                    return partner.Id;
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new TransactionScopeException(ex);
            }
        }

        public Partner Read(int partnerId)
        {
            if (partnerId == 0)
            {
                return null;
            }

            try
            {
                _partner = _partnersDAL.Read(partnerId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }

            _stakeholder = _stakeholdersManager.Read(_partner.Id);
            Helper.AssignEntity(_partner, _stakeholder);

            return _partner;
        }

        public void Update(Partner partner)
        {
            try
            {
                using (var transaction = new TransactionScope())
                {
                    _stakeholdersManager.Update(partner);
                    _partnersDAL.Update(partner);
                    transaction.Complete();
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new TransactionScopeException(ex);
            }
        }

        public void Toggle(int partnerId)
        {
            try
            {
                _partnersDAL.Toggle(partnerId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public List<Partner> List(int organizationId, bool active, bool inactive)
        {
            try
            {
                List<Partner> partners;
                partners = _partnersDAL.List(organizationId, active, inactive);

                foreach (var partner in partners)
                {
                    _stakeholder = _stakeholdersManager.Read(partner.Id);
                    Helper.AssignEntity(partner, _stakeholder);
                }

                return partners;
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }
    }
}

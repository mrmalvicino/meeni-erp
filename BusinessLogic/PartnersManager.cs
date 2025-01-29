using DataAccess;
using DomainModel;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Transactions;

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

        public int Create(Partner partner)
        {
            try
            {
                //Validate(partner);
                return _partnersDAL.Create(partner);
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new BusinessLogicException(ex);
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

        public void Toggle(Partner partner)
        {
            try
            {
                _partnersDAL.Toggle(partner);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public List<Partner> List(
            bool listClients,
            bool listSuppliers,
            int organizationId,
            bool listActive = true,
            bool listInactive = true)
        {
            try
            {
                List<Partner> partners;
                partners = _partnersDAL.List(
                    listClients,
                    listSuppliers,
                    organizationId,
                    listActive,
                    listInactive);

                return partners;
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }
    }
}

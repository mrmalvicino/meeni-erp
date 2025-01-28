using DataAccess;
using DomainModel;
using Exceptions;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class PartnersManager
    {
        private Partner _partner;
        private PartnersDAL _businesPartnersDAL;
        private StakeholdersManager _stakeholdersManager;

        public PartnersManager(Database db)
        {
            _businesPartnersDAL = new PartnersDAL(db);
            _stakeholdersManager = new StakeholdersManager(db);
        }

        public int Create(Partner partner)
        {
            try
            {
                //Validate(partner);
                return _businesPartnersDAL.Create(partner);
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
                _partner = _businesPartnersDAL.Read(partnerId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }

            return _partner;
        }

        public void Toggle(Partner partner)
        {
            try
            {
                _businesPartnersDAL.Toggle(partner);
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
                partners = _businesPartnersDAL.List(
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

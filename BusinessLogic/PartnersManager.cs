using DataAccess;
using DomainModel;
using Exceptions;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class PartnersManager
    {
        private Partner _businessPartner;
        private PartnersDAL _businesPartnersDAL;
        private StakeholdersManager _externalOrganizationsManager;
        private PeopleManager _peopleManager;

        public PartnersManager(Database db)
        {
            _businesPartnersDAL = new PartnersDAL(db);
            _externalOrganizationsManager = new StakeholdersManager(db);
            _peopleManager = new PeopleManager(db);
        }

        public int Create(Partner businessPartner)
        {
            // handle person
            // handle organization

            try
            {
                //Validate(businessPartner);
                return _businesPartnersDAL.Create(businessPartner);
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new BusinessLogicException(ex);
            }
        }

        public Partner Read(int businessPartnerId)
        {
            if (businessPartnerId == 0)
            {
                return null;
            }

            try
            {
                _businessPartner = _businesPartnersDAL.Read(businessPartnerId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }

            if (_businessPartner.Organization != null)
            {
                _businessPartner.Organization = _externalOrganizationsManager.Read(_businessPartner.Organization.Id);
            }
            else if (_businessPartner.Person != null)
            {
                _businessPartner.Person = _peopleManager.Read(_businessPartner.Person.Id);
            }

            return _businessPartner;
        }

        public void Toggle(Partner businessPartner)
        {
            try
            {
                _businesPartnersDAL.Toggle(businessPartner);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public List<Partner> List(
            bool listClients,
            bool listSuppliers,
            bool listPeople,
            int internalOrganizationId,
            bool listActive = true,
            bool listInactive = true)
        {
            try
            {
                List<Partner> partners;
                partners = _businesPartnersDAL.List(
                    listClients,
                    listSuppliers,
                    listPeople,
                    internalOrganizationId,
                    listActive,
                    listInactive);

                foreach (Partner partner in partners)
                {
                    if (partner.Organization != null)
                    {
                        partner.Organization = _externalOrganizationsManager.Read(partner.Organization.Id);
                    }
                    else if (partner.Person != null)
                    {
                        partner.Person = _peopleManager.Read(partner.Person.Id);
                    }
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

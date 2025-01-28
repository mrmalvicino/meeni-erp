using DataAccess;
using DomainModel;
using Exceptions;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class BusinessPartnersManager
    {
        private BusinessPartner _businessPartner;
        private BusinessPartnersDAL _businesPartnersDAL;
        private ExternalOrganizationsManager _externalOrganizationsManager;
        private PeopleManager _peopleManager;

        public BusinessPartnersManager(Database db)
        {
            _businesPartnersDAL = new BusinessPartnersDAL(db);
            _externalOrganizationsManager = new ExternalOrganizationsManager(db);
            _peopleManager = new PeopleManager(db);
        }

        public int Create(BusinessPartner businessPartner)
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

        public BusinessPartner Read(int businessPartnerId)
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

        public void Toggle(BusinessPartner businessPartner)
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

        public List<BusinessPartner> List(
            bool listClients,
            bool listSuppliers,
            bool listPeople,
            int internalOrganizationId,
            bool listActive = true,
            bool listInactive = true)
        {
            try
            {
                List<BusinessPartner> partners;
                partners = _businesPartnersDAL.List(
                    listClients,
                    listSuppliers,
                    listPeople,
                    internalOrganizationId,
                    listActive,
                    listInactive);

                foreach (BusinessPartner partner in partners)
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

using DomainModel;
using Exceptions;
using System;
using System.Collections.Generic;
using Utilities;

namespace DataAccess
{
    public class BusinessPartnersDAL
    {
        private Database _db;

        public BusinessPartnersDAL(Database db)
        {
            _db = db;
        }

        public int Create(BusinessPartner businessPartner)
        {
            try
            {
                _db.SetProcedure("sp_create_business_partner");
                SetParameters(businessPartner);
                businessPartner.Id = _db.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return businessPartner.Id;
        }

        public BusinessPartner Read(int businessPartnerId)
        {
            try
            {
                _db.SetQuery("select * from business_partners where business_partner_id = @business_partner_id");
                _db.SetParameter("@business_partner_id", businessPartnerId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    BusinessPartner businessPartner = new BusinessPartner();
                    ReadRow(businessPartner);
                    return businessPartner;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }
        }

        public List<BusinessPartner> List(bool listClients, bool listSuppliers, bool listPeople, int internalOrganizationId)
        {
            List<BusinessPartner> businessPartners = new List<BusinessPartner>();

            try
            {
                _db.SetProcedure("sp_list_business_partners");
                _db.SetParameter("@list_clients", listClients);
                _db.SetParameter("@list_suppliers", listSuppliers);
                _db.SetParameter("@list_people", listPeople);
                _db.SetParameter("@internal_organization_id", internalOrganizationId);
                _db.ExecuteRead();

                while (_db.Reader.Read())
                {
                    BusinessPartner businessPartner = new BusinessPartner();
                    ReadRow(businessPartner);
                    businessPartners.Add(businessPartner);
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return businessPartners;
        }

        private void SetParameters(BusinessPartner businessPartner, bool isUpdate = false)
        {
            if (isUpdate)
            {
                _db.SetParameter("@business_partner_id", businessPartner.Id);
            }

            // agregar los otros parámetros
        }

        private void ReadRow(BusinessPartner businessPartner)
        {
            businessPartner.Id = Convert.ToInt32(_db.Reader["business_partner_id"]);
            businessPartner.ActivityStatus = (bool)_db.Reader["activity_status"];
            businessPartner.IsClient = (bool)_db.Reader["is_client"];
            businessPartner.IsSupplier = (bool)_db.Reader["is_supplier"];
            businessPartner.Organization = Helper.Instantiate<ExternalOrganization>(_db.Reader["external_organization_id"]);
            businessPartner.Person = Helper.Instantiate<Person>(_db.Reader["person_id"]);
        }
    }
}

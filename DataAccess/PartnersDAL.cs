using DomainModel;
using Exceptions;
using System;
using System.Collections.Generic;
using Utilities;

namespace DataAccess
{
    public class PartnersDAL
    {
        private Database _db;

        public PartnersDAL(Database db)
        {
            _db = db;
        }

        public int Create(Partner partner)
        {
            try
            {
                _db.SetProcedure("sp_create_business_partner");
                SetParameters(partner);
                partner.Id = _db.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return partner.Id;
        }

        public Partner Read(int partnerId)
        {
            try
            {
                _db.SetQuery("select * from business_partners where business_partner_id = @business_partner_id");
                _db.SetParameter("@business_partner_id", partnerId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    Partner partner = new Partner();
                    ReadRow(partner);
                    return partner;
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

        public void Toggle(Partner partner)
        {
            try
            {
                _db.SetProcedure("sp_toggle_business_partner");
                _db.SetParameter("@business_partner_id", partner.Id);
                _db.ExecuteAction();
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

        public List<Partner> List(
            bool listClients,
            bool listSuppliers,
            int organizationId,
            bool listActive = true,
            bool listInactive = true)
        {
            List<Partner> partners = new List<Partner>();

            try
            {
                _db.SetProcedure("sp_list_partners");
                _db.SetParameter("@list_clients", listClients);
                _db.SetParameter("@list_suppliers", listSuppliers);
                _db.SetParameter("@organization_id", organizationId);
                _db.SetParameter("@list_active", listActive);
                _db.SetParameter("@list_inactive", listInactive);
                _db.ExecuteRead();

                while (_db.Reader.Read())
                {
                    Partner partner = new Partner();
                    ReadRow(partner);
                    partners.Add(partner);
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

            return partners;
        }

        private void SetParameters(Partner partner, bool isUpdate = false)
        {
            if (isUpdate)
            {
                _db.SetParameter("@business_partner_id", partner.Id);
            }

            // agregar los otros parámetros
        }

        private void ReadRow(Partner partner)
        {
            partner.Id = Convert.ToInt32(_db.Reader["business_partner_id"]);
            partner.ActivityStatus = (bool)_db.Reader["activity_status"];
            partner.IsClient = (bool)_db.Reader["is_client"];
            partner.IsSupplier = (bool)_db.Reader["is_supplier"];
        }
    }
}

using DomainModel;
using Exceptions;
using System;
using System.Collections.Generic;

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
                _db.SetProcedure("sp_create_partner");
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
                _db.SetQuery("select * from partners where partner_id = @partner_id");
                _db.SetParameter("@partner_id", partnerId);
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

        public void Update(Partner partner)
        {
            try
            {
                _db.SetProcedure("sp_update_partner");
                SetParameters(partner);
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

        public void Toggle(int partnerId)
        {
            try
            {
                _db.SetProcedure("sp_toggle_partner");
                _db.SetParameter("@partner_id", partnerId);
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

        public List<Partner> List(int organizationId, bool active, bool inactive)
        {
            List<Partner> partners = new List<Partner>();

            try
            {
                _db.SetProcedure("sp_list_partners");
                _db.SetParameter("@organization_id", organizationId);
                _db.SetParameter("@list_active", active);
                _db.SetParameter("@list_inactive", inactive);
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

        private void SetParameters(Partner partner)
        {
            _db.SetParameter("@partner_id", partner.Id);
            _db.SetParameter("@is_client", partner.IsClient);
            _db.SetParameter("@is_supplier", partner.IsSupplier);
        }

        private void ReadRow(Partner partner)
        {
            partner.Id = Convert.ToInt32(_db.Reader["partner_id"]);
            partner.ActivityStatus = (bool)_db.Reader["activity_status"];
            partner.IsClient = (bool)_db.Reader["is_client"];
            partner.IsSupplier = (bool)_db.Reader["is_supplier"];
        }
    }
}

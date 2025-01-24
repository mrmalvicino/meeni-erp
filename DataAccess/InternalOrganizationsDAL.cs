using DomainModel;
using Exceptions;
using Utilities;
using System;

namespace DataAccess
{
    public class InternalOrganizationsDAL
    {
        private Database _db;

        public InternalOrganizationsDAL(Database db)
        {
            _db = db;
        }

        public int Create(InternalOrganization internalOrganization)
        {
            try
            {
                _db.SetProcedure("sp_create_internal_organization");
                SetParameters(internalOrganization);
                internalOrganization.Id = _db.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return internalOrganization.Id;
        }

        public InternalOrganization Read(int internalOrganizationId)
        {
            try
            {
                _db.SetQuery("select * from internal_organizations where internal_organization_id = @internal_organization_id");
                _db.SetParameter("@internal_organization_id", internalOrganizationId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    InternalOrganization internalOrganization = new InternalOrganization();
                    ReadRow(internalOrganization);
                    return internalOrganization;
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

        public void Update(InternalOrganization internalOrganization)
        {
            try
            {
                _db.SetProcedure("sp_update_internal_organization");
                SetParameters(internalOrganization);
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

        private void SetParameters(InternalOrganization internalOrganization)
        {
            _db.SetParameter("@internal_organization_id", internalOrganization.Id);
            _db.SetParameter("@pricing_plan_id", internalOrganization.PricingPlan.Id);
        }

        private void ReadRow(InternalOrganization internalOrganization)
        {
            internalOrganization.Id = Convert.ToInt32(_db.Reader["internal_organization_id"]);
            internalOrganization.ActivityStatus = (bool)_db.Reader["activity_status"];
            internalOrganization.PricingPlan = Helper.Instantiate<PricingPlan>(_db.Reader["pricing_plan_id"]);
        }
    }
}

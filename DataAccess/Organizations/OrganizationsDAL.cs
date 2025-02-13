using DomainModel.Organizations;
using Exceptions;
using Utilities;
using System;

namespace DataAccess.Organizations
{
    public class OrganizationsDAL
    {
        private Database _db;

        public OrganizationsDAL(Database db)
        {
            _db = db;
        }

        public int Create(Organization organization)
        {
            try
            {
                _db.SetProcedure("sp_create_organization");
                SetParameters(organization);
                organization.Id = _db.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return organization.Id;
        }

        public Organization Read(int organizationId)
        {
            try
            {
                _db.SetQuery("select * from organizations where organization_id = @organization_id");
                _db.SetParameter("@organization_id", organizationId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    Organization organization = new Organization();
                    ReadRow(organization);
                    return organization;
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

        public void Update(Organization organization)
        {
            try
            {
                _db.SetProcedure("sp_update_organization");
                SetParameters(organization);
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

        public void Toggle(int organizationId)
        {
            try
            {
                _db.SetProcedure("sp_toggle_organization");
                _db.SetParameter("@organization_id", organizationId);
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

        private void SetParameters(Organization organization)
        {
            _db.SetParameter("@organization_id", organization.Id);
            _db.SetParameter("@pricing_plan_id", organization.PricingPlan.Id);
        }

        private void ReadRow(Organization organization)
        {
            organization.Id = Convert.ToInt32(_db.Reader["organization_id"]);
            organization.ActivityStatus = (bool)_db.Reader["activity_status"];
            organization.PricingPlan = Helper.Instantiate<PricingPlan>(_db.Reader["pricing_plan_id"]);
        }
    }
}

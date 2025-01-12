using System;
using DomainModel;

namespace DataAccess
{
    public class OrganizationsDAL
    {
        private Database _db;

        public OrganizationsDAL()
        {
            _db = new Database();
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
                throw ex;
            }
            finally
            {
                _db.CloseConnection();
            }

            return organization.Id;
        }

        private void SetParameters(Organization organization, bool isUpdate = false)
        {
            if (isUpdate)
            {
                _db.SetParameter("@organization_id", organization.Id);
                _db.SetParameter("@activity_status", organization.ActivityStatus);
            }

            _db.SetParameter("@organization_name", organization.Name);

            if (organization.LogoImage != null)
            {
                _db.SetParameter("@logo_image_id", organization.LogoImage.Id);
            }
            else
            {
                _db.SetParameter("@logo_image_id", DBNull.Value);
            }

            _db.SetParameter("@pricing_plan_id", organization.PricingPlan.Id);
        }
    }
}

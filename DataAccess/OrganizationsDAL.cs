using System;
using DomainModel;
using Exceptions;
using Utilities;

namespace DataAccess
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

        private void ReadRow(Organization organization)
        {
            organization.Id = Convert.ToInt32(_db.Reader["organization_id"]);
            organization.ActivityStatus = (bool)_db.Reader["activity_status"];
            organization.Name = _db.Reader["organization_name"].ToString();
            organization.LogoImage = Helper.InstantiateNull<Image>(_db.Reader["logo_image_id"]);
            organization.PricingPlan = Helper.InstantiateNull<PricingPlan>(_db.Reader["pricing_plan_id"]);
        }
    }
}

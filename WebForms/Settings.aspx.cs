using BusinessLogic;
using DomainModel;
using Exceptions;
using System;

namespace WebForms
{
	public partial class Settings : System.Web.UI.Page
	{
        private AppManager _appManager;
        private Organization _loggedOrganization;

        public Settings()
        {
            _appManager = new AppManager();
        }

        private void MapAttributes()
        {
            
        }

        private void MapControls()
        {
            
        }

        public void FetchSession()
        {
            _loggedOrganization = Session["loggedOrganization"] as Organization;
        }

        protected void Page_Load(object sender, EventArgs e)
		{
            (this.Master as Admin)?.CheckCredentials();

            FetchSession();

            if (!IsPostBack)
            {
                MapControls();
            }

            EntityContainersUC.Entity = _loggedOrganization;
            EntityContainersUC.IsOrganizationVisibility = false;
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            EntityContainersUC.MapAttributes();
            MapAttributes();

            try
            {
                _appManager.Organizations.Update(_loggedOrganization);
                Session["loggedOrganization"] = _loggedOrganization;
                Response.Redirect("Dashboard.aspx", false);
            }
            catch (ValidationException ex)
            {
                (this.Master.Master as Site)?.ShowModal(ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _appManager.Organizations.Toggle(_loggedOrganization.Id);
                (this.Master.Master as Site)?.Logout();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
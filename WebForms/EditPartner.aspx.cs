using BusinessLogic;
using DomainModel;
using Exceptions;
using System;

namespace WebForms
{
    public partial class EditPartner : System.Web.UI.Page
    {
        private AppManager _appManager;
        private Organization _loggedOrganization;
        private int _id;

        public EditPartner()
        {
            _appManager = new AppManager();
        }

        public void FetchSession()
        {
            _loggedOrganization = Session["loggedOrganization"] as Organization;
        }

        public void FetchURL()
        {
            string id = Request.QueryString["id"];

            if (!string.IsNullOrEmpty(id))
            {
                _id = Convert.ToInt32(id);
            }
        }

        private void FetchEntity()
        {
            FetchURL();
            FetchSession();

            int internalId = _appManager.Stakeholders.FindOrganizationId(_id);
            int loggedId = _loggedOrganization.Id;

            if (internalId == loggedId || _id == loggedId)
            {
                EditEntityUC.Entity = _appManager.Entities.Read(_id);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as Admin)?.CheckCredentials();
            FetchEntity();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            EditEntityUC.MapAttributes();

            try
            {
                _appManager.Entities.Update(EditEntityUC.Entity);
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
    }
}
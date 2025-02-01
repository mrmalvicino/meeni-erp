using BusinessLogic;
using DomainModel;
using Exceptions;
using System;

namespace WebForms
{
    public partial class EditPartner : System.Web.UI.Page
    {
        private AppManager _appManager;
        private Partner _partner;
        private Organization _loggedOrganization;
        private int _id;

        public EditPartner()
        {
            _appManager = new AppManager();
        }

        private void MapAttributes()
        {
            _partner.IsClient = IsClientChk.Checked;
            _partner.IsSupplier = IsSupplierChk.Checked;
        }

        private void MapControls()
        {
            IsClientChk.Checked = _partner.IsClient;
            IsSupplierChk.Checked = _partner.IsSupplier;
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
                _partner = _appManager.Partners.Read(_id);
            }
            else
            {
                Response.Redirect("~/Login.aspx", false);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as Admin)?.CheckCredentials();
            FetchEntity();

            if (!IsPostBack)
            {
                MapControls();
            }

            EditEntityUC.Entity = _partner;
            EditEntityUC.IsSwitchable = true;
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            EditEntityUC.MapAttributes();
            MapAttributes();

            try
            {
                _appManager.Partners.Update(_partner);
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
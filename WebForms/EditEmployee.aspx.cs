using BusinessLogic;
using DomainModel;
using Exceptions;
using System;

namespace WebForms
{
    public partial class EditEmployee : System.Web.UI.Page
    {
        private AppManager _appManager;
        private Employee _employee;
        private Organization _loggedOrganization;
        private int _id;

        public EditEmployee()
        {
            _appManager = new AppManager();
        }

        private void SetAdmissionDate()
        {
            DateTime admissionDate;
            DateTime.TryParse(AdmissionDateTxt.Text, out admissionDate);
            _employee.AdmissionDate = admissionDate;
        }

        private void MapAttributes()
        {
            SetAdmissionDate();
        }

        private void MapControls()
        {
            AdmissionDateTxt.Text = _employee.AdmissionDate.ToString("yyyy-MM-dd");
        }

        private void FetchEntity()
        {
            int internalId = _appManager.Stakeholders.FindOrganizationId(_id);
            int loggedId = _loggedOrganization.Id;

            if (internalId == loggedId || _id == loggedId)
            {
                _employee = _appManager.Employees.Read(_id);
            }
            else
            {
                Response.Redirect("~/Login.aspx", true);
            }
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

        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as Admin)?.CheckCredentials();

            FetchURL();
            FetchSession();
            FetchEntity();

            if (!IsPostBack)
            {
                MapControls();
            }

            EntityContainersUC.Entity = _employee;
            EntityContainersUC.IsOrganizationVisibility = false;
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            EntityContainersUC.MapAttributes();
            MapAttributes();

            try
            {
                _appManager.Employees.Update(_employee);
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
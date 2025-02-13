using DomainModel.Organizations;
using DomainModel.Stakeholders;
using BusinessLogic;
using Exceptions;
using System;

namespace WebForms
{
    public partial class AddEntity : System.Web.UI.Page
    {
        private AppManager _appManager;
        private Organization _loggedOrganization;
        private Partner _partner;
        private Employee _employee;
        private string _class;
        private int _id;

        public AddEntity()
        {
            _appManager = new AppManager();
        }

        private void InstantiateEntity()
        {
            if (_class == "Partner")
            {
                _partner = new Partner();
            }
            else if (_class == "Employee")
            {
                _employee = new Employee();
            }
        }

        private void MapAttributes()
        {
            InstantiateEntity();

            if (_partner != null)
            {
                _partner.IsOrganization = IsOrganizationChk.Checked;

                if (_partner.IsOrganization)
                {
                    _partner.Name = EntityNameFieldsUC.OrganizationName;
                }
                else
                {
                    _partner.FirstName = EntityNameFieldsUC.FirstName;
                    _partner.LastName = EntityNameFieldsUC.LastName;
                }
            }
            else if (_employee != null)
            {
                _employee.IsOrganization = false;
                _employee.FirstName = EntityNameFieldsUC.FirstName;
                _employee.LastName = EntityNameFieldsUC.LastName;
            }
        }

        private void MapControls()
        {
            if (_class == "Partner")
            {
                title.InnerText = "Agregar socio comercial";
                IsOrganizationDiv.Visible = true;
            }
            else if (_class == "Employee")
            {
                title.InnerText = "Agregar empleado";
                IsOrganizationDiv.Visible = false;
            }
        }

        private void FetchSession()
        {
            _loggedOrganization = Session["loggedOrganization"] as Organization;
        }

        private void FetchURL()
        {
            _class = Request.QueryString["class"];

            if (string.IsNullOrEmpty(_class))
            {
                Response.Redirect("~/Dashboard.aspx", false);
                return;
            }

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

            if (!IsPostBack)
            {
                MapControls();
                EntityNameFieldsUC.ShowPersonName();
            }
        }

        protected void IsOrganizationChk_CheckedChanged(object sender, EventArgs e)
        {
            EntityNameFieldsUC.ToggleNameType();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            MapAttributes();

            try
            {
                if (_partner != null)
                {
                    _appManager.Partners.Create(_partner, _loggedOrganization.Id);
                    Response.Redirect("Partners.aspx", false);
                }
                else if (_employee != null)
                {
                    _appManager.Employees.Create(_employee, _loggedOrganization.Id);
                    Response.Redirect("Employees.aspx", false);
                }
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
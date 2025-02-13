using DomainModel.Organizations;
using DomainModel.Stakeholders;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Linq;

namespace WebForms
{
    public partial class Employees : System.Web.UI.Page
    {
        private AppManager _appManager;
        private List<Employee> _employees;
        private Organization _loggedOrganization;

        public Employees()
        {
            _appManager = new AppManager();
        }

        private void BindEmployeesRpt()
        {
            EmployeesRpt.DataSource = _employees;
            EmployeesRpt.DataBind();
        }

        private void ApplyFilter()
        {
            _employees = _employees.Where(
                x => x.Name.ToLower().Contains(SearchTxt.Text.ToLower())
                || x.Email.ToLower().Contains(SearchTxt.Text.ToLower())
                || x.Phone.ToLower().Contains(SearchTxt.Text.ToLower())
                ).ToList();
        }

        private void FetchEmployees()
        {
            bool listActive = true;
            bool listInactive = true;

            string activityStatusDDL = ActivityStatusDDL.SelectedValue;

            if (activityStatusDDL == "Active")
            {
                listInactive = false;
            }
            else if (activityStatusDDL == "Inactive")
            {
                listActive = false;
            }

            _employees = _appManager.Employees.List(_loggedOrganization.Id, listActive, listInactive);
        }

        private void MapControls(bool applyFilter = false)
        {
            FetchEmployees();

            if (applyFilter)
            {
                ApplyFilter();
            }

            BindEmployeesRpt();
        }

        private void FetchSession()
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
        }

        protected void ActivityStatusDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchTxt.Text = string.Empty;
            MapControls();
        }

        protected void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            MapControls(true);
        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            MapControls(true);
        }

        protected void EmployeesRpt_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int employeeId = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Edit")
            {
                Response.Redirect($"EditEmployee.aspx?id={employeeId}");
            }
            else if (e.CommandName == "Delete")
            {
                _appManager.Employees.Toggle(employeeId);
                MapControls();
            }
        }
    }
}
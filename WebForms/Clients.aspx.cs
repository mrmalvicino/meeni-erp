using BusinessLogic;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Linq;

namespace WebForms
{
    public partial class Clients : System.Web.UI.Page
    {
        private ApplicationManager _appManager;
        private List<BusinessPartner> _humanClients;
        private List<BusinessPartner> _corporateClients;
        private InternalOrganization _loggedOrganization;

        public Clients()
        {
            _appManager = new ApplicationManager();
        }

        private void FetchLoggedOrganization()
        {
            _loggedOrganization = Session["loggedOrganization"] as InternalOrganization;
        }

        private void FetchClients()
        {
            bool listActive = true;
            bool listInactive = true;

            string selectedValue = ActivityStatusDDL.SelectedValue;

            if (selectedValue == "Active")
            {
                listActive = true;
                listInactive = false;
            }
            else if (selectedValue == "Inactive")
            {
                listActive = false;
                listInactive = true;
            }

            _humanClients = _appManager.BusinessPartners.List(
                true, false, true, _loggedOrganization.Id, listActive, listInactive);

            _corporateClients = _appManager.BusinessPartners.List(
                true, false, false, _loggedOrganization.Id, listActive, listInactive);
        }

        private void BindHumanClientsRpt()
        {
            HumanClientsRpt.DataSource = _humanClients;
            HumanClientsRpt.DataBind();
        }

        private void BindCorporateClientsRpt()
        {
            CorporateClientsRpt.DataSource = _corporateClients;
            CorporateClientsRpt.DataBind();
        }

        private void ApplyFilter()
        {
            _humanClients = _humanClients.Where(
                x => x.Person.FirstName.ToLower().Contains(SearchTxt.Text.ToLower())
                || x.Person.LastName.ToLower().Contains(SearchTxt.Text.ToLower())
                ).ToList();

            _corporateClients = _corporateClients.Where(
                x => x.Organization.Name.ToLower().Contains(SearchTxt.Text.ToLower())
                ).ToList();
        }

        private void MapControls(bool applyFilter = false)
        {
            FetchClients();

            if (applyFilter)
            {
                ApplyFilter();
            }

            BindHumanClientsRpt();
            BindCorporateClientsRpt();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as Admin)?.CheckCredentials();
            
            FetchLoggedOrganization();

            if (!IsPostBack)
            {
                MapControls();
            }
        }

        protected void HumanClientsRpt_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int personId = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Edit")
            {
                Response.Redirect($"ViewPerson.aspx?id={personId}");
            }
            else if (e.CommandName == "Delete")
            {
                //_appManager.BusinessPartners.Toggle();
            }
        }

        protected void CorporateClientsRpt_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int externalOrganizationId = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Edit")
            {
                Response.Redirect($"ViewOrganization.aspx?id={externalOrganizationId}");
            }
            else if (e.CommandName == "Delete")
            {
                //_appManager.BusinessPartners.Toggle();
            }
        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            MapControls(true);
        }

        protected void RefreshBtn_Click(object sender, EventArgs e)
        {
            SearchTxt.Text = string.Empty;
            MapControls();
        }

        protected void CreateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
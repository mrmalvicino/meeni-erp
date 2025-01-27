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
            _humanClients = _appManager.BusinessPartners.List(true, false, true, _loggedOrganization.Id);
            _corporateClients = _appManager.BusinessPartners.List(true, false, false, _loggedOrganization.Id);
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

        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as Admin)?.CheckCredentials();

            FetchLoggedOrganization();

            if (!IsPostBack)
            {
                FetchClients();
                BindHumanClientsRpt();
                BindCorporateClientsRpt();
            }
        }

        protected void HumanClientsRpt_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int clientId = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Edit")
            {

            }
            else if (e.CommandName == "Delete")
            {

            }
        }

        protected void CorporateClientsRpt_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int clientId = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Edit")
            {

            }
            else if (e.CommandName == "Delete")
            {

            }
        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            FetchClients();
            ApplyFilter();
            BindHumanClientsRpt();
            BindCorporateClientsRpt();
        }
    }
}
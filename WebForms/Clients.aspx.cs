using BusinessLogic;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

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

        public void FetchClients()
        {
            _humanClients = _appManager.BusinessPartners.List(true, false, true, _loggedOrganization.Id);
            _corporateClients = _appManager.BusinessPartners.List(true, false, false, _loggedOrganization.Id);
        }

        public void BindHumanClientsRpt()
        {
            HumanClientsRpt.DataSource = _humanClients;
            HumanClientsRpt.DataBind();
        }

        public void BindCorporateClientsRpt()
        {
            CorporateClientsRpt.DataSource = _corporateClients;
            CorporateClientsRpt.DataBind();
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
    }
}
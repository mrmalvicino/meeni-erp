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
        private AppManager _appManager;
        private List<Partner> _clients;
        private Organization _loggedOrganization;

        public Clients()
        {
            _appManager = new AppManager();
        }

        private void FetchLoggedOrganization()
        {
            _loggedOrganization = Session["loggedOrganization"] as Organization;
        }

        private void FetchClients()
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

            _clients = _appManager.Partners.List(
                true, false, _loggedOrganization.Id, listActive, listInactive);
        }

        private void BindClientsRpt()
        {
            ClientsRpt.DataSource = _clients;
            ClientsRpt.DataBind();
        }

        private void ApplyFilter()
        {
            _clients = _clients.Where(
                x => x.Name.ToLower().Contains(SearchTxt.Text.ToLower())
                || x.TaxCode.ToLower().Contains(SearchTxt.Text.ToLower())
                || x.Email.ToLower().Contains(SearchTxt.Text.ToLower())
                || x.Phone.ToLower().Contains(SearchTxt.Text.ToLower())
                ).ToList();
        }

        private void MapControls(bool applyFilter = false)
        {
            FetchClients();

            if (applyFilter)
            {
                ApplyFilter();
            }

            BindClientsRpt();
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

        protected void ClientsRpt_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int partnerId = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Edit")
            {
                Response.Redirect($"EditEntity.aspx?id={partnerId}");
            }
            else if (e.CommandName == "Delete")
            {
                _appManager.Partners.Toggle(partnerId);
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
    }
}
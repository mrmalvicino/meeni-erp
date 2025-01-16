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
        private List<Client> _clients;
        private Client _client;

        public Clients()
        {
            _appManager = new ApplicationManager();
            _client = new Client();
        }

        public void FetchClients()
        {
            _clients = _appManager.Clients.List();
        }

        public void BindClientsRpt()
        {
            ClientsRpt.DataSource = _clients;
            ClientsRpt.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FetchClients();
                BindClientsRpt();
            }
        }

        protected void ClientsRpt_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            _client.Id = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "View")
            {

            }
            else if (e.CommandName == "Edit")
            {

            }
            else if (e.CommandName == "Delete")
            {

            }
        }
    }
}
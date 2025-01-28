using BusinessLogic;
using DomainModel;
using System;

namespace WebForms
{
    public partial class Dashboard : System.Web.UI.Page
    {
        private AppManager _appManager;
        private Organization _internalOrganization;

        public Dashboard()
        {
            _appManager = new AppManager();
        }

        private void FetchInternalOrganization()
        {
            _internalOrganization = Session["loggedOrganization"] as Organization;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            FetchInternalOrganization();
            (this.Master as Admin)?.CheckCredentials();
        }
    }
}
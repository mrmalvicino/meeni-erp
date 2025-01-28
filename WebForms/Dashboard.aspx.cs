using BusinessLogic;
using DomainModel;
using System;

namespace WebForms
{
    public partial class Dashboard : System.Web.UI.Page
    {
        private AppManager _appManager;
        private Organization _organization;

        public Dashboard()
        {
            _appManager = new AppManager();
        }

        private void FetchInternalOrganization()
        {
            _organization = Session["loggedOrganization"] as Organization;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            FetchInternalOrganization();
            (this.Master as Admin)?.CheckCredentials();
        }
    }
}
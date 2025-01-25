using BusinessLogic;
using DomainModel;
using System;

namespace WebForms
{
    public partial class Dashboard : System.Web.UI.Page
    {
        private ApplicationManager _appManager;
        private InternalOrganization _internalOrganization;

        public Dashboard()
        {
            _appManager = new ApplicationManager();
        }

        private void FetchInternalOrganization()
        {
            _internalOrganization = Session["loggedOrganization"] as InternalOrganization;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            FetchInternalOrganization();
            (this.Master as Admin)?.CheckCredentials();
        }
    }
}
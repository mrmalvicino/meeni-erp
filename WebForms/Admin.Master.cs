using DomainModel;
using System;

namespace WebForms
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        private Organization _loggedOrganization;
        private User _loggedUser;

        public void CheckCredentials()
        {
            if (Session["loggedUser"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }

            if (Session["loggedOrganization"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }
        }

        private void FetchSession()
        {
            _loggedOrganization = Session["loggedOrganization"] as Organization;
            _loggedUser = Session["loggedUser"] as User;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EditUserBtn_Click(object sender, EventArgs e)
        {
            FetchSession();
            Response.Redirect($"EditEntity.aspx?id={_loggedUser.Id}");
        }

        protected void EditOrganizationBtn_Click(object sender, EventArgs e)
        {
            FetchSession();
            Response.Redirect($"EditEntity.aspx?id={_loggedOrganization.Id}");
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            (this.Master as Site)?.Logout();
        }
    }
}
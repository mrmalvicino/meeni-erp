using System;

namespace WebForms
{
    public partial class Admin : System.Web.UI.MasterPage
    {
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

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            (this.Master as Site)?.Logout();
        }
    }
}
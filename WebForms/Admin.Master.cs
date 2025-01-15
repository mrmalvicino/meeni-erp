using System;

namespace WebForms
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            var masterPage = this.Master as Site;

            if (masterPage != null)
            {
                masterPage.Logout();
            }
        }
    }
}
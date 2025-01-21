using System;
using System.Web.UI;

namespace WebForms
{
    public partial class Site : System.Web.UI.MasterPage
    {
        public void Logout()
        {
            Session["loggedUser"] = null;
            Session["loggedOrganization"] = null;
            Session.Clear();
            Session.Abandon();
            Response.Redirect("~/Login.aspx", false);
            Context.ApplicationInstance.CompleteRequest();
        }

        public void ShowModal(string message)
        {
            ModalLbl.Text = message;
            ScriptManager.RegisterStartupScript(this, typeof(Page), "ShowModal", "document.addEventListener('DOMContentLoaded', () => { showModal(); });", true);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
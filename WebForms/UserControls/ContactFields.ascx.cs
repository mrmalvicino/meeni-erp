using System;

namespace WebForms.UserControls
{
    public partial class ContactFields : System.Web.UI.UserControl
    {
        public string Email
        {
            get { return EmailTxt.Text; }
            set { EmailTxt.Text = value; }
        }

        public string Phone
        {
            get { return PhoneTxt.Text; }
            set { PhoneTxt.Text = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
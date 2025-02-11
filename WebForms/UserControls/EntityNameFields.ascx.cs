using System;

namespace WebForms.UserControls
{
    public partial class EntityNameFields : System.Web.UI.UserControl
    {
        public string OrganizationName
        {
            get { return OrganizationNameTxt.Text; }
            set { OrganizationNameTxt.Text = value; }
        }

        public string FirstName
        {
            get { return FirstNameTxt.Text; }
            set { FirstNameTxt.Text = value; }
        }

        public string LastName
        {
            get { return LastNameTxt.Text; }
            set { LastNameTxt.Text = value; }
        }

        public void ShowOrganizationName()
        {
            OrganizationNameDiv.Visible = true;
            PersonNameDiv.Visible = false;
        }

        public void ShowPersonName()
        {
            OrganizationNameDiv.Visible = false;
            PersonNameDiv.Visible = true;
        }

        public void ToggleNameType()
        {
            OrganizationNameDiv.Visible = !OrganizationNameDiv.Visible;
            PersonNameDiv.Visible = !PersonNameDiv.Visible;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
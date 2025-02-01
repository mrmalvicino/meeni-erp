using System;

namespace WebForms.UserControls
{
    public partial class EntityName : System.Web.UI.UserControl
    {
        public string GetOrganizationName()
        {
            return OrganizationNameTxt.Text;
        }

        public string GetFirstName()
        {
            return FirstNameTxt.Text;
        }

        public string GetLastName()
        {
            return LastNameTxt.Text;
        }

        public void SetOrganizationName(string name)
        {
            OrganizationNameTxt.Text = name;
        }

        public void SetPersonName(string firstName, string lastName)
        {
            FirstNameTxt.Text = firstName;
            LastNameTxt.Text = lastName;
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
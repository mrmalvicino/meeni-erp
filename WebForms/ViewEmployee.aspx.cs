using BusinessLogic;
using DomainModel;
using Exceptions;
using Utilities;
using System;

namespace WebForms
{
    public partial class ViewEmployee : System.Web.UI.Page
    {
        private ApplicationManager _appManager;
        private User _loggedUser;
        private Employee _employee;
        private int _employeeId;

        public ViewEmployee()
        {
            _appManager = new ApplicationManager();
        }

        private void LoadImage()
        {
            if (Validator.URLExists(ImageURLTxt.Text))
            {
                ProfileImg.ImageUrl = ImageURLTxt.Text;
                return;
            }

            ImageURLTxt.Text = "";
            ProfileImg.ImageUrl = "https://github.com/mrmalvicino/meeni-erp/blob/main/WebForms/images/logo.png?raw=true";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as Admin)?.CheckCredentials();

            //FetchEmployee();

            if (!IsPostBack)
            {
                //MapControls();
            }

            LoadImage();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
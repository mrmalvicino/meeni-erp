using BusinessLogic;
using DomainModel;
using System;

namespace WebForms
{
    public partial class AddEntity : System.Web.UI.Page
    {
        private AppManager _appManager;
        private Partner _partner;
        private Employee _employee;
        private User _user;
        private string _class;
        private int _id;

        public AddEntity()
        {
            _appManager = new AppManager();
        }

        private void FetchURL()
        {
            _class = Request.QueryString["class"];

            if (string.IsNullOrEmpty(_class))
            {
                Response.Redirect("~/Dashboard.aspx", false);
                return;
            }

            string id = Request.QueryString["id"];

            if (!string.IsNullOrEmpty(id))
            {
                _id = Convert.ToInt32(id);
            }
        }

        private void Instantiate()
        {
            if (_class == "Partner")
            {
                _partner = new Partner();
            }
            else if(_class == "Employee")
            {
                _employee = new Employee();
            }
            else if (_class == "User")
            {
                _user = new User();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
using BusinessLogic;
using DomainModel;
using System;

namespace WebForms
{
    public partial class Login : System.Web.UI.Page
    {
        private ApplicationManager _appManager;
        private User _loggedUser;
        private Organization _loggedOrganization;

        public Login()
        {
            _appManager = new ApplicationManager();
            _loggedUser = new User();
            _loggedOrganization = new Organization();
        }

        private void MapAttributes()
        {
            _loggedUser.Username = UsernameTxt.Text;
            _loggedUser.Password = PasswordTxt.Text;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            MapAttributes();

            try
            {
                if (_appManager.Login(ref _loggedUser, ref _loggedOrganization))
                {
                    Session.Add("loggedUser", _loggedUser);
                    Session.Add("loggedOrganization", _loggedOrganization);
                    Response.Redirect("Home.aspx", false);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
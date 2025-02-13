using DomainModel.Organizations;
using DomainModel.Users;
using BusinessLogic;
using Exceptions;
using System;

namespace WebForms
{
    public partial class Login : System.Web.UI.Page
    {
        private AppManager _appManager;
        private Organization _organization;
        private User _user;

        public Login()
        {
            _appManager = new AppManager();
            _organization = new Organization();
            _user = new User();
        }

        private void MapAttributes()
        {
            _user.Username = UsernameTxt.Text;
            _user.Password = PasswordTxt.Text;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            MapAttributes();

            try
            {
                if (_appManager.Login(ref _user, ref _organization))
                {
                    Session.Add("loggedUser", _user);
                    Session.Add("loggedOrganization", _organization);
                    Response.Redirect("Dashboard.aspx", false);
                }
            }
            catch (ValidationException ex)
            {
                (this.Master.Master as Site)?.ShowModal(ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
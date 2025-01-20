using BusinessLogic;
using DomainModel;
using System;
using System.Collections.Generic;

namespace WebForms
{
    public partial class Signup : System.Web.UI.Page
    {
        private ApplicationManager _appManager;
        private InternalOrganization _internalOrganization;
        private User _user;

        public Signup()
        {
            _appManager = new ApplicationManager();
            _internalOrganization = new InternalOrganization();
            _user = new User();
        }

        private void BindPricingPlansDDL()
        {
            PricingPlansDDL.DataSource = _appManager.PricingPlans.List();
            PricingPlansDDL.DataTextField = "Name";
            PricingPlansDDL.DataValueField = "Id";
            PricingPlansDDL.DataBind();
            PricingPlansDDL.SelectedIndex = -1;
        }

        private void MapAttributes()
        {
            _internalOrganization.Name = OrganizationNameTxt.Text;
            _internalOrganization.Email = OrganizationEmailTxt.Text;

            int pricingPlanId = (int)PricingPlansManager.Ids.FreePlanId;
            _internalOrganization.PricingPlan = _appManager.PricingPlans.Read(pricingPlanId);

            Role role = new Role();
            role.Id = (int)RolesManager.Ids.AdminId;
            _user.Roles = new List<Role>();
            _user.Roles.Add(role);

            _user.FirstName = FirstNameTxt.Text;
            _user.LastName = LastNameTxt.Text;
            _user.Username = OrganizationEmailTxt.Text;
            _user.Password = PasswordTxt.Text;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindPricingPlansDDL();
            }
        }

        protected void SignupBtn_Click(object sender, EventArgs e)
        {
            MapAttributes();

            try
            {
                if (_appManager.SignUp(ref _user, ref _internalOrganization))
                {
                    Session.Add("loggedUser", _user);
                    Session.Add("loggedOrganization", _internalOrganization);
                    Response.Redirect("Dashboard.aspx", false);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
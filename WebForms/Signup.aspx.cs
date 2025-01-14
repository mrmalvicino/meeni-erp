using BusinessLogic;
using DomainModel;
using System;
using System.Collections.Generic;

namespace WebForms
{
    public partial class Signup : System.Web.UI.Page
    {
        private ApplicationManager _appManager;
        private Organization _newOrganization;
        private User _newUser;

        public Signup()
        {
            _appManager = new ApplicationManager();
            _newOrganization = new Organization();
            _newUser = new User();
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
            _newOrganization.Name = OrganizationNameTxt.Text;

            PricingPlan pricingPlan = new PricingPlan();
            pricingPlan.Id = (int)PricingPlansManager.Ids.FreePlanId;
            _newOrganization.PricingPlan = pricingPlan;

            Role role = new Role();
            role.Id = (int)RolesManager.Ids.AdminRoleId;
            _newUser.Roles = new List<Role>();
            _newUser.Roles.Add(role);

            _newUser.Username = UsernameTxt.Text;
            _newUser.Password = PasswordTxt.Text;
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
                if (_appManager.SignUp(ref _newUser, ref _newOrganization))
                {
                    Session.Add("loggedUser", _newUser);
                    Session.Add("loggedOrganization", _newOrganization);
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
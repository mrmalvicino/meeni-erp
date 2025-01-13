using BusinessLogic;
using DomainModel;
using System;
using System.Collections.Generic;

namespace WebForms
{
    public partial class Signup : System.Web.UI.Page
    {
        private ApplicationManager _appManager;
        private Organization _organization;
        private User _user;

        public Signup()
        {
            _appManager = new ApplicationManager();
            _organization = new Organization();
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
            _organization.Name = OrganizationNameTxt.Text;

            PricingPlan pricingPlan = new PricingPlan();
            pricingPlan.Id = (int)PricingPlansManager.Ids.FreePlanId;
            _organization.PricingPlan = pricingPlan;

            Role role = new Role();
            role.Id = (int)RolesManager.Ids.AdminRoleId;
            _user.Roles = new List<Role>();
            _user.Roles.Add(role);

            _user.Username = UsernameTxt.Text;
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
                _appManager.SignUp(_user, _organization);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
using BusinessLogic;
using DomainModel;
using System;
using System.Collections.Generic;
using Exceptions;

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

        private void InstantiateAttributes()
        {
            _internalOrganization.LogoImage = new Image();
            _internalOrganization.Address = new Address(true);

            int pricingPlanId = (int)PricingPlansManager.Ids.FreePlanId;
            PricingPlan pricingPlan = _appManager.PricingPlans.Read(pricingPlanId);
            _internalOrganization.PricingPlan = pricingPlan;

            _user.ProfileImage = new Image();
            _user.Address = new Address(true);
            _user.Roles = new List<Role>();

            int roleId = (int)RolesManager.Ids.AdminId;
            Role role = _appManager.Roles.Read(roleId);
            _user.Roles.Add(role);
        }

        private void MapAttributes()
        {
            _internalOrganization.Name = OrganizationNameTxt.Text;
            _internalOrganization.Email = OrganizationEmailTxt.Text;
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
            InstantiateAttributes();
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
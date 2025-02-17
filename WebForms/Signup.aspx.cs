using DomainModel.Common;
using DomainModel.Locations;
using DomainModel.Organizations;
using DomainModel.Users;
using BusinessLogic;
using BusinessLogic.Organizations;
using BusinessLogic.Users;
using System;
using System.Collections.Generic;
using Exceptions;

namespace WebForms
{
    public partial class Signup : System.Web.UI.Page
    {
        private AppManager _appManager;
        private Organization _organization;
        private User _user;
        private string _id;

        public Signup()
        {
            _appManager = new AppManager();
            _organization = new Organization();
            _user = new User();
        }

        private void FetchURL()
        {
            _id = Request.QueryString["id"];
        }

        private void BindPricingPlansDDL(string selectedValue = "0")
        {
            PricingPlansDDL.DataSource = _appManager.PricingPlans.List();
            PricingPlansDDL.DataTextField = "Name";
            PricingPlansDDL.DataValueField = "Id";
            PricingPlansDDL.DataBind();

            if (PricingPlansDDL.Items.FindByValue(selectedValue) != null)
            {
                PricingPlansDDL.SelectedValue = selectedValue;
            }
            else
            {
                PricingPlansDDL.SelectedIndex = 0;
            }
        }

        private void InstantiateAttributes()
        {
            _organization.Image = new Image();
            _organization.Address = new Address(true);

            int pricingPlanId = (int)PricingPlansManager.Ids.FreePlanId;
            PricingPlan pricingPlan = _appManager.PricingPlans.Read(pricingPlanId);
            _organization.PricingPlan = pricingPlan;

            _user.Image = new Image();
            _user.Address = new Address(true);
            _user.Roles = new List<Role>();

            int roleId = (int)RolesManager.Ids.AdminId;
            Role role = _appManager.Roles.Read(roleId);
            _user.Roles.Add(role);
        }

        private void MapAttributes()
        {
            _organization.IsOrganization = true;
            _organization.Name = OrganizationNameTxt.Text;
            _organization.Email = OrganizationEmailTxt.Text;
            _user.FirstName = EntityNameFieldsUC.FirstName;
            _user.LastName = EntityNameFieldsUC.LastName;
            _user.Username = UsernameTxt.Text;
            _user.Password = PasswordTxt.Text;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FetchURL();
                BindPricingPlansDDL(_id);
            }

            EntityNameFieldsUC.ShowPersonName();
        }

        protected void SignupBtn_Click(object sender, EventArgs e)
        {
            InstantiateAttributes();
            MapAttributes();

            try
            {
                if (_appManager.SignUp(ref _user, ref _organization))
                {
                    Session.Add("loggedUser", _user);
                    Session.Add("loggedOrganization", _organization);
                    _appManager.SendWelcomeEmail(_user, _organization);
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
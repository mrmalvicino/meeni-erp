using BusinessLogic;
using System;

namespace WebForms
{
    public partial class Signup : System.Web.UI.Page
    {
        private PricingPlansManager _pricingPlansManager;

        public Signup()
        {
            _pricingPlansManager = new PricingPlansManager();
        }

        private void BindPricingPlansDDL()
        {
            pricingPlansDDL.DataSource = _pricingPlansManager.List();
            pricingPlansDDL.DataTextField = "Name";
            pricingPlansDDL.DataValueField = "Id";
            pricingPlansDDL.DataBind();
            pricingPlansDDL.SelectedIndex = 0;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindPricingPlansDDL();
            }
        }
    }
}
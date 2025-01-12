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
            PricingPlansDDL.DataSource = _pricingPlansManager.List();
            PricingPlansDDL.DataTextField = "Name";
            PricingPlansDDL.DataValueField = "Id";
            PricingPlansDDL.DataBind();
            PricingPlansDDL.SelectedIndex = -1;
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
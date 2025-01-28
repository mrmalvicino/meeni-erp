using BusinessLogic;
using DomainModel;
using System;
using System.Collections.Generic;

namespace WebForms
{
    public partial class Home : System.Web.UI.Page
    {
        private AppManager _appManager;

        public List<PricingPlan> PricingPlans { get; set; }

        public Home()
        {
            _appManager = new AppManager();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PricingPlans = _appManager.PricingPlans.List();
            }
        }
    }
}
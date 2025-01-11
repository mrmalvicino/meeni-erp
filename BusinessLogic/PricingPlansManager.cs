using DataAccess;
using DomainModel;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class PricingPlansManager
    {
        public enum Ids
        {
            FreePlanId = 1,
            ProfessionalPlanId = 2,
            EnterprisePlanId = 3
        }

        private PricingPlansDAL _pricingPlansDAL;

        public PricingPlansManager()
        {
            _pricingPlansDAL = new PricingPlansDAL();
        }

        public List<PricingPlan> List()
        {
            return _pricingPlansDAL.List();
        }
    }
}

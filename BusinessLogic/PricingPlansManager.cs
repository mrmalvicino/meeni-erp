using DataAccess;
using DomainModel;
using System;
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

        public PricingPlansManager(Database db)
        {
            _pricingPlansDAL = new PricingPlansDAL(db);
        }

        public List<PricingPlan> List()
        {
            try
            {
                return _pricingPlansDAL.List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

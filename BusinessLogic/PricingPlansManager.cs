using DataAccess;
using DomainModel;
using Exceptions;
using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

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

        public PricingPlan Read(int pricingPlanId)
        {
            if (pricingPlanId == 0)
            {
                return null;
            }

            try
            {
                return _pricingPlansDAL.Read(pricingPlanId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }

        public List<PricingPlan> List()
        {
            try
            {
                return _pricingPlansDAL.List();
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }
    }
}

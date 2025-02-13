using DataAccess;
using DataAccess.Organizations;
using DomainModel.Organizations;
using Exceptions;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Organizations
{
    public class PricingPlansManager
    {
        public enum Ids
        {
            FreePlanId = 1,
            ProfessionalPlanId = 2,
            EnterprisePlanId = 3
        }

        private PricingPlan _pricingPlan;
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
                _pricingPlan = _pricingPlansDAL.Read(pricingPlanId);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }

            return _pricingPlan;
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

        public int FindId(PricingPlan pricingPlan)
        {
            try
            {
                return _pricingPlansDAL.FindId(pricingPlan);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException(ex);
            }
        }
    }
}

using DomainModel;
using Exceptions;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class PricingPlansDAL
    {
        private Database _db;

        public PricingPlansDAL(Database db)
        {
            _db = db;
        }

        public PricingPlan Read(int pricingPlanId)
        {
            try
            {
                _db.SetQuery("select * from pricing_plans where pricing_plan_id = @pricing_plan_id");
                _db.SetParameter("@pricing_plan_id", pricingPlanId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    PricingPlan pricingPlan = new PricingPlan();
                    ReadRow(pricingPlan);
                    return pricingPlan;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }
        }

        public List<PricingPlan> List()
        {
            List<PricingPlan> pricingPlans = new List<PricingPlan>();

            try
            {
                _db.SetQuery("select * from pricing_plans");
                _db.ExecuteRead();

                while (_db.Reader.Read())
                {
                    PricingPlan pricingPlan = new PricingPlan();
                    ReadRow(pricingPlan);
                    pricingPlans.Add(pricingPlan);
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return pricingPlans;
        }

        private void ReadRow(PricingPlan pricingPlan)
        {
            pricingPlan.Id = Convert.ToInt32(_db.Reader["pricing_plan_id"]);
            pricingPlan.Name = _db.Reader["pricing_plan_name"].ToString();
            pricingPlan.MonthlyFee = (decimal)_db.Reader["monthly_fee"];
        }
    }
}

using DomainModel;
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

                    pricingPlan.Id = Convert.ToInt32(_db.Reader["pricing_plan_id"]);
                    pricingPlan.Name = _db.Reader["pricing_plan_name"].ToString();
                    pricingPlan.MonthlyFee = _db.Reader["monthly_fee"] as decimal? ?? pricingPlan.MonthlyFee;

                    pricingPlans.Add(pricingPlan);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _db.CloseConnection();
            }

            return pricingPlans;
        }
    }
}

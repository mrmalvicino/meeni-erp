using Interfaces;

namespace DomainModel
{
    public class PricingPlan : IIdentifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal MonthlyFee { get; set; }
    }
}

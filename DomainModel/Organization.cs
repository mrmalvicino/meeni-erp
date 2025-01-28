using System;

namespace DomainModel
{
    public class Organization : Entity
    {
        public bool ActivityStatus { get; set; }
        public DateTime AdmissionDate { get; set; }
        public PricingPlan PricingPlan { get; set; }
    }
}
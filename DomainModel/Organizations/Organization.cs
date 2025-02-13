using DomainModel.Base;
using Interfaces;
using System;

namespace DomainModel.Organizations
{
    public class Organization : Entity, IDispensable
    {
        public bool ActivityStatus { get; set; }
        public DateTime AdmissionDate { get; set; }
        public PricingPlan PricingPlan { get; set; }
    }
}
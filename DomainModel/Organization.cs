using System;
using System.Collections.Generic;

namespace DomainModel
{
    public class Organization : LegalEntity
    {
        public bool ActivityStatus { get; set; }
        public DateTime AdmissionDate { get; set; }
        public PricingPlan PricingPlan { get; set; }
        public List<BusinessPartner> BusinessPartners { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
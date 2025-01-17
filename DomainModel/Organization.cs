using System.Collections.Generic;

namespace DomainModel
{
    public class Organization : LegalEntity
    {
        public PricingPlan PricingPlan { get; set; }
        public List<BusinessPartner> BusinessPartners { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
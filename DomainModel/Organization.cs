using Interfaces;
using System.Collections.Generic;

namespace DomainModel
{
    public class Organization : IIdentifiable
    {
        public int Id { get; set; }
        public bool ActivityStatus { get; set; }
        public string Name { get; set; }
        public string TaxCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public Image LogoImage { get; set; }
        public PricingPlan PricingPlan { get; set; }
        public List<Client> Clients { get; set; }
        public List<Supplier> Suppliers { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
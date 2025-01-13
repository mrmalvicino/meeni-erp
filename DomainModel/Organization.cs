using Interfaces;
using System.Collections.Generic;

namespace DomainModel
{
    public class Organization : IIdentifiable
    {
        public int Id { get; set; }
        public bool ActivityStatus { get; set; }
        public string Name { get; set; }
        public Image LogoImage { get; set; }
        public PricingPlan PricingPlan { get; set; }
        public List<User> Users { get; set; }
    }
}
namespace DomainModel
{
    public class Organization
    {
        public int Id { get; set; }
        public bool ActivityStatus { get; set; }
        public string Name { get; set; }
        public Image LogoImage { get; set; }
        public PricingPlan PricingPlan { get; set; }
    }
}
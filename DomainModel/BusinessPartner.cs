using Interfaces;

namespace DomainModel
{
    public class BusinessPartner : IIdentifiable
    {
        public int Id { get; set; }
        public bool ActivityStatus { get; set; }
        public bool IsClient { get; set; }
        public bool IsSupplier { get; set; }
        public ExternalOrganization Organization { get; set; }
        public Person Person { get; set; }
    }
}

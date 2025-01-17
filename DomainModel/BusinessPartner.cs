using Interfaces;
using System.Collections.Generic;

namespace DomainModel
{
    public class BusinessPartner : IIdentifiable
    {
        public int Id { get; set; }
        public bool ActivityStatus { get; set; }
        public LegalEntity LegalEntity { get; set; }
        public List<Person> People { get; set; }
        public List<PartnerType> PartnerTypes { get; set; }
    }
}

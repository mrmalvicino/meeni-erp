using Interfaces;

namespace DomainModel
{
    public class Address : IIdentifiable
    {
        public int Id { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string Flat { get; set; }
        public string Details { get; set; }
        public City City { get; set; }
        public Province Province { get; set; }
        public Country Country { get; set; }
    }
}

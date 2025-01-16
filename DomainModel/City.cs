using Interfaces;

namespace DomainModel
{
    public class City : IIdentifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ZipCode { get; set; }
    }
}

using Interfaces;

namespace DomainModel
{
    public class Country : IIdentifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

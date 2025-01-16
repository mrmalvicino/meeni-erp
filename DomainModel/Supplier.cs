using Interfaces;

namespace DomainModel
{
    public class Supplier : Person, IIdentifiable
    {
        public int Id { get; set; }
        public bool ActivityStatus { get; set; }
    }
}

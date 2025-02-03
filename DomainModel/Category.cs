using Interfaces;

namespace DomainModel
{
    public class Category : IIdentifiable, IDispensable
    {
        public int Id { get; set; }
        public bool ActivityStatus { get; set; }
        public string Name { get; set; }
    }
}

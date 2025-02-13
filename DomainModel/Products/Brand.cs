using Interfaces;

namespace DomainModel.Products
{
    public class Brand : IIdentifiable, IDispensable
    {
        public int Id { get; set; }
        public bool ActivityStatus { get; set; }
        public string Name { get; set; }
    }
}

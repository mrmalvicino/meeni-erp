using DomainModel.Products;
using Interfaces;

namespace DomainModel.Inventory
{
    public class Compartment : IIdentifiable, IDispensable
    {
        public int Id { get; set; }
        public bool ActivityStatus { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public Product Product { get; set; }

        public Compartment()
        {

        }

        public Compartment(bool instantiateProperties = false)
        {
            if (instantiateProperties)
            {
                Product = new Product(true);
            }
        }
    }
}

using Interfaces;
using System.Collections.Generic;

namespace DomainModel
{
    public class Product : IIdentifiable, IDispensable
    {
        public int Id { get; set; }
        public bool ActivityStatus { get; set; }
        public bool IsService { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SKU { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public Brand Brand { get; set; }
        public List<Category> Categories { get; set; }

        public Product()
        {
            
        }

        public Product(bool instantiateProperties = false)
        {
            if (instantiateProperties)
            {
                Brand = new Brand();
            }
        }
    }
}

using System.ComponentModel;

namespace Entities
{
    public class Compartment
    {
        // PROPERTIES

        [DisplayName("ID de compartimiento")]
        public int CompartmentId { get; set; }

        [DisplayName("Estado")]
        public bool ActiveStatus { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Stock")]
        public int Stock { get; set; }

        [DisplayName("Producto")]
        public Product Product { get; set; }

        // CONSTRUCT

        public Compartment()
        {
            Product = new Product();
        }

        // METHODS

        public override string ToString()
        {
            return Name;
        }
    }
}

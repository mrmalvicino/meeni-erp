using System.ComponentModel;

namespace Entities
{
    public class Stock
    {
        // PROPERTIES

        [DisplayName("Stock")]
        public int Amount { get; set; }

        [DisplayName("Depósito")]
        public Warehouse Warehouse { get; set; }

        [DisplayName("Producto")]
        public Product Product { get; set; }

        // CONSTRUCT

        public Stock()
        {
            Warehouse = new Warehouse();
            Product = new Product();
        }
    }
}

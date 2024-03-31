using System.ComponentModel;

namespace Entities
{
    public class QuoteRow
    {
        // PROPERTIES

        [DisplayName("Descripción")]
        public string Description { get; set; }

        [DisplayName("Cantidad")]
        public int Amount { get; set; }

        [DisplayName("Precio")]
        public decimal Price { get; set; }

        [DisplayName("Producto")]
        public Product Product { get; set; }

        [DisplayName("Servicio")]
        public Service Service { get; set; }

        // CONSTRUCT

        public QuoteRow()
        {
            Product = new Product();
            Service = new Service();
        }
    }
}

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
    }
}

using System.ComponentModel;

namespace Entities
{
    public class Item
    {
        // PROPERTIES

        [DisplayName("Rubro")]
        public string Category { get; set; }

        [DisplayName("Precio")]
        public decimal Price { get; set; }
    }
}

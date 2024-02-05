using System.ComponentModel;

namespace Entities
{
    public class Product : Item
    {
        // PROPERTIES

        [DisplayName("ID de producto")]
        public int ProductId { get; set; }

        [DisplayName("Marca")]
        public string Brand { get; set; }

        [DisplayName("Modelo")]
        public string Model { get; set; }
    }
}

using System.ComponentModel;

namespace Entities
{
    public class Service : Item
    {
        // PROPERTIES

        [DisplayName("ID de servicio")]
        public int ServiceId { get; set; }

        [DisplayName("Detalles")]
        public string Details { get; set; }

        // METHODS

        public override string ToString()
        {
            return Category.ToString() + " " + Details;
        }
    }
}

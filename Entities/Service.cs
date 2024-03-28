using System.ComponentModel;

namespace Entities
{
    public class Service : Item
    {
        // PROPERTIES

        [DisplayName("ID de servicio")]
        public int ServiceId { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        // METHODS

        public override string ToString()
        {
            return Name;
        }
    }
}

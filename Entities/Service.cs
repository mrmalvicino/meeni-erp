using System.ComponentModel;

namespace Entities
{
    public class Service : Item
    {
        // PROPERTIES

        [DisplayName("ID de servicio")]
        public int ServiceId { get; set; }

        [DisplayName("Descripción")]
        public string Description { get; set; }

        // METHODS

        public override string ToString()
        {
            return Category + " " + Description;
        }
    }
}

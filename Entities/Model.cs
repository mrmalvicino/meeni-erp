using System.ComponentModel;

namespace Entities
{
    public class Model
    {
        // PROPERTIES

        [DisplayName("ID de modelo")]
        public int ModelId { get; set; }

        [DisplayName("Modelo")]
        public string Name { get; set; }

        // METHODS

        public override string ToString()
        {
            return Name;
        }
    }
}

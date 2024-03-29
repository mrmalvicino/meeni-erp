using System.ComponentModel;

namespace Entities
{
    public class Brand
    {
        // PROPERTIES

        [DisplayName("ID de marca")]
        public int BrandId { get; set; }

        [DisplayName("Marca")]
        public string Name { get; set; }

        // METHODS

        public override string ToString()
        {
            return Name;
        }
    }
}

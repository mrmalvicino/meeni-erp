using System.ComponentModel;
using System.Xml.Linq;

namespace Entities
{
    public class Product : Item
    {
        // PROPERTIES

        [DisplayName("ID de producto")]
        public int ProductId { get; set; }

        [DisplayName("Marca")]
        public Brand Brand { get; set; }

        [DisplayName("Modelo")]
        public Model Model { get; set; }

        // METHODS

        public override string ToString()
        {
            return Category.ToString() + " " + Brand.ToString() + " " + Model.ToString();
        }
    }
}

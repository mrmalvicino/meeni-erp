using System.ComponentModel;

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

        [DisplayName("Imagen")]
        public Image Image { get; set; }

        // CONSTRUCT

        public Product()
        {
            Brand = new Brand();
            Model = new Model();
            Image = new Image();
        }

        // METHODS

        public override string ToString()
        {
            return Category.ToString() + " " + Brand.ToString() + " " + Model.ToString();
        }
    }
}

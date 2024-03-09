using System.ComponentModel;

namespace Entities
{
    public class Organization
    {
        // PROPERTIES

        [DisplayName("ID de organización")]
        public int OrganizationId { get; set; }

        [DisplayName("Organización")]
        public string Name { get; set; }

        [DisplayName("Descripción")]
        public string Description { get; set; }

        [DisplayName("Imagen")]
        public Image Image { get; set; }

        // CONSTRUCT

        public Organization()
        {
            Image = new Image();
        }

        // METHODS

        public override string ToString()
        {
            if (Name != "")
                return Name;
            else
                return "";
        }
    }
}

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

        // METHODS

        public override string ToString()
        {
            if (Name != "" && Name != null)
                return Name;
            else
                return "";
        }
    }
}

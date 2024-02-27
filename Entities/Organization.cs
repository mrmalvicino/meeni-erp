using System.ComponentModel;

namespace Entities
{
    public class Organization
    {
        // PROPERTIES

        [DisplayName("ID de organización")]
        public int OrganizationId { get; set; }

        [DisplayName("Organización")]
        public string OrganizationName { get; set; }

        [DisplayName("Descripción")]
        public string OrganizationDescription { get; set; }

        // METHODS

        public override string ToString()
        {
            return OrganizationName;
        }
    }
}

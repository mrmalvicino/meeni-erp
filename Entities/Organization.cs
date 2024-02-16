using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

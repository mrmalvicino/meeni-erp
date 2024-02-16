using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class City
    {
        // PROPERTIES

        [DisplayName("ID de ciudad")]
        public int CityId { get; set; }

        [DisplayName("Ciudad")]
        public string Name { get; set; }

        [DisplayName("Código Postal")]
        public string ZipCode { get; set; }

        // METHODS

        public override string ToString()
        {
            return Name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

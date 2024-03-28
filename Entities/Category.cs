using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Category
    {
        // PROPERTIES

        [DisplayName("ID de categoría")]
        public int CategoryId { get; set; }

        [DisplayName("Categoría")]
        public string Name { get; set; }

        // METHODS

        public override string ToString()
        {
            return Name;
        }
    }
}

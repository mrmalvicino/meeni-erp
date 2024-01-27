using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Item
    {
        public int Id { get; set; }

        [DisplayName("Categoría")]
        public string Category { get; set; }

        [DisplayName("Precio")]
        public decimal Price { get; set; }
    }
}

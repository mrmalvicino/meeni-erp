using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product : Item
    {
        [DisplayName("Marca")]
        public string Brand { get; set; }

        [DisplayName("Modelo")]
        public string Model { get; set; }
    }
}

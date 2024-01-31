using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Service : Item
    {
        [DisplayName("ID de servicio")]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }
    }
}

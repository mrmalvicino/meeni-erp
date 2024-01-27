using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public sealed class Currency
    {
        // PROPERTIES

        public int Id { get; set; }

        [DisplayName("Código")]
        public string Code { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Tasa")]
        public decimal Rate { get; set; }

        // METHODS

        public override string ToString()
        {
            return Code;
        }
    }
}

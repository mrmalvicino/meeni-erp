using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public sealed class Phone
    {
        // PROPERTIES

        [DisplayName("Cód. del país")]
        public int Country { get; set; }

        [DisplayName("Cód. de área")]
        public int Area { get; set; }

        [DisplayName("Número telefónico")]
        public int Number {  get; set; }

        // METHODS

        public override string ToString()
        {
            if (Country != 0 && Area != 0 && Number != 0)
                return $"+{Country} ({Area}) {Number}";
            else if (Number != 0)
                return Number.ToString();
            else
                return "";
        }
    }
}

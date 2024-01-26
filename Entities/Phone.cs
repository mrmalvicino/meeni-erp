using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public sealed class Phone
    {
        // PROPERTIES

        public int Country { get; set; }
        public int Area { get; set; }
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

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

        // CONSTRUCT

        public Phone()
        {
            Country = 54;
            Area = 911;
            Number = 0;
        }

        // METHODS

        public override string ToString()
        {
            return $"+{Country} ({Area}) {Number}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public sealed class Adress
    {
        // PROPERTIES

        public string Country { get; set; }

        public string Province { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public string Street { get; set; }

        public int StreetNumber { get; set; }

        public string Flat {  get; set; }

        // METHODS

        public override string ToString()
        {
            if (Street != "" && StreetNumber != 0 && City != "")
                return $"{Street} {StreetNumber}, {City}";
            else
                return "";
        }
    }
}

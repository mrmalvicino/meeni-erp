using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public sealed class Adress
    {
        // PROPERTIES

        [DisplayName("País")]
        public string Country { get; set; }

        [DisplayName("Provincia")]
        public string Province { get; set; }

        [DisplayName("Ciudad")]
        public string City { get; set; }

        [DisplayName("Código Postal")]
        public string ZipCode { get; set; }

        [DisplayName("Calle")]
        public string Street { get; set; }

        [DisplayName("Número")]
        public int StreetNumber { get; set; }

        [DisplayName("Depto. o lote")]
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

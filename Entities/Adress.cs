using System.ComponentModel;

namespace Entities
{
    public sealed class Adress
    {
        // PROPERTIES

        [DisplayName("ID de dirección")]
        public int AdressId { get; set; }

        [DisplayName("País")]
        public string Country { get; set; }

        [DisplayName("Provincia")]
        public string Province { get; set; }

        [DisplayName("Ciudad")]
        public string City { get; set; }

        [DisplayName("Código Postal")]
        public string ZipCode { get; set; }

        [DisplayName("Calle")]
        public string StreetName { get; set; }

        [DisplayName("Número")]
        public int StreetNumber { get; set; }

        [DisplayName("Depto. o lote")]
        public string Flat {  get; set; }

        // METHODS

        public override string ToString()
        {
            if (StreetName != "" && StreetNumber != 0 && City != "")
                return $"{StreetName} {StreetNumber}, {City}";
            else
                return "";
        }
    }
}

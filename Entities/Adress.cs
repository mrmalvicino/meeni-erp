using System.ComponentModel;

namespace Entities
{
    public sealed class Adress
    {
        // PROPERTIES

        [DisplayName("ID de dirección")]
        public int AdressId { get; set; }

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

        [DisplayName("País")]
        public Country Country { get; set; }

        [DisplayName("Provincia")]
        public Province Province { get; set; }

        // METHODS

        public override string ToString()
        {
            if (StreetName != "" && StreetNumber != 0 && City != "")
                return $"{StreetName} {StreetNumber}, {City}";
            else
                return "";
        }

        // CONSTRUCT

        public Adress()
        {
            Country = new Country();
            Province = new Province();
        }
    }
}

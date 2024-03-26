using System.ComponentModel;

namespace Entities
{
    public sealed class Adress
    {
        // PROPERTIES

        [DisplayName("ID de dirección")]
        public int AdressId { get; set; }

        [DisplayName("Calle")]
        public string StreetName { get; set; }

        [DisplayName("Número")]
        public string StreetNumber { get; set; }

        [DisplayName("Depto. o lote")]
        public string Flat { get; set; }

        [DisplayName("Detalles")]
        public string Details { get; set; }

        [DisplayName("Ciudad")]
        public City City { get; set; }

        [DisplayName("Provincia")]
        public Province Province { get; set; }

        [DisplayName("País")]
        public Country Country { get; set; }

        // METHODS

        public override string ToString()
        {
            if (Country != null && Province != null && City != null && StreetName != null && StreetNumber != null)
                return $"{StreetName} {StreetNumber}, {City.ToString()}";

            return "";
        }

        // CONSTRUCT

        public Adress()
        {
            Country = new Country();
            Province = new Province();
            City = new City();
        }
    }
}

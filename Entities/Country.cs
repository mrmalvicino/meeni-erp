using System.ComponentModel;

namespace Entities
{
    public class Country
    {
        // PROPERTIES

        [DisplayName("ID de país")]
        public int CountryId { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Código de área telefónico")]
        public int PhoneAreaCode { get; set; }

        [DisplayName("Divisa")]
        public Currency Currency { get; set; }

        // CONSTRUCT

        public Country()
        {
            Currency = new Currency();
        }

        // METHODS

        public override string ToString()
        {
            return Name;
        }
    }
}

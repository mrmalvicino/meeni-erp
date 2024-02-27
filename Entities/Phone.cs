using System.ComponentModel;

namespace Entities
{
    public sealed class Phone
    {
        // PROPERTIES

        [DisplayName("ID de teléfono")]
        public int PhoneId { get; set; }

        [DisplayName("Número telefónico")]
        public int Number {  get; set; }

        [DisplayName("Provincia")]
        public Province Province { get; set; }

        [DisplayName("País")]
        public Country Country { get; set; }

        // METHODS

        public override string ToString()
        {
            if (Country.PhoneAreaCode != 0 && Province.PhoneAreaCode != 0 && Number != 0)
                return $"+{Country.PhoneAreaCode} ({Province.PhoneAreaCode}) {Number}";
            else if (Number != 0)
                return Number.ToString();
            else
                return "";
        }

        // CONSTRUCT

        public Phone()
        {
            Country = new Country();
            Province = new Province();
        }
    }
}

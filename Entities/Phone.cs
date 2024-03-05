using System.ComponentModel;

namespace Entities
{
    public sealed class Phone
    {
        // PROPERTIES

        [DisplayName("ID de teléfono")]
        public int PhoneId { get; set; }

        [DisplayName("Número telefónico")]
        public string Number {  get; set; }

        [DisplayName("Provincia")]
        public Province Province { get; set; }

        [DisplayName("País")]
        public Country Country { get; set; }

        // METHODS

        public override string ToString()
        {
            if (Country != null && Province != null && Country.PhoneAreaCode != null && Province.PhoneAreaCode != null && Number != null)
                return $"+{Country.PhoneAreaCode} ({Province.PhoneAreaCode}) {Number}";

            if (Number != null)
                return Number.ToString();
            
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

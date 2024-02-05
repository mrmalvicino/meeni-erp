using System.ComponentModel;

namespace Entities
{
    public sealed class Phone
    {
        // PROPERTIES

        [DisplayName("ID de teléfono")]
        public int PhoneId { get; set; }

        [DisplayName("Cód. del país")]
        public int CountryAreaCode { get; set; }

        [DisplayName("Cód. de área")]
        public int ProvinceAreaCode { get; set; }

        [DisplayName("Número telefónico")]
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

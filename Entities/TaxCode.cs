using System.ComponentModel;

namespace Entities
{
    public sealed class TaxCode
    {
        // PROPERTIES

        [DisplayName("ID de código fiscal")]
        public int TaxCodeId { get; set; }

        [DisplayName("XX")]
        public string Prefix { get; set; }

        [DisplayName("DNI")]
        public int Number { get; set; }

        [DisplayName("Y")]
        public string Suffix { get; set; }

        // METHODS

        public override string ToString()
        {
            if (Prefix != "" && Number != 0 && Suffix != "")
                return $"{Prefix}-{Number}-{Suffix}";
            else if (Number != 0)
                return Number.ToString();
            else
                return "";
        }
    }
}

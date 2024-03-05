using System.ComponentModel;

namespace Entities
{
    public sealed class TaxCode
    {
        // PROPERTIES

        [DisplayName("ID de CUIL")]
        public int TaxCodeId { get; set; }

        [DisplayName("XX")]
        public string Prefix { get; set; }

        [DisplayName("DNI")]
        public string Number { get; set; }

        [DisplayName("Y")]
        public string Suffix { get; set; }

        // METHODS

        public override string ToString()
        {
            if (Prefix != null && Number != null && Suffix != null)
                return $"{Prefix}-{Number}-{Suffix}";
            else if (Number != null)
                return Number.ToString();
            else
                return "";
        }
    }
}

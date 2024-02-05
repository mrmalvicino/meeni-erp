using System.ComponentModel;

namespace Entities
{
    public sealed class TaxCode
    {
        // PROPERTIES

        [DisplayName("ID de código fiscal")]
        public int TaxCodeId { get; set; }

        [DisplayName("Prefijo")]
        public string XX { get; set; }

        [DisplayName("Número de documento")]
        public int DNI { get; set; }

        [DisplayName("Sufijo")]
        public string Y { get; set; }

        // METHODS

        public override string ToString()
        {
            if (XX != "" && DNI != 0 && Y != "")
                return $"{XX}-{DNI}-{Y}";
            else if (DNI != 0)
                return DNI.ToString();
            else
                return "";
        }
    }
}

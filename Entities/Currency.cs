using System.ComponentModel;

namespace Entities
{
    public sealed class Currency
    {
        // PROPERTIES

        [DisplayName("ID de divisa")]
        public int CurrencyId { get; set; }

        [DisplayName("Código")]
        public string Code { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Tasa oficial")]
        public decimal Rate { get; set; }

        [DisplayName("Tasa en negro")]
        public decimal BlackRate { get; set; }

        // METHODS

        public override string ToString()
        {
            return Code;
        }
    }
}

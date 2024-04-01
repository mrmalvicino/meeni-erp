using System.ComponentModel;

namespace Entities
{
    public class QuoteRow
    {
        // PROPERTIES

        [DisplayName("Índice")]
        public int RowIndex { get; set; }

        [DisplayName("Descripción")]
        public string RowDescription { get; set; }

        [DisplayName("Cantidad")]
        public int Amount { get; set; }

        [DisplayName("Precio")]
        public decimal Price { get; set; }

        // METHODS

        public override string ToString()
        {
            return Amount + " x " + RowDescription + "x $" + Price;
        }
    }
}

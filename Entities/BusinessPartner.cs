using System.ComponentModel;

namespace Entities
{
    public abstract class BusinessPartner : Individual
    {
        // PROPERTIES

        [DisplayName("Pago")]
        public string PaymentMethod { get; set; }

        [DisplayName("Factura")]
        public string InvoiceCategory { get; set; }
    }
}

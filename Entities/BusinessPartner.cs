using System.ComponentModel;

namespace Entities
{
    public abstract class BusinessPartner : Individual
    {
        // PROPERTIES

        [DisplayName("ID de socio de negocio")]
        public int BusinessPartnerId { get; set; }

        [DisplayName("Pago")]
        public string PaymentMethod { get; set; }

        [DisplayName("Factura")]
        public string InvoiceCategory { get; set; }
    }
}

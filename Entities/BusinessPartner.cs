using System.ComponentModel;

namespace Entities
{
    public class BusinessPartner : Individual
    {
        // PROPERTIES

        [DisplayName("ID de socio de negocio")]
        public int BusinessPartnerId { get; set; }

        [DisplayName("Pago")]
        public string PaymentMethod { get; set; }

        [DisplayName("Factura")]
        public string InvoiceCategory { get; set; }

        // METHODS

        public BusinessPartner copyToBusinessPartner()
        {
            BusinessPartner businessPartner;
            businessPartner = copyFromIndividual<BusinessPartner>(this.copyToIndividual());

            businessPartner.BusinessPartnerId = this.BusinessPartnerId;
            businessPartner.PaymentMethod = this.PaymentMethod;
            businessPartner.InvoiceCategory = this.InvoiceCategory;

            return businessPartner;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

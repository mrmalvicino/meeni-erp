using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class BusinessPartner : Individual
    {
        // PROPERTIES

        public string PaymentMethod { get; set; }
        public string InvoiceCategory { get; set; }

        // CONSTRUCT

        public BusinessPartner()
        {
            PaymentMethod = "0";
            InvoiceCategory = "0";
        }
    }
}

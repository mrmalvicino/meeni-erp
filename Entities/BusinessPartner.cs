using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class BusinessPartner : Individual
    {
        public BusinessPartner()
        {
            PaymentMethod = "0";
            InvoiceCategory = "0";
        }

        public string PaymentMethod { get; set; }
        public string InvoiceCategory { get; set; }
    }
}

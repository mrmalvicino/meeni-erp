using System;
using System.ComponentModel;

namespace Entities
{
    public class Quote
    {
        // PROPERTIES

        [DisplayName("ID de cotización")]
        public int QuoteId { get; set; }

        [DisplayName("Estado")]
        public string ActiveStatus { get; set; }

        [DisplayName("Versión")]
        public int VariantVersion { get; set; }

        [DisplayName("Fecha")]
        public DateTime JobDate { get; set; }

        [DisplayName("Cliente")]
        public Customer Customer { get; set; }

        // CONSTRUCT

        public Quote()
        {
            Customer = new Customer();
        }
    }
}

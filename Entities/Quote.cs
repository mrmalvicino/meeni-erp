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
        public string Status { get; set; }

        [DisplayName("Versión")]
        public int Version { get; set; }

        [DisplayName("Fecha")]
        public DateTime Date { get; set; }

        [DisplayName("Cliente")]
        public Customer Customer { get; set; }

        // CONSTRUCT

        public Quote()
        {
            Customer = new Customer();
        }
    }
}

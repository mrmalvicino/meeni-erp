using System.ComponentModel;

namespace Entities
{
    public class Customer : BusinessPartner
    {
        // PROPERTIES

        [DisplayName("ID de cliente")]
        public int CustomerId { get; set; }

        [DisplayName("Ventas")]
        public int SalesAmount { get; set; }
    }
}

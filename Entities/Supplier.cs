using System.ComponentModel;

namespace Entities
{
    public class Supplier : BusinessPartner
    {
        // PROPERTIES

        [DisplayName("ID de proveedor")]
        public int SupplierId { get; set; }
    }
}

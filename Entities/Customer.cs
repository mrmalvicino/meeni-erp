using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer : BusinessPartner
    {
        // PROPERTIES

        [DisplayName("ID de cliente")]
        public int Id { get; set; }

        [DisplayName("Ventas")]
        public int SalesAmount { get; set; }
    }
}

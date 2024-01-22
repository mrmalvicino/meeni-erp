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

        [DisplayName("Ventas")]
        public int SalesAmount { get; set; }

        // CONSTRUCT

        public Customer()
        {
            SalesAmount = 0;
        }

        // METHODS

        public override string ToString()
        {
            if (this.IsPerson)
                return $"{this.LastName}, {this.FirstName}";
            else
                return this.BusinessName;
        }
    }
}

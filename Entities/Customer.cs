using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer : BusinessPartner
    {
        // PROPERTIES

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

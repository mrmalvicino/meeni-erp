using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer : BusinessPartner
    {
        public Customer()
        {
            SalesAmount = 0;
        }

        public int SalesAmount { get; set; }
    }
}

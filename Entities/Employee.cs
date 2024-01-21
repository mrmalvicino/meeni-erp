using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee : Individual
    {
        // PROPERTIES

        public int RoleId { get; set; }

        // CONSTRUCT

        Employee()
        {
            IsPerson = true;
        }
    }
}

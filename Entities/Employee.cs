using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee : Individual
    {
        Employee()
        {
            IsPerson = true;
        }

        public int RoleId { get; set; }
    }
}

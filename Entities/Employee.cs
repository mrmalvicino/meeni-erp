using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee : Individual
    {
        // PROPERTIES

        [DisplayName("Rol")]
        public int RoleId { get; set; }

        // CONSTRUCT

        public Employee()
        {
            IsPerson = true;
        }
    }
}

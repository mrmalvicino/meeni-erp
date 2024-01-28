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

        public int EmployeeId { get; set; }

        [DisplayName("Categoría")]
        public Category Category { get; set; }

        // CONSTRUCT

        public Employee()
        {
            IsPerson = true;
            Category = new Category();
        }
    }
}

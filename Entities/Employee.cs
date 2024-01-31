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

        [DisplayName("ID de empleado")]
        public int EmployeeId { get; set; }

        [DisplayName("Es usuario")]
        public bool IsUser { get; set; }

        [DisplayName("Fecha de ingreso")]
        public DateTime Admission { get; set; }

        [DisplayName("Categoría")]
        public Category Category { get; set; }

        // CONSTRUCT

        public Employee()
        {
            IsPerson = true;
            IsUser = false;
            Category = new Category();
        }
    }
}

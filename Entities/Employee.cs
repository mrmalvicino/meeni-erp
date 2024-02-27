using System;
using System.ComponentModel;

namespace Entities
{
    public class Employee : Individual
    {
        // PROPERTIES

        [DisplayName("ID de empleado")]
        public int EmployeeId { get; set; }

        [DisplayName("Ingreso")]
        public DateTime Admission { get; set; }

        [DisplayName("Puesto")]
        public Position Position { get; set; }

        // CONSTRUCT

        public Employee()
        {
            Position = new Position();
        }
    }
}

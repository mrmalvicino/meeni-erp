using System.ComponentModel;

namespace Entities
{
    public class Department
    {
        // PROPERTIES

        [DisplayName("ID de área")]
        public int DepartmentId { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }
    }
}

using System.ComponentModel;

namespace Entities
{
    public class Seniority
    {
        // PROPERTIES

        [DisplayName("ID de nivel de experiencia")]
        public int SeniorityId { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }
    }
}

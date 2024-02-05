using System.ComponentModel;

namespace Entities
{
    public class Position
    {
        // PROPERTIES

        [DisplayName("ID de puesto")]
        public int PositionId { get; set; }

        [DisplayName("Título")]
        public string Title { get; set; }

        [DisplayName("Experiencia")]
        public Seniority Seniority { get; set; }

        [DisplayName("Área")]
        public Department Department { get; set; }

        // CONSTRUCT

        public Position()
        {
            Seniority = new Seniority();
            Department = new Department();
        }

        // METHODS

        public override string ToString()
        {
            return Title + " " + Seniority;
        }
    }
}

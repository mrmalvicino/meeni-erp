using System.ComponentModel;

namespace Entities
{
    public class Person
    {
        // PROPERTIES

        [DisplayName("ID de persona")]
        public int PersonId { get; set; }

        [DisplayName("Nombre")]
        public string FirstName { get; set; }

        [DisplayName("Apellido")]
        public string LastName { get; set; }

        // METHODS

        public override string ToString()
        {
            return $"{LastName}, {FirstName}";
        }
    }
}

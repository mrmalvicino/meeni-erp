using System.ComponentModel;

namespace Entities
{
    public class User : Employee
    {
        // PROPERTIES

        [DisplayName("ID de usuario")]
        public int UserId { get; set; }

        [DisplayName("Nombre de usuario")]
        public string UserName { get; set; }

        [DisplayName("Contraseña")]
        public string UserPassword { get; set; }

        [DisplayName("Rol")]
        public Role Role { get; set; }

        // CONSTRUCT

        public User()
        {
            Role = new Role();
        }

        // METHODS

        public override string ToString()
        {
            return UserName;
        }
    }
}

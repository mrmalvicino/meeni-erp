using System.ComponentModel;

namespace Entities
{
    public class Role
    {
        // PROPERTIES

        [DisplayName("ID de rol")]
        public int RoleId { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        // METHODS

        public override string ToString()
        {
            return Name;
        }
    }
}

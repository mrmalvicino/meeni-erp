using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Role
    {
        // PROPERTIES

        public int Id { get; set; }

        [DisplayName("Rol")]
        public string RoleName { get; set; }

        [DisplayName("Nivel")]
        public int PermissionLevel { get; set; }

        // METHODS

        public override string ToString()
        {
            return RoleName + " nivel " + PermissionLevel;
        }
    }
}

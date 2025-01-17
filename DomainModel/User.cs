using System.Collections.Generic;

namespace DomainModel
{
    public class User : Employee
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Role> Roles { get; set; }
    }
}

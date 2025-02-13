using DomainModel.Stakeholders;
using System.Collections.Generic;

namespace DomainModel.Users
{
    public class User : Employee
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Role> Roles { get; set; }
    }
}

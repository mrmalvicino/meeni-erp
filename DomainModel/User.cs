using System.Collections.Generic;

namespace DomainModel
{
    public class User
    {
        public int Id { get; set; }
        public bool ActivityStatus { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Role> Roles { get; set; }

        public User()
        {
            Roles = new List<Role>();
        }
    }
}

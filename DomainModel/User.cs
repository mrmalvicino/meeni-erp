using Interfaces;
using System.Collections.Generic;

namespace DomainModel
{
    public class User : IIdentifiable
    {
        public int Id { get; set; }
        public bool ActivityStatus { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Role> Roles { get; set; }
    }
}

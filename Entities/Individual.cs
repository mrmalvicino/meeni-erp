using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class Individual
    {
        public int Id { get; set; }
        public bool ActiveStatus { get; set; }
        public bool IsPerson { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BusinessName { get; set; }
        public string BusinessDescription { get; set; }
        public long LegalId { get; set; }
        public string Email { get; set; }
        public Phone Phone { get; set; }
        public Adress Adress { get; set; }
        public string ImageUrl { get; set; }
    }
}

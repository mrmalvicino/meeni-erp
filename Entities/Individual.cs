using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class Individual
    {
        public bool Status { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int LegalId { get; set; }
        public int Phone {  get; set; }
        public string Email { get; set; }
        public Adress Adress { get; set; }
    }
}

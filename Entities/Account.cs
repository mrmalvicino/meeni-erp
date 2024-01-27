using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Account
    {
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Saldo")]
        public decimal Balance { get; set; }

        [DisplayName("Tipo")]
        public bool IsDebit { get; set; }
    }
}

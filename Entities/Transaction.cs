using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Transaction
    {
        // PROPERTIES

        public int Id { get; set; }

        [DisplayName("Descripción")]
        public string Description { get; set; }

        [DisplayName("Monto")]
        public decimal Amount { get; set; }

        [DisplayName("Moneda")]
        public int CurrencyId { get; set; }

        [DisplayName("Fecha")]
        public DateTime DateTime { get; set; }

        [DisplayName("Empleado")]
        public Employee Employee { get; set; }

        [DisplayName("Cuentas")]
        public List<Account> Accounts { get; set; }

        // CONSTRUCT

        public Transaction()
        {
            DateTime = DateTime.Now;
            Employee = new Employee();
            Accounts = new List<Account>();
        }

        // METHODS

        public void addAccount(Account account)
        {
            Accounts.Add(account);
        }
    }
}

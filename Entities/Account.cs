using System.ComponentModel;

namespace Entities
{
    public class Account
    {
        // PROPERTIES

        [DisplayName("ID de cuenta")]
        public int AccountId { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Saldo")]
        public decimal Balance { get; set; }

        [DisplayName("Tipo")]
        public bool IsDebit { get; set; }
    }
}

using System.ComponentModel;
using System.Collections.Generic;

namespace Entities
{
    public class Warehouse
    {
        // PROPERTIES

        [DisplayName("ID de depósito")]
        public int WarehouseId { get; set; }

        [DisplayName("Estado")]
        public bool ActiveStatus { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Dirección")]
        public Adress Adress { get; set; }

        [DisplayName("Compartimiento")]
        public List<Compartment> Compartments { get; set; }

        // CONSTRUCT

        public Warehouse()
        {
            Adress = new Adress();
            Compartments = new List<Compartment>();
        }

        // METHODS

        public override string ToString()
        {
            return Name;
        }
    }
}

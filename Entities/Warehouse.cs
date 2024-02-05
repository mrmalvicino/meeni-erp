using System.ComponentModel;

namespace Entities
{
    public class Warehouse
    {
        // PROPERTIES

        [DisplayName("ID de depósito")]
        public int WarehouseId { get; set; }

        [DisplayName("Está activo")]
        public bool ActiveStatus { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Dirección")]
        public Adress Adress { get; set; }

        // CONSTRUCT

        public Warehouse()
        {
            Adress = new Adress();
        }

        // METHODS

        public override string ToString()
        {
            return Name;
        }
    }
}

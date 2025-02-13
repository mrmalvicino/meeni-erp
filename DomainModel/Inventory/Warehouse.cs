using DomainModel.Locations;
using Interfaces;
using System.Collections.Generic;

namespace DomainModel.Inventory
{
    public class Warehouse : IIdentifiable, IDispensable
    {
        public int Id { get; set; }
        public bool ActivityStatus { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public List<Compartment> Compartments { get; set; }

        public Warehouse()
        {

        }

        public Warehouse(bool instantiateProperties = false)
        {
            if (instantiateProperties)
            {
                Address = new Address(true);
            }
        }
    }
}

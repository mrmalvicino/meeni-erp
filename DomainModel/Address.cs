using Interfaces;
using System;

namespace DomainModel
{
    [Serializable]
    public class Address : IIdentifiable
    {
        public int Id { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string Flat { get; set; }
        public string Details { get; set; }
        public City City { get; set; }
        public Province Province { get; set; }
        public Country Country { get; set; }

        public Address()
        {

        }

        public Address(bool instantiateProperties = false)
        {
            if (instantiateProperties)
            {
                City = new City();
                Province = new Province();
                Country = new Country();
            }
        }
    }
}

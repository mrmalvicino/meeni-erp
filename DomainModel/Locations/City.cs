using Interfaces;
using System;

namespace DomainModel.Locations
{
    [Serializable]
    public class City : IIdentifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ZipCode { get; set; }
    }
}

using Interfaces;
using System;

namespace DomainModel.Locations
{
    [Serializable]
    public class Country : IIdentifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

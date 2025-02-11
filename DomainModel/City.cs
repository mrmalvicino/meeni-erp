using Interfaces;
using System;

namespace DomainModel
{
    [Serializable]
    public class City : IIdentifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ZipCode { get; set; }
    }
}

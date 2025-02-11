using Interfaces;
using System;

namespace DomainModel
{
    [Serializable]
    public class Province : IIdentifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

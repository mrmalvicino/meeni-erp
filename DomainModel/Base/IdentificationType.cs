using Interfaces;
using System;

namespace DomainModel.Base
{
    [Serializable]
    public class IdentificationType : IIdentifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

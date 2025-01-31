using Interfaces;

namespace DomainModel
{
    public class IdentificationType : IIdentifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

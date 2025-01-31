using Interfaces;

namespace DomainModel
{
    public class Identification : IIdentifiable
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public IdentificationType IdentificationType { get; set; }
    }
}

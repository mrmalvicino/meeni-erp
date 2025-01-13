using Interfaces;

namespace DomainModel
{
    public class Role : IIdentifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

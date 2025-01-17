using Interfaces;

namespace DomainModel
{
    public class Position : IIdentifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

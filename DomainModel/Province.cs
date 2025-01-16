using Interfaces;

namespace DomainModel
{
    public class Province : IIdentifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

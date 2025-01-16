using Interfaces;

namespace DomainModel
{
    public class Seniority : IIdentifiable
    {
        public int Id { get; set; }
        public bool ActivityStatus { get; set; }
        public string Name { get; set; }
    }
}

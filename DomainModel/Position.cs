using Interfaces;

namespace DomainModel
{
    public class Position : IIdentifiable
    {
        public int Id { get; set; }
        public bool ActivityStatus { get; set; }
        public string Name { get; set; }
        public Seniority Seniority { get; set; }
        public Department Department { get; set; }
    }
}

using Interfaces;

namespace DomainModel.Users
{
    public class Role : IIdentifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

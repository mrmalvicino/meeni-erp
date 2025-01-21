using Interfaces;

namespace DomainModel
{
    public class Image : IIdentifiable
    {
        public int Id { get; set; }
        public string URL { get; set; }
    }
}

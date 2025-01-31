using Interfaces;

namespace DomainModel
{
    public class Identification : IIdentifiable
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public IdentificationType IdentificationType { get; set; }

        public Identification()
        {

        }

        public Identification(bool instantiateProperties = false)
        {
            if (instantiateProperties)
            {
                IdentificationType = new IdentificationType();
            }
        }
    }
}

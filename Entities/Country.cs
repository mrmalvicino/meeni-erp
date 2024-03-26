using System.ComponentModel;

namespace Entities
{
    public class Country
    {
        // PROPERTIES

        [DisplayName("ID de país")]
        public int CountryId { get; set; }

        [DisplayName("País")]
        public string Name { get; set; }

        // METHODS

        public override string ToString()
        {
            return Name;
        }
    }
}

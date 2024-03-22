using System.ComponentModel;

namespace Entities
{
    public class Image
    {
        // PROPERTIES

        [DisplayName("ID de imagen")]
        public int ImageId { get; set; }

        [DisplayName("URL de imagen")]
        public string Url { get; set; }

        // METHODS

        public override string ToString()
        {
            return Url;
        }
    }
}

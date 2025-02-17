using System.Text.Json.Serialization;

namespace DomainModel.Mailing
{
    public class Sender
    {
        [JsonPropertyName("email")]
        public string EmailAddress { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}

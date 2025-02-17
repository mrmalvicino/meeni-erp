using System.Text.Json.Serialization;

namespace DomainModel.Mailing
{
    public class Recipient
    {
        [JsonPropertyName("email")]
        public string EmailAddress { get; set; }
    }
}

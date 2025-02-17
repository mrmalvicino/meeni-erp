using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DomainModel.Mailing
{
    public class EmailRequest<T>
    {
        [JsonPropertyName("from")]
        public Sender From { get; set; }

        [JsonPropertyName("to")]
        public List<Recipient> To { get; set; }

        [JsonPropertyName("template_uuid")]
        public string TemplateUUId { get; set; }

        [JsonPropertyName("template_variables")]
        public T TemplateVariables { get; set; }
    }
}

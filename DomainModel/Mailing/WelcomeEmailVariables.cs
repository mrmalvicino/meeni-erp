using System.Text.Json.Serialization;

namespace DomainModel.Mailing
{
    public class WelcomeEmailVariables
    {
        [JsonPropertyName("business_url")]
        public string BusinessURL { get; set; }

        [JsonPropertyName("login_url")]
        public string LoginURL { get; set; }

        [JsonPropertyName("organization_name")]
        public string OrganizationName { get; set; }

        [JsonPropertyName("privacy_policies_url")]
        public string PrivacyPoliciesURL { get; set; }

        [JsonPropertyName("license_url")]
        public string LicenseURL { get; set; }

        [JsonPropertyName("terms_url")]
        public string TermsURL { get; set; }
    }
}

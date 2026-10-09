using System.Text.Json.Serialization;

namespace RakibPortfolio.Models;

public class ContactInfo
{
    [JsonPropertyName("email")]
    public string Email { get; set; } = string.Empty;

    [JsonPropertyName("linkedin")]
    public string Linkedin { get; set; } = string.Empty;

    [JsonPropertyName("github")]
    public string Github { get; set; } = string.Empty;

    [JsonPropertyName("phone")]
    public string Phone { get; set; } = string.Empty;

    [JsonPropertyName("formspreeEndpoint")]
    public string FormspreeEndpoint { get; set; } = string.Empty;
}
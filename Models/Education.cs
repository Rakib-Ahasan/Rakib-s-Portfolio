using System.Text.Json.Serialization;

namespace RakibPortfolio.Models;

public class Education
{
    [JsonPropertyName("degree")]
    public string Degree { get; set; } = string.Empty;

    [JsonPropertyName("institution")]
    public string Institution { get; set; } = string.Empty;

    [JsonPropertyName("cgpa")]
    public string Cgpa { get; set; } = string.Empty;

    [JsonPropertyName("years")]
    public string Years { get; set; } = string.Empty;
}
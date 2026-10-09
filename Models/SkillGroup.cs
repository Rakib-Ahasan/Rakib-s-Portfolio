using System.Text.Json.Serialization;

namespace RakibPortfolio.Models;

public class SkillGroup
{
    [JsonPropertyName("Backend")]
    public List<string> Backend { get; set; } = new();

    [JsonPropertyName("Frontend")]
    public List<string> Frontend { get; set; } = new();

    [JsonPropertyName("Architecture")]
    public List<string> Architecture { get; set; } = new();

    [JsonPropertyName("Databases & Caching")]
    public List<string> DatabasesAndCaching { get; set; } = new();

    [JsonPropertyName("Cloud & DevOps")]
    public List<string> CloudAndDevOps { get; set; } = new();

    [JsonPropertyName("Security & Payments")]
    public List<string> SecurityAndPayments { get; set; } = new();

    [JsonPropertyName("Testing & Practices")]
    public List<string> TestingAndPractices { get; set; } = new();
}
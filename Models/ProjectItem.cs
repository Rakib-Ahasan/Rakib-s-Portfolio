using System.Text.Json.Serialization;

namespace RakibPortfolio.Models;

public class ProjectItem
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;

    [JsonPropertyName("tech")]
    public List<string> Tech { get; set; } = new();

    [JsonPropertyName("problem")]
    public string Problem { get; set; } = string.Empty;

    [JsonPropertyName("solution")]
    public string Solution { get; set; } = string.Empty;

    [JsonPropertyName("outcome")]
    public string Outcome { get; set; } = string.Empty;
}
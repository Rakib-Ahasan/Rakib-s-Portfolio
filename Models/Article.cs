using System.Text.Json.Serialization;

namespace RakibPortfolio.Models;

public class Article
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;

    [JsonPropertyName("publishedAt")]
    public string PublishedAt { get; set; } = string.Empty;

    [JsonPropertyName("summary")]
    public string? Summary { get; set; }
}
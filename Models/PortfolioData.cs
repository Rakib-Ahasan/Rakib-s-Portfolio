using System.Text.Json.Serialization;

namespace RakibPortfolio.Models;

public class PortfolioData
{
    [JsonPropertyName("profile")]
    public Profile Profile { get; set; } = new();

    [JsonPropertyName("summary")]
    public string Summary { get; set; } = string.Empty;

    [JsonPropertyName("keyResults")]
    public List<string> KeyResults { get; set; } = new();

    [JsonPropertyName("experience")]
    public List<ExperienceItem> Experience { get; set; } = new();

    [JsonPropertyName("skills")]
    public SkillGroup Skills { get; set; } = new();

    [JsonPropertyName("projects")]
    public List<ProjectItem> Projects { get; set; } = new();

    [JsonPropertyName("articles")]
    public List<Article> Articles { get; set; } = new();

    [JsonPropertyName("contact")]
    public ContactInfo Contact { get; set; } = new();

    [JsonPropertyName("education")]
    public Education Education { get; set; } = new();

    [JsonPropertyName("certifications")]
    public List<string> Certifications { get; set; } = new();
}
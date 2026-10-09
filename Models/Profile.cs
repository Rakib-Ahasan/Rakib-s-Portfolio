using System.Text.Json.Serialization;

namespace RakibPortfolio.Models;

public class Profile
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("location")]
    public string Location { get; set; } = string.Empty;

    [JsonPropertyName("openTo")]
    public string OpenTo { get; set; } = string.Empty;

    [JsonPropertyName("email")]
    public string Email { get; set; } = string.Empty;

    [JsonPropertyName("phone")]
    public string Phone { get; set; } = string.Empty;

    [JsonPropertyName("linkedin")]
    public string Linkedin { get; set; } = string.Empty;

    [JsonPropertyName("github")]
    public string Github { get; set; } = string.Empty;

    [JsonPropertyName("cvPath")]
    public string CvPath { get; set; } = string.Empty;

    [JsonPropertyName("pitch")]
    public string Pitch { get; set; } = string.Empty;
}
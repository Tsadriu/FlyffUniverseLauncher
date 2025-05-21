using System.Text.Json.Serialization;

namespace FlyffUniverseLauncher.Classes.Json;

/// <summary>
/// Represents the properties of the launcher.json file.
/// </summary>
public class LauncherPropertiesJson
{
    /// <summary>
    /// Gets or sets the language of the launcher.
    /// </summary>
    /// <remarks>The default value is English - United States.</remarks>
    [JsonPropertyName("language")]
    public string Language { get; set; } = "en-us";
}
namespace FlyffUniverseLauncher.Classes;

public class Profile
{
    /// <summary>
    /// Gets or sets the name of the profile.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the last time the user pressed 'Play'.
    /// </summary>
    public DateTime LastLogin { get; set; }
    
    /// <summary>
    /// Gets or sets the width of the window.
    /// </summary>
    public int Width { get; set; }
    
    /// <summary>
    /// Gets or sets the height of the window.
    /// </summary>
    public int Height { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether the profile will launch in full-screen mode.
    /// </summary>
    public bool IsFullScreen { get; set; }
}
namespace FlyffUniverseLauncher.Classes;

public class Profile
{
    public Profile() { }

    public Profile(string name, int width, int height, bool isFullScreen)
    {
        Name = name;
        Width = width;
        Height = height;
        IsFullScreen = isFullScreen;
    }
    
    public string Name { get; set; } = string.Empty;

    public DateTime LastLogin { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public bool IsFullScreen { get; set; }
}
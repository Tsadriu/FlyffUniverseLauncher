namespace FlyffUniverseLauncher;

internal static class Program
{
    public const string CurrentVersion = "Version 2.0";
    public static FlyffUniverseLauncher launcher = new();

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        launcher.StartPosition = FormStartPosition.CenterScreen;
        Application.Run(launcher);
    }
}
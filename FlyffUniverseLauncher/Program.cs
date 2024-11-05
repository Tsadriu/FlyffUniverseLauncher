using FlyffUniverseLauncher.Enums;
using TsadriuUtilities;
using TsadriuUtilitiesOld;

namespace FlyffUniverseLauncher
{
    internal static class Program
    {
        public const string CurrentVersion = "Version 1.8.0";
        public static FlyffUniverseLauncher launcher = new FlyffUniverseLauncher();

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
}
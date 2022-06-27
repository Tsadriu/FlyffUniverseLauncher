using FlyffUniverseLauncher.Enums;
using TsadriuUtilities;

namespace FlyffUniverseLauncher
{
    internal static class Program
    {
        public static FlyffUniverseLauncher launcher;
        private static VersionEnum currentVersion = VersionEnum.V1_1_0;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            launcher = new FlyffUniverseLauncher
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            Application.Run(launcher);
        }

        public static string GetVersionAsString()
        {
            return currentVersion.ToString().Remove("V").Replace("_", ".");
        }
    }
}
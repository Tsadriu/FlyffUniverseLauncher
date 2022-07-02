using FlyffUniverseLauncher.Enums;
using TsadriuUtilities;

namespace FlyffUniverseLauncher
{
    internal static class Program
    {
        private static VersionEnum currentVersion = VersionEnum.V1_4_0;
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

        /// <summary>
        /// Returns the current version as a string. Note that is removes the V and replaces the _ as a . found in <see cref="VersionEnum"/>.
        /// </summary>
        /// <returns><see cref="currentVersion"/> as "Version x.x.x" (<see cref="VersionEnum.V1_0_0"/> returns Version 1.0.0 and so on).</returns>
        public static string GetVersionAsString()
        {
            return $"Version {currentVersion.ToString().Remove("V").Replace("_", ".")}";
        }
    }
}
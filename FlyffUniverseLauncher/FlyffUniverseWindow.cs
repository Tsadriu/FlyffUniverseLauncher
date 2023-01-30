using Microsoft.Web.WebView2.Core;
using TsadriuUtilities;

namespace FlyffUniverseLauncher
{
    public partial class FlyffUniverseWindow : Form
    {
        public static FlyffUniverseWiki? currentWikiWidow;
        private readonly string playLink = "https://universe.flyff.com/play";
        private readonly string flyffipediaLink = "https://flyffipedia.com/";
        private readonly string madrigalinsideLink = "https://madrigalinside.com/";
        private readonly string flyffulatorLink = "https://flyffulator.com/";
        private readonly string madrigalmapsLink = "https://www.madrigalmaps.com/";
        private readonly string flyffmodelviewerLink = "https://flyffmodelviewer.com/";
        private readonly string skillulatorLink = "https://skillulator.com/";
        private string currentUser = string.Empty;
        private bool isFullScreen = false;

        public FlyffUniverseWindow(string windowName, int width, int height)
        {
            InitializeComponent();
            flyffMenuStrip.Visible = false;
            SetWindowProperties(windowName, width, height);
            _ = LaunchGame();
        }

        /// <summary>
        /// Called when the window receives input.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">Current event.</param>
        private void webView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Home)
            {
                flyffMenuStrip.Visible = !flyffMenuStrip.Visible;
            }

            if (e.KeyCode == Keys.F11)
            {
                if (isFullScreen)
                {
                    isFullScreen = false;
                    FormBorderStyle = FormBorderStyle.Sizable;
                    WindowState = FormWindowState.Normal;
                    CenterToScreen();
                    return;
                }

                isFullScreen = true;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                CenterToScreen();
            }
        }

        /// <summary>
        /// Custom event that is called when the window is resized.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">Current event.</param>
        private void ResizeWebView(object? sender, EventArgs e)
        {
            webView.Size = ClientSize - new Size(webView.Location);
        }

        /// <summary>
        /// Sets the window's properties, such as the window name, size and location.
        /// </summary>
        /// <param name="profileName">The profile user's name.</param>
        /// <param name="width">Width of the window.</param>
        /// <param name="height">Height of the window.</param>
        private void SetWindowProperties(string profileName, int width, int height)
        {
            StartPosition = Program.launcher.StartPosition;
            currentUser = profileName;
            Size = new Size(width, height);
            Text += $"{Program.GetVersionAsString()} - {profileName.LetterUpperCase()}";
            Resize += new EventHandler(ResizeWebView);
            Location = Program.launcher.Location;

            // Resize the window.
            ResizeWebView(this, new EventArgs());
        }

        /// <summary>
        /// Task that launches a web request to load the game.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task LaunchGame()
        {
            var directory = Path.Combine(FlyffUniverseLauncher.ProgramNetworkStorage, currentUser);
            var webViewEnvironment = await CoreWebView2Environment.CreateAsync(string.Empty, directory);
            await webView.EnsureCoreWebView2Async(webViewEnvironment);
            webView.Source = new Uri(playLink);
            webView.CoreWebView2.Settings.UserAgent = "Chrome/103.0.0.0";
            webView.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
            Show();
        }

        private void flyffipediaMenuitem_Click(object sender, EventArgs e)
        {
            OpenHelperWindow(flyffipediaLink);
        }

        private void madrigalinsideMenuItem_Click(object sender, EventArgs e)
        {
            OpenHelperWindow(madrigalinsideLink);
        }

        private void flyffulatorMenuItem_Click(object sender, EventArgs e)
        {
            OpenHelperWindow(flyffulatorLink);
        }

        private void madrigalmapsMenuItem_Click(object sender, EventArgs e)
        {
            OpenHelperWindow(madrigalmapsLink);
        }

        private void flyffModelViewerMenuItem_Click(object sender, EventArgs e)
        {
            OpenHelperWindow(flyffmodelviewerLink);
        }

        private void skillulatorMenuItem_Click(object sender, EventArgs e)
        {
            OpenHelperWindow(skillulatorLink);
        }

        private void OpenHelperWindow(string link = "")
        {
            if (currentWikiWidow == null)
            {
                currentWikiWidow = new FlyffUniverseWiki(link);
                currentWikiWidow.Show();
            }
            else
            {
                if (currentWikiWidow.GetCurrentPage() != link)
                {
                    currentWikiWidow.SetPage(link);
                }
                currentWikiWidow.Activate();
            }
        }

        private void hideToolbarMenuItem_Click(object sender, EventArgs e)
        {
            webView_KeyDown(sender, new KeyEventArgs(Keys.Home));
        }

        private void frozenGameClickHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Reload();
        }
    }
}

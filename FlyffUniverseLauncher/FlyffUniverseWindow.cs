using Microsoft.Web.WebView2.Core;
using TsadriuUtilities;

namespace FlyffUniverseLauncher
{
    public partial class FlyffUniverseWindow : Form
    {
        private string user;
        public FlyffUniverseWindow(string windowName, int width, int height)
        {
            width = width.ClampValue(800, Screen.FromControl(this).Bounds.Width);
            height = height.ClampValue(600, Screen.FromControl(this).Bounds.Height);
            InitializeComponent();
            Size = new Size(width, height);
            Text += $"{Program.GetVersionAsString()} {windowName.LetterUpperCase()}";
            user = windowName;
            Resize += new EventHandler(ResizeWebView);
            Location = Program.launcher.Location;
        }

        private void ResizeWebView(object? sender, EventArgs e)
        {
            webView.Size = ClientSize - new Size(webView.Location);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var directory = Path.Combine(Directory.GetCurrentDirectory(), user);
            var webViewEnvironment = await CoreWebView2Environment.CreateAsync(string.Empty, directory);
            await webView.EnsureCoreWebView2Async(webViewEnvironment);
            webView.Source = new Uri("https://universe.flyff.com/play");
            webView.CoreWebView2.Settings.UserAgent = "Chrome";
            launchButton.Hide();
        }

        private void webView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F11")
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    FormBorderStyle = FormBorderStyle.Sizable;
                    WindowState = FormWindowState.Normal;
                    CenterToScreen();
                }
                else
                {
                    FormBorderStyle = FormBorderStyle.None;
                    WindowState = FormWindowState.Maximized;
                }
            }
        }
    }
}

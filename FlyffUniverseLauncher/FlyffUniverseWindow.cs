using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            Text += " - " + windowName.LetterUpperCase();
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
        }
    }
}

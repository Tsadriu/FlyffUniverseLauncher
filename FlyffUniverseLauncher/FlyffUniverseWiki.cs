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
    public partial class FlyffUniverseWiki : Form
    {

        public static string? currentPage;
        private bool settingUpUri = false;

        public FlyffUniverseWiki(string link)
        {
            currentPage = link;
            InitializeComponent();
            SetWindowProperties();
            Resize += new EventHandler(ResizeWebView);
            SetUpUri();
        }

        /// <summary>
        /// Sets the window's properties, such as the window name, size and location.
        /// </summary>
        /// <param name="profileName">The profile user's name.</param>
        /// <param name="width">Width of the window.</param>
        /// <param name="height">Height of the window.</param>
        private void SetWindowProperties()
        {
            StartPosition = Program.launcher.StartPosition;
            Size = new Size(1280.ClampValue(1280, Screen.FromControl(this).Bounds.Width), 720.ClampValue(720, Screen.FromControl(this).Bounds.Height));
            Text += $"{Program.GetVersionAsString()} - Helper";
            Resize += new EventHandler(ResizeWebView);
            Location = Program.launcher.Location;

            // Resize the window.
            ResizeWebView(this, new EventArgs());
        }

        private async void SetUpUri()
        {
            settingUpUri = true;
            var name = "FlyffWiki".ToLower();
            var directory = Path.Combine(FlyffUniverseLauncher.ProgramNetworkStorage, name);
            var webViewEnvironment = await CoreWebView2Environment.CreateAsync(string.Empty, directory);
            await webView2.EnsureCoreWebView2Async(webViewEnvironment);
            webView2.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
            webView2.CoreWebView2.Settings.AreDevToolsEnabled = false;
            webView2.Source = new Uri(currentPage);
            settingUpUri = false;
        }

        private async void FlyffUniverseWiki_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape" && !settingUpUri)
            {
                this.Close();
            }
        }

        public void SetPage(string link)
        {
            currentPage = link;
            webView2.CoreWebView2.Navigate(link);
        }

        /// <summary>
        /// Custom event that is called when the window is resized.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">Current event.</param>
        private void ResizeWebView(object? sender, EventArgs e)
        {
            webView2.Size = ClientSize - new Size(webView2.Location);
        }

        public string GetCurrentPage()
        {
            return webView2.Source.AbsoluteUri;
        }

        private void webView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

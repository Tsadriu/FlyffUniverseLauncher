﻿using Microsoft.Web.WebView2.Core;
using TsadriuUtilities;

namespace FlyffUniverseLauncher
{
    public partial class FlyffUniverseWindow : Form
    {
        private readonly string playLink = "https://universe.flyff.com/play";
        private string currentUser = string.Empty;
        private bool isFullScreen = false;

        public FlyffUniverseWindow(string windowName, int width, int height)
        {
            InitializeComponent();
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
            if (e.KeyCode.ToString() == "F11")
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
        private async Task LaunchGame()
        {
            var directory = Path.Combine(FlyffUniverseLauncher.ProgramNetworkStorage, currentUser);
            var webViewEnvironment = await CoreWebView2Environment.CreateAsync(string.Empty, directory);
            await webView.EnsureCoreWebView2Async(webViewEnvironment);
            webView.Source = new Uri(playLink);
            webView.CoreWebView2.Settings.UserAgent = "Chrome";
        }
    }
}

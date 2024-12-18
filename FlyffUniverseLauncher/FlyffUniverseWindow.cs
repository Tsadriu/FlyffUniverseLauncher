﻿using FlyffUniverseLauncher.Classes;
using FlyffUniverseLauncher.Helpers;
using Microsoft.Web.WebView2.Core;
using System.Text.RegularExpressions;
using TsadriuUtilities;
using TsadriuUtilitiesOld;

namespace FlyffUniverseLauncher
{
    public partial class FlyffUniverseWindow : Form
    {
        public static FlyffUniverseWiki? currentWikiWidow;

        private Profile _currentProfile = null!;
        private bool _isFullScreen = false;

        public FlyffUniverseWindow(Profile profile)
        {
            InitializeComponent();
            flyffMenuStrip.Visible = false;
            _currentProfile = profile;
            SetWindowProperties();
            _ = LaunchGame();
        }

        /// <summary>
        /// Called when the window receives input.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">Current event.</param>
        private void webView_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Home:
                    flyffMenuStrip.Visible = !flyffMenuStrip.Visible;
                    break;
                case Keys.F11 when _isFullScreen:
                    _isFullScreen = false;
                    FormBorderStyle = FormBorderStyle.Sizable;
                    WindowState = FormWindowState.Normal;
                    CenterToScreen();
                    break;
                case Keys.F11:
                    _isFullScreen = true;
                    FormBorderStyle = FormBorderStyle.None;
                    WindowState = FormWindowState.Maximized;
                    CenterToScreen();
                    break;
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
        private void SetWindowProperties()
        {
            StartPosition = Program.launcher.StartPosition;
            Size = new Size(_currentProfile.Width, _currentProfile.Height);
            Text += $@"{Program.CurrentVersion} - {_currentProfile.Name.LetterUpperCase(0)}";
            Resize += ResizeWebView;
            Location = Program.launcher.Location;

            // Resize the window.
            ResizeWebView(null, EventArgs.Empty);
            webView_KeyDown(this, _currentProfile.IsFullScreen ? new KeyEventArgs(Keys.F11) : new KeyEventArgs(Keys.None));
        }

        /// <summary>
        /// Task that launches a web request to load the game.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task LaunchGame()
        {
            var directory = Path.Combine(FlyffUniverseLauncher.ProgramNetworkStorage, Regex.Replace(_currentProfile.Name, @"[^\w\d]", string.Empty));
            var webViewEnvironment = await CoreWebView2Environment.CreateAsync(string.Empty, directory);
            await webView.EnsureCoreWebView2Async(webViewEnvironment);
            webView.Source = new Uri(FlyffUrls.Play);
            webView.CoreWebView2.Settings.UserAgent = "Chrome/103.0.0.0";
            webView.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
            Show();
        }

        private void flyffipediaMenuitem_Click(object sender, EventArgs e)
        {
            OpenHelperWindow(FlyffUrls.Flyffipedia);
        }

        private void madrigalinsideMenuItem_Click(object sender, EventArgs e)
        {
            OpenHelperWindow(FlyffUrls.Madrigalinside);
        }

        private void madrigalmapsMenuItem_Click(object sender, EventArgs e)
        {
            OpenHelperWindow(FlyffUrls.FlyffMap);
        }

        private void flyffModelViewerMenuItem_Click(object sender, EventArgs e)
        {
            OpenHelperWindow(FlyffUrls.Flyffmodelviewer);
        }

        private void skillulatorMenuItem_Click(object sender, EventArgs e)
        {
            OpenHelperWindow(FlyffUrls.Skillulator);
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
                currentWikiWidow.Focus();
            }

            hideToolbarMenuItem_Click(this, EventArgs.Empty);
        }

        private void hideToolbarMenuItem_Click(object sender, EventArgs e)
        {
            webView_KeyDown(sender, new KeyEventArgs(Keys.Home));
        }

        private void frozenGameClickHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Reload();
        }

        private void flyffMeMadrigalMap_Click(object sender, EventArgs e)
        {
            OpenHelperWindow(FlyffUrls.FlyffMap);
        }

        private void flyffMeTrainer_Click(object sender, EventArgs e)
        {
            OpenHelperWindow(FlyffUrls.FlyffTrainer);
        }
    }
}

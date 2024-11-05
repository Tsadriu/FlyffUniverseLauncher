using Microsoft.Web.WebView2.Core;
using TsadriuUtilities;

namespace FlyffUniverseLauncher
{
    partial class FlyffUniverseWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlyffUniverseWindow));
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            flyffipediaMenuitem = new ToolStripMenuItem();
            madrigalinsideMenuItem = new ToolStripMenuItem();
            madrigalmapsMenuItem = new ToolStripMenuItem();
            flyffModelViewerMenuItem = new ToolStripMenuItem();
            skillulatorMenuItem = new ToolStripMenuItem();
            flyffMenuStrip = new MenuStrip();
            frozenGameClickHereToolStripMenuItem = new ToolStripMenuItem();
            hideToolbarMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            flyffMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // webView
            // 
            webView.AllowExternalDrop = false;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.DarkGray;
            webView.Location = new Point(-1, 0);
            webView.Name = "webView";
            webView.Size = new Size(1266, 682);
            webView.TabIndex = 1;
            webView.ZoomFactor = 1D;
            webView.KeyDown += webView_KeyDown;
            // 
            // flyffipediaMenuitem
            // 
            flyffipediaMenuitem.Image = global::FlyffUniverseLauncher.Properties.Resources.flyffipedia;
            flyffipediaMenuitem.Name = "flyffipediaMenuitem";
            flyffipediaMenuitem.Size = new Size(90, 20);
            flyffipediaMenuitem.Text = "Flyffipedia";
            flyffipediaMenuitem.ToolTipText = "Opens a new window with the Flyffipedia page";
            flyffipediaMenuitem.Click += flyffipediaMenuitem_Click;
            // 
            // madrigalinsideMenuItem
            // 
            madrigalinsideMenuItem.Image = global::FlyffUniverseLauncher.Properties.Resources.madrigaslinside;
            madrigalinsideMenuItem.Name = "madrigalinsideMenuItem";
            madrigalinsideMenuItem.Size = new Size(113, 20);
            madrigalinsideMenuItem.Text = "Madrigalinside";
            madrigalinsideMenuItem.Click += madrigalinsideMenuItem_Click;
            // 
            // madrigalmapsMenuItem
            // 
            madrigalmapsMenuItem.Image = global::FlyffUniverseLauncher.Properties.Resources.madrigalmap;
            madrigalmapsMenuItem.Name = "madrigalmapsMenuItem";
            madrigalmapsMenuItem.Size = new Size(111, 20);
            madrigalmapsMenuItem.Text = "Madrigalmaps";
            madrigalmapsMenuItem.Click += madrigalmapsMenuItem_Click;
            // 
            // flyffModelViewerMenuItem
            // 
            flyffModelViewerMenuItem.Image = global::FlyffUniverseLauncher.Properties.Resources.modelviewer;
            flyffModelViewerMenuItem.Name = "flyffModelViewerMenuItem";
            flyffModelViewerMenuItem.Size = new Size(133, 20);
            flyffModelViewerMenuItem.Text = "Flyff Model Viewer";
            flyffModelViewerMenuItem.Click += flyffModelViewerMenuItem_Click;
            // 
            // skillulatorMenuItem
            // 
            skillulatorMenuItem.Image = global::FlyffUniverseLauncher.Properties.Resources.skillulator;
            skillulatorMenuItem.Name = "skillulatorMenuItem";
            skillulatorMenuItem.Size = new Size(87, 20);
            skillulatorMenuItem.Text = "Skillulator";
            skillulatorMenuItem.Click += skillulatorMenuItem_Click;
            // 
            // flyffMenuStrip
            // 
            flyffMenuStrip.Dock = DockStyle.Left;
            flyffMenuStrip.Items.AddRange(new ToolStripItem[] { flyffipediaMenuitem, madrigalinsideMenuItem, madrigalmapsMenuItem, flyffModelViewerMenuItem, skillulatorMenuItem, frozenGameClickHereToolStripMenuItem, hideToolbarMenuItem });
            flyffMenuStrip.LayoutStyle = ToolStripLayoutStyle.Table;
            flyffMenuStrip.Location = new Point(0, 0);
            flyffMenuStrip.Name = "flyffMenuStrip";
            flyffMenuStrip.Size = new Size(139, 681);
            flyffMenuStrip.TabIndex = 2;
            flyffMenuStrip.Text = "Flyff Universe Launcher Helper";
            // 
            // frozenGameClickHereToolStripMenuItem
            // 
            frozenGameClickHereToolStripMenuItem.Image = global::FlyffUniverseLauncher.Properties.Resources.Elementor_Blizzard;
            frozenGameClickHereToolStripMenuItem.Name = "frozenGameClickHereToolStripMenuItem";
            frozenGameClickHereToolStripMenuItem.Size = new Size(103, 20);
            frozenGameClickHereToolStripMenuItem.Text = "Frozen game";
            frozenGameClickHereToolStripMenuItem.ToolTipText = "Click here in case the game window has frozen";
            frozenGameClickHereToolStripMenuItem.Click += frozenGameClickHereToolStripMenuItem_Click;
            // 
            // hideToolbarMenuItem
            // 
            hideToolbarMenuItem.Name = "hideToolbarMenuItem";
            hideToolbarMenuItem.Size = new Size(78, 19);
            hideToolbarMenuItem.Text = "Hide menu";
            hideToolbarMenuItem.Click += hideToolbarMenuItem_Click;
            // 
            // FlyffUniverseWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1264, 681);
            Controls.Add(flyffMenuStrip);
            Controls.Add(webView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = flyffMenuStrip;
            Name = "FlyffUniverseWindow";
            Text = "Flyff Universe Launcher - ";
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            flyffMenuStrip.ResumeLayout(false);
            flyffMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private ToolStripMenuItem flyffipediaMenuitem;
        private ToolStripMenuItem madrigalinsideMenuItem;
        private ToolStripMenuItem madrigalmapsMenuItem;
        private ToolStripMenuItem flyffModelViewerMenuItem;
        private ToolStripMenuItem skillulatorMenuItem;
        private MenuStrip flyffMenuStrip;
        private ToolStripMenuItem hideToolbarMenuItem;
        private ToolStripMenuItem frozenGameClickHereToolStripMenuItem;
    }
}
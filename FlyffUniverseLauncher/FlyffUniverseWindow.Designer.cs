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
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.flyffipediaMenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.madrigalinsideMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flyffulatorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.madrigalmapsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flyffModelViewerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skillulatorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.flyffMenuStrip = new System.Windows.Forms.MenuStrip();
            this.hideToolbarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frozenGameClickHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.flyffMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = false;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.DarkGray;
            this.webView.Location = new System.Drawing.Point(-1, 0);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(1266, 682);
            this.webView.TabIndex = 1;
            this.webView.ZoomFactor = 1D;
            this.webView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.webView_KeyDown);
            // 
            // flyffipediaMenuitem
            // 
            this.flyffipediaMenuitem.Image = global::FlyffUniverseLauncher.Properties.Resources.flyffipedia;
            this.flyffipediaMenuitem.Name = "flyffipediaMenuitem";
            this.flyffipediaMenuitem.Size = new System.Drawing.Size(90, 20);
            this.flyffipediaMenuitem.Text = "Flyffipedia";
            this.flyffipediaMenuitem.ToolTipText = "Opens a new window with the Flyffipedia page";
            this.flyffipediaMenuitem.Click += new System.EventHandler(this.flyffipediaMenuitem_Click);
            // 
            // madrigalinsideMenuItem
            // 
            this.madrigalinsideMenuItem.Image = global::FlyffUniverseLauncher.Properties.Resources.madrigaslinside;
            this.madrigalinsideMenuItem.Name = "madrigalinsideMenuItem";
            this.madrigalinsideMenuItem.Size = new System.Drawing.Size(113, 20);
            this.madrigalinsideMenuItem.Text = "Madrigalinside";
            this.madrigalinsideMenuItem.Click += new System.EventHandler(this.madrigalinsideMenuItem_Click);
            // 
            // flyffulatorMenuItem
            // 
            this.flyffulatorMenuItem.Image = global::FlyffUniverseLauncher.Properties.Resources.flyffulator;
            this.flyffulatorMenuItem.Name = "flyffulatorMenuItem";
            this.flyffulatorMenuItem.Size = new System.Drawing.Size(89, 20);
            this.flyffulatorMenuItem.Text = "Flyffulator";
            this.flyffulatorMenuItem.Click += new System.EventHandler(this.flyffulatorMenuItem_Click);
            // 
            // madrigalmapsMenuItem
            // 
            this.madrigalmapsMenuItem.Image = global::FlyffUniverseLauncher.Properties.Resources.madrigalmap;
            this.madrigalmapsMenuItem.Name = "madrigalmapsMenuItem";
            this.madrigalmapsMenuItem.Size = new System.Drawing.Size(111, 20);
            this.madrigalmapsMenuItem.Text = "Madrigalmaps";
            this.madrigalmapsMenuItem.Click += new System.EventHandler(this.madrigalmapsMenuItem_Click);
            // 
            // flyffModelViewerMenuItem
            // 
            this.flyffModelViewerMenuItem.Image = global::FlyffUniverseLauncher.Properties.Resources.modelviewer;
            this.flyffModelViewerMenuItem.Name = "flyffModelViewerMenuItem";
            this.flyffModelViewerMenuItem.Size = new System.Drawing.Size(133, 20);
            this.flyffModelViewerMenuItem.Text = "Flyff Model Viewer";
            this.flyffModelViewerMenuItem.Click += new System.EventHandler(this.flyffModelViewerMenuItem_Click);
            // 
            // skillulatorMenuItem
            // 
            this.skillulatorMenuItem.Image = global::FlyffUniverseLauncher.Properties.Resources.skillulator;
            this.skillulatorMenuItem.Name = "skillulatorMenuItem";
            this.skillulatorMenuItem.Size = new System.Drawing.Size(87, 20);
            this.skillulatorMenuItem.Text = "Skillulator";
            this.skillulatorMenuItem.Click += new System.EventHandler(this.skillulatorMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "(Press F1 to hide/show)";
            // 
            // flyffMenuStrip
            // 
            this.flyffMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flyffipediaMenuitem,
            this.madrigalinsideMenuItem,
            this.flyffulatorMenuItem,
            this.madrigalmapsMenuItem,
            this.flyffModelViewerMenuItem,
            this.skillulatorMenuItem,
            this.toolStripTextBox1,
            this.frozenGameClickHereToolStripMenuItem,
            this.hideToolbarMenuItem});
            this.flyffMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.flyffMenuStrip.Name = "flyffMenuStrip";
            this.flyffMenuStrip.Size = new System.Drawing.Size(1264, 24);
            this.flyffMenuStrip.TabIndex = 2;
            this.flyffMenuStrip.Text = "Flyff Universe Launcher Helper";
            // 
            // hideToolbarMenuItem
            // 
            this.hideToolbarMenuItem.Name = "hideToolbarMenuItem";
            this.hideToolbarMenuItem.Size = new System.Drawing.Size(78, 20);
            this.hideToolbarMenuItem.Text = "Hide menu";
            this.hideToolbarMenuItem.Click += new System.EventHandler(this.hideToolbarMenuItem_Click);
            // 
            // frozenGameClickHereToolStripMenuItem
            // 
            this.frozenGameClickHereToolStripMenuItem.Name = "frozenGameClickHereToolStripMenuItem";
            this.frozenGameClickHereToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.frozenGameClickHereToolStripMenuItem.Text = "Frozen game? Click here";
            this.frozenGameClickHereToolStripMenuItem.Click += new System.EventHandler(this.frozenGameClickHereToolStripMenuItem_Click);
            // 
            // FlyffUniverseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.flyffMenuStrip);
            this.Controls.Add(this.webView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.flyffMenuStrip;
            this.Name = "FlyffUniverseWindow";
            this.Text = "Flyff Universe Launcher - ";
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.flyffMenuStrip.ResumeLayout(false);
            this.flyffMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private ToolStripMenuItem flyffipediaMenuitem;
        private ToolStripMenuItem madrigalinsideMenuItem;
        private ToolStripMenuItem flyffulatorMenuItem;
        private ToolStripMenuItem madrigalmapsMenuItem;
        private ToolStripMenuItem flyffModelViewerMenuItem;
        private ToolStripMenuItem skillulatorMenuItem;
        private ToolStripTextBox toolStripTextBox1;
        private MenuStrip flyffMenuStrip;
        private ToolStripMenuItem hideToolbarMenuItem;
        private ToolStripMenuItem frozenGameClickHereToolStripMenuItem;
    }
}
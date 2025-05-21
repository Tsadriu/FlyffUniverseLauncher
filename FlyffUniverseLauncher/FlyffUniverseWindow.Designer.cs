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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlyffUniverseWindow));
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            flyffipediaMenuitem = new System.Windows.Forms.ToolStripMenuItem();
            madrigalinsideMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            flyffModelViewerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            skillulatorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            flyffMenuStrip = new System.Windows.Forms.MenuStrip();
            flyffMeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            flyffMeMadrigalMap = new System.Windows.Forms.ToolStripMenuItem();
            flyffMeTrainer = new System.Windows.Forms.ToolStripMenuItem();
            frozenGameClickHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            hideToolbarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            gameWindowTooltip = new System.Windows.Forms.ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            flyffMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // webView
            // 
            webView.AllowExternalDrop = false;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = System.Drawing.Color.DarkGray;
            webView.Location = new System.Drawing.Point(-1, 0);
            webView.Name = "webView";
            webView.Size = new System.Drawing.Size(1266, 682);
            webView.TabIndex = 1;
            webView.ZoomFactor = 1D;
            webView.KeyDown += webView_KeyDown;
            // 
            // flyffipediaMenuitem
            // 
            flyffipediaMenuitem.Image = global::FlyffUniverseLauncher.Properties.Resources.flyffipedia;
            flyffipediaMenuitem.Name = "flyffipediaMenuitem";
            flyffipediaMenuitem.Size = new System.Drawing.Size(90, 20);
            flyffipediaMenuitem.Text = "Flyffipedia";
            flyffipediaMenuitem.ToolTipText = "Opens a new window with the Flyffipedia page";
            flyffipediaMenuitem.Click += flyffipediaMenuitem_Click;
            // 
            // madrigalinsideMenuItem
            // 
            madrigalinsideMenuItem.Image = global::FlyffUniverseLauncher.Properties.Resources.madrigaslinside;
            madrigalinsideMenuItem.Name = "madrigalinsideMenuItem";
            madrigalinsideMenuItem.Size = new System.Drawing.Size(113, 20);
            madrigalinsideMenuItem.Text = "Madrigalinside";
            madrigalinsideMenuItem.Click += madrigalinsideMenuItem_Click;
            // 
            // flyffModelViewerMenuItem
            // 
            flyffModelViewerMenuItem.Image = global::FlyffUniverseLauncher.Properties.Resources.modelviewer;
            flyffModelViewerMenuItem.Name = "flyffModelViewerMenuItem";
            flyffModelViewerMenuItem.Size = new System.Drawing.Size(133, 20);
            flyffModelViewerMenuItem.Text = "Flyff Model Viewer";
            flyffModelViewerMenuItem.Click += flyffModelViewerMenuItem_Click;
            // 
            // skillulatorMenuItem
            // 
            skillulatorMenuItem.Image = global::FlyffUniverseLauncher.Properties.Resources.skillulator;
            skillulatorMenuItem.Name = "skillulatorMenuItem";
            skillulatorMenuItem.Size = new System.Drawing.Size(87, 20);
            skillulatorMenuItem.Text = "Skillulator";
            skillulatorMenuItem.Click += skillulatorMenuItem_Click;
            // 
            // flyffMenuStrip
            // 
            flyffMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { flyffipediaMenuitem, madrigalinsideMenuItem, flyffMeMenuItem, flyffModelViewerMenuItem, skillulatorMenuItem, frozenGameClickHereToolStripMenuItem, hideToolbarMenuItem });
            flyffMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            flyffMenuStrip.Location = new System.Drawing.Point(0, 0);
            flyffMenuStrip.Name = "flyffMenuStrip";
            flyffMenuStrip.Size = new System.Drawing.Size(1264, 24);
            flyffMenuStrip.TabIndex = 2;
            flyffMenuStrip.Text = "Flyff Universe Launcher Helper";
            // 
            // flyffMeMenuItem
            // 
            flyffMeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { flyffMeMadrigalMap, flyffMeTrainer });
            flyffMeMenuItem.Image = global::FlyffUniverseLauncher.Properties.Resources.flyfftrainer;
            flyffMeMenuItem.Name = "flyffMeMenuItem";
            flyffMeMenuItem.Size = new System.Drawing.Size(78, 20);
            flyffMeMenuItem.Text = "Flyff.Me";
            // 
            // flyffMeMadrigalMap
            // 
            flyffMeMadrigalMap.Image = global::FlyffUniverseLauncher.Properties.Resources.Elementor_Cursed_Mind;
            flyffMeMadrigalMap.Name = "flyffMeMadrigalMap";
            flyffMeMadrigalMap.Size = new System.Drawing.Size(180, 22);
            flyffMeMadrigalMap.Text = "Map";
            flyffMeMadrigalMap.Click += flyffMeMadrigalMap_Click;
            // 
            // flyffMeTrainer
            // 
            flyffMeTrainer.Image = global::FlyffUniverseLauncher.Properties.Resources.Mercenary_Sword_Mastery;
            flyffMeTrainer.Name = "flyffMeTrainer";
            flyffMeTrainer.Size = new System.Drawing.Size(180, 22);
            flyffMeTrainer.Text = "Trainer";
            flyffMeTrainer.Click += flyffMeTrainer_Click;
            // 
            // frozenGameClickHereToolStripMenuItem
            // 
            frozenGameClickHereToolStripMenuItem.AutoToolTip = true;
            frozenGameClickHereToolStripMenuItem.Image = global::FlyffUniverseLauncher.Properties.Resources.Elementor_Blizzard;
            frozenGameClickHereToolStripMenuItem.Name = "frozenGameClickHereToolStripMenuItem";
            frozenGameClickHereToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            frozenGameClickHereToolStripMenuItem.Text = "Frozen game";
            frozenGameClickHereToolStripMenuItem.ToolTipText = "Click here in case the game window has frozen";
            frozenGameClickHereToolStripMenuItem.Click += frozenGameClickHereToolStripMenuItem_Click;
            // 
            // hideToolbarMenuItem
            // 
            hideToolbarMenuItem.Image = global::FlyffUniverseLauncher.Properties.Resources.Jester_Silence;
            hideToolbarMenuItem.Name = "hideToolbarMenuItem";
            hideToolbarMenuItem.Size = new System.Drawing.Size(94, 20);
            hideToolbarMenuItem.Text = "Hide menu";
            hideToolbarMenuItem.Click += hideToolbarMenuItem_Click;
            // 
            // FlyffUniverseWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.InactiveCaption;
            ClientSize = new System.Drawing.Size(1264, 681);
            Controls.Add(flyffMenuStrip);
            Controls.Add(webView);
            Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
            MainMenuStrip = flyffMenuStrip;
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
        private ToolStripMenuItem flyffModelViewerMenuItem;
        private ToolStripMenuItem skillulatorMenuItem;
        private MenuStrip flyffMenuStrip;
        private ToolStripMenuItem hideToolbarMenuItem;
        private ToolStripMenuItem frozenGameClickHereToolStripMenuItem;
        private System.Windows.Forms.ToolTip gameWindowTooltip;
        private ToolStripMenuItem flyffMeMenuItem;
        private ToolStripMenuItem flyffMeMadrigalMap;
        private ToolStripMenuItem flyffMeTrainer;
    }
}
namespace FlyffUniverseLauncher
{
    partial class FlyffUniverseLauncher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlyffUniverseLauncher));
            this.playButton = new System.Windows.Forms.Button();
            this.selectUserInput = new System.Windows.Forms.ComboBox();
            this.selectUserLabel = new System.Windows.Forms.Label();
            this.newsWindow = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.madeByLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.profileSettingsTab = new System.Windows.Forms.TabPage();
            this.closeNewsButton = new System.Windows.Forms.Button();
            this.windowSettingsTab = new System.Windows.Forms.TabPage();
            this.webViewPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.newsWindow)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.profileSettingsTab.SuspendLayout();
            this.windowSettingsTab.SuspendLayout();
            this.webViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(6, 56);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // selectUserInput
            // 
            this.selectUserInput.FormattingEnabled = true;
            this.selectUserInput.Location = new System.Drawing.Point(6, 27);
            this.selectUserInput.Name = "selectUserInput";
            this.selectUserInput.Size = new System.Drawing.Size(184, 23);
            this.selectUserInput.TabIndex = 1;
            this.selectUserInput.SelectedIndexChanged += new System.EventHandler(this.selectUserInput_SelectedIndexChanged);
            this.selectUserInput.TextChanged += new System.EventHandler(this.selectUserInput_TextChanged);
            // 
            // selectUserLabel
            // 
            this.selectUserLabel.AutoSize = true;
            this.selectUserLabel.Location = new System.Drawing.Point(6, 9);
            this.selectUserLabel.Name = "selectUserLabel";
            this.selectUserLabel.Size = new System.Drawing.Size(184, 15);
            this.selectUserLabel.TabIndex = 0;
            this.selectUserLabel.Text = "Select a profile or type a new one:";
            // 
            // newsWindow
            // 
            this.newsWindow.AllowExternalDrop = false;
            this.newsWindow.BackColor = System.Drawing.SystemColors.Control;
            this.newsWindow.CreationProperties = null;
            this.newsWindow.DefaultBackgroundColor = System.Drawing.Color.Silver;
            this.newsWindow.Location = new System.Drawing.Point(3, 3);
            this.newsWindow.Name = "newsWindow";
            this.newsWindow.Size = new System.Drawing.Size(905, 651);
            this.newsWindow.TabIndex = 2;
            this.newsWindow.ZoomFactor = 1D;
            this.newsWindow.NavigationStarting += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>(this.newsWindow_NavigationStarting);
            // 
            // madeByLabel
            // 
            this.madeByLabel.AutoSize = true;
            this.madeByLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.madeByLabel.Location = new System.Drawing.Point(21, 157);
            this.madeByLabel.Name = "madeByLabel";
            this.madeByLabel.Size = new System.Drawing.Size(99, 15);
            this.madeByLabel.TabIndex = 4;
            this.madeByLabel.Text = "Made by: Tsadriu";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(21, 80);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(43, 15);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Height";
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(21, 105);
            this.heightInput.Name = "heightInput";
            this.heightInput.PlaceholderText = "600";
            this.heightInput.Size = new System.Drawing.Size(100, 23);
            this.heightInput.TabIndex = 2;
            this.heightInput.Text = "600";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(21, 16);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(39, 15);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "Width";
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(21, 34);
            this.widthInput.Name = "widthInput";
            this.widthInput.PlaceholderText = "800";
            this.widthInput.Size = new System.Drawing.Size(100, 23);
            this.widthInput.TabIndex = 0;
            this.widthInput.Text = "800";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.profileSettingsTab);
            this.tabControl1.Controls.Add(this.windowSettingsTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(229, 294);
            this.tabControl1.TabIndex = 4;
            // 
            // profileSettingsTab
            // 
            this.profileSettingsTab.Controls.Add(this.closeNewsButton);
            this.profileSettingsTab.Controls.Add(this.selectUserInput);
            this.profileSettingsTab.Controls.Add(this.selectUserLabel);
            this.profileSettingsTab.Controls.Add(this.playButton);
            this.profileSettingsTab.Location = new System.Drawing.Point(4, 24);
            this.profileSettingsTab.Name = "profileSettingsTab";
            this.profileSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.profileSettingsTab.Size = new System.Drawing.Size(221, 266);
            this.profileSettingsTab.TabIndex = 0;
            this.profileSettingsTab.Text = "Profile Settings";
            this.profileSettingsTab.UseVisualStyleBackColor = true;
            // 
            // closeNewsButton
            // 
            this.closeNewsButton.Location = new System.Drawing.Point(6, 237);
            this.closeNewsButton.Name = "closeNewsButton";
            this.closeNewsButton.Size = new System.Drawing.Size(98, 23);
            this.closeNewsButton.TabIndex = 2;
            this.closeNewsButton.Text = "Close news tab";
            this.closeNewsButton.UseVisualStyleBackColor = true;
            this.closeNewsButton.Click += new System.EventHandler(this.closeNewsButton_Click);
            // 
            // windowSettingsTab
            // 
            this.windowSettingsTab.Controls.Add(this.madeByLabel);
            this.windowSettingsTab.Controls.Add(this.widthLabel);
            this.windowSettingsTab.Controls.Add(this.heightInput);
            this.windowSettingsTab.Controls.Add(this.heightLabel);
            this.windowSettingsTab.Controls.Add(this.widthInput);
            this.windowSettingsTab.Location = new System.Drawing.Point(4, 24);
            this.windowSettingsTab.Name = "windowSettingsTab";
            this.windowSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.windowSettingsTab.Size = new System.Drawing.Size(221, 266);
            this.windowSettingsTab.TabIndex = 1;
            this.windowSettingsTab.Text = "Window Settings";
            this.windowSettingsTab.UseVisualStyleBackColor = true;
            // 
            // webViewPanel
            // 
            this.webViewPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.webViewPanel.Controls.Add(this.newsWindow);
            this.webViewPanel.Location = new System.Drawing.Point(341, 12);
            this.webViewPanel.Name = "webViewPanel";
            this.webViewPanel.Size = new System.Drawing.Size(911, 657);
            this.webViewPanel.TabIndex = 5;
            // 
            // FlyffUniverseLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlyffUniverseLauncher.Properties.Resources.img1;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.webViewPanel);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FlyffUniverseLauncher";
            this.Text = "Flyff Universe Launcher - ";
            ((System.ComponentModel.ISupportInitialize)(this.newsWindow)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.profileSettingsTab.ResumeLayout(false);
            this.profileSettingsTab.PerformLayout();
            this.windowSettingsTab.ResumeLayout(false);
            this.windowSettingsTab.PerformLayout();
            this.webViewPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button playButton;
        private ComboBox selectUserInput;
        private Label selectUserLabel;
        private Microsoft.Web.WebView2.WinForms.WebView2 newsWindow;
        private Label heightLabel;
        private TextBox heightInput;
        private Label widthLabel;
        private TextBox widthInput;
        private Label madeByLabel;
        private TabControl tabControl1;
        private TabPage profileSettingsTab;
        private TabPage windowSettingsTab;
        private Panel webViewPanel;
        private Button closeNewsButton;
    }
}
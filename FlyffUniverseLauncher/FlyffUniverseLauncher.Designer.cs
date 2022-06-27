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
            this.playButton = new System.Windows.Forms.Button();
            this.selectUserInput = new System.Windows.Forms.ComboBox();
            this.selectUserLabel = new System.Windows.Forms.Label();
            this.newsWindow = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.settingsBox = new System.Windows.Forms.GroupBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.madeByLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.newsWindow)).BeginInit();
            this.settingsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(163, 31);
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
            this.selectUserInput.Location = new System.Drawing.Point(12, 31);
            this.selectUserInput.Name = "selectUserInput";
            this.selectUserInput.Size = new System.Drawing.Size(145, 23);
            this.selectUserInput.TabIndex = 1;
            this.selectUserInput.SelectedIndexChanged += new System.EventHandler(this.selectUserInput_SelectedIndexChanged);
            this.selectUserInput.TextChanged += new System.EventHandler(this.selectUserInput_TextChanged);
            // 
            // selectUserLabel
            // 
            this.selectUserLabel.AutoSize = true;
            this.selectUserLabel.Location = new System.Drawing.Point(12, 9);
            this.selectUserLabel.Name = "selectUserLabel";
            this.selectUserLabel.Size = new System.Drawing.Size(145, 15);
            this.selectUserLabel.TabIndex = 0;
            this.selectUserLabel.Text = "Select an user or type one:";
            // 
            // newsWindow
            // 
            this.newsWindow.AllowExternalDrop = false;
            this.newsWindow.CreationProperties = null;
            this.newsWindow.DefaultBackgroundColor = System.Drawing.Color.White;
            this.newsWindow.Location = new System.Drawing.Point(316, 12);
            this.newsWindow.Name = "newsWindow";
            this.newsWindow.Size = new System.Drawing.Size(936, 657);
            this.newsWindow.TabIndex = 2;
            this.newsWindow.ZoomFactor = 1D;
            this.newsWindow.NavigationStarting += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>(this.newsWindow_NavigationStarting);
            // 
            // settingsBox
            // 
            this.settingsBox.Controls.Add(this.madeByLabel);
            this.settingsBox.Controls.Add(this.heightLabel);
            this.settingsBox.Controls.Add(this.heightInput);
            this.settingsBox.Controls.Add(this.widthLabel);
            this.settingsBox.Controls.Add(this.widthInput);
            this.settingsBox.Location = new System.Drawing.Point(12, 172);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(200, 187);
            this.settingsBox.TabIndex = 3;
            this.settingsBox.TabStop = false;
            this.settingsBox.Text = "Settings";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(6, 90);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(43, 15);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Height";
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(6, 108);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(100, 23);
            this.heightInput.TabIndex = 2;
            this.heightInput.Text = "600";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(6, 33);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(39, 15);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "Width";
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(6, 51);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(100, 23);
            this.widthInput.TabIndex = 0;
            this.widthInput.Text = "800";
            // 
            // madeByLabel
            // 
            this.madeByLabel.AutoSize = true;
            this.madeByLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.madeByLabel.Location = new System.Drawing.Point(6, 152);
            this.madeByLabel.Name = "madeByLabel";
            this.madeByLabel.Size = new System.Drawing.Size(99, 15);
            this.madeByLabel.TabIndex = 4;
            this.madeByLabel.Text = "Made by: Tsadriu";
            // 
            // FlyffUniverseLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.settingsBox);
            this.Controls.Add(this.newsWindow);
            this.Controls.Add(this.selectUserLabel);
            this.Controls.Add(this.selectUserInput);
            this.Controls.Add(this.playButton);
            this.Name = "FlyffUniverseLauncher";
            this.Text = "Flyff Universe Launcher -";
            ((System.ComponentModel.ISupportInitialize)(this.newsWindow)).EndInit();
            this.settingsBox.ResumeLayout(false);
            this.settingsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button playButton;
        private ComboBox selectUserInput;
        private Label selectUserLabel;
        private Microsoft.Web.WebView2.WinForms.WebView2 newsWindow;
        private GroupBox settingsBox;
        private Label heightLabel;
        private TextBox heightInput;
        private Label widthLabel;
        private TextBox widthInput;
        private Label madeByLabel;
    }
}
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlyffUniverseLauncher));
            playButton = new Button();
            selectUserInput = new ComboBox();
            selectUserLabel = new Label();
            newsWindow = new Microsoft.Web.WebView2.WinForms.WebView2();
            madeByLabel = new Label();
            heightLabel = new Label();
            heightInput = new TextBox();
            widthLabel = new Label();
            widthInput = new TextBox();
            launcherTabControl = new TabControl();
            profileSettingsTab = new TabPage();
            closeNewsButton = new Button();
            windowSettingsTab = new TabPage();
            fullScreenCheckBox = new CheckBox();
            adaptToScreenSizeButton = new Button();
            manageProfilesTab = new TabPage();
            manageProfileDeleteAllButton = new Button();
            manageProfileDeleteButton = new Button();
            manageProfileSaveButton = new Button();
            manageProfileFullscreenCheckBox = new CheckBox();
            manageProfileHeightTextBox = new TextBox();
            label4 = new Label();
            manageProfileWidthTextBox = new TextBox();
            label3 = new Label();
            manageProfileNameTextBox = new TextBox();
            label2 = new Label();
            manageProfileComboBox = new ComboBox();
            selectProfileToModifyLabel = new Label();
            webViewPanel = new Panel();
            manageProfileAdaptToScreenSize = new Button();
            ((System.ComponentModel.ISupportInitialize)newsWindow).BeginInit();
            launcherTabControl.SuspendLayout();
            profileSettingsTab.SuspendLayout();
            windowSettingsTab.SuspendLayout();
            manageProfilesTab.SuspendLayout();
            webViewPanel.SuspendLayout();
            SuspendLayout();
            // 
            // playButton
            // 
            playButton.Location = new Point(20, 65);
            playButton.Name = "playButton";
            playButton.Size = new Size(99, 23);
            playButton.TabIndex = 1;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // selectUserInput
            // 
            selectUserInput.FormattingEnabled = true;
            selectUserInput.Location = new Point(20, 27);
            selectUserInput.Name = "selectUserInput";
            selectUserInput.Size = new Size(248, 23);
            selectUserInput.TabIndex = 1;
            selectUserInput.SelectedIndexChanged += selectUserInput_SelectedIndexChanged;
            selectUserInput.TextChanged += selectUserInput_TextChanged;
            // 
            // selectUserLabel
            // 
            selectUserLabel.AutoSize = true;
            selectUserLabel.Location = new Point(51, 9);
            selectUserLabel.Name = "selectUserLabel";
            selectUserLabel.Size = new Size(184, 15);
            selectUserLabel.TabIndex = 0;
            selectUserLabel.Text = "Select a profile or type a new one:";
            // 
            // newsWindow
            // 
            newsWindow.AllowExternalDrop = false;
            newsWindow.BackColor = SystemColors.Control;
            newsWindow.CreationProperties = null;
            newsWindow.DefaultBackgroundColor = Color.Silver;
            newsWindow.Location = new Point(3, 3);
            newsWindow.Name = "newsWindow";
            newsWindow.Size = new Size(905, 651);
            newsWindow.TabIndex = 2;
            newsWindow.ZoomFactor = 1D;
            newsWindow.NavigationStarting += newsWindow_NavigationStarting;
            // 
            // madeByLabel
            // 
            madeByLabel.AutoSize = true;
            madeByLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            madeByLabel.Location = new Point(21, 208);
            madeByLabel.Name = "madeByLabel";
            madeByLabel.Size = new Size(99, 15);
            madeByLabel.TabIndex = 4;
            madeByLabel.Text = "Made by: Tsadriu";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(21, 80);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(43, 15);
            heightLabel.TabIndex = 3;
            heightLabel.Text = "Height";
            // 
            // heightInput
            // 
            heightInput.Location = new Point(21, 105);
            heightInput.Name = "heightInput";
            heightInput.PlaceholderText = "600";
            heightInput.Size = new Size(127, 23);
            heightInput.TabIndex = 2;
            heightInput.Text = "600";
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new Point(21, 16);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(39, 15);
            widthLabel.TabIndex = 1;
            widthLabel.Text = "Width";
            // 
            // widthInput
            // 
            widthInput.Location = new Point(21, 34);
            widthInput.Name = "widthInput";
            widthInput.PlaceholderText = "800";
            widthInput.Size = new Size(127, 23);
            widthInput.TabIndex = 0;
            widthInput.Text = "800";
            // 
            // launcherTabControl
            // 
            launcherTabControl.Controls.Add(profileSettingsTab);
            launcherTabControl.Controls.Add(windowSettingsTab);
            launcherTabControl.Controls.Add(manageProfilesTab);
            launcherTabControl.Location = new Point(12, 12);
            launcherTabControl.Name = "launcherTabControl";
            launcherTabControl.SelectedIndex = 0;
            launcherTabControl.Size = new Size(292, 357);
            launcherTabControl.TabIndex = 4;
            // 
            // profileSettingsTab
            // 
            profileSettingsTab.Controls.Add(closeNewsButton);
            profileSettingsTab.Controls.Add(selectUserInput);
            profileSettingsTab.Controls.Add(selectUserLabel);
            profileSettingsTab.Controls.Add(playButton);
            profileSettingsTab.Location = new Point(4, 24);
            profileSettingsTab.Name = "profileSettingsTab";
            profileSettingsTab.Padding = new Padding(3);
            profileSettingsTab.Size = new Size(284, 295);
            profileSettingsTab.TabIndex = 0;
            profileSettingsTab.Text = "Profile Settings";
            profileSettingsTab.UseVisualStyleBackColor = true;
            // 
            // closeNewsButton
            // 
            closeNewsButton.Location = new Point(170, 65);
            closeNewsButton.Name = "closeNewsButton";
            closeNewsButton.Size = new Size(98, 23);
            closeNewsButton.TabIndex = 2;
            closeNewsButton.Text = "Close news tab";
            closeNewsButton.UseVisualStyleBackColor = true;
            closeNewsButton.Click += closeNewsButton_Click;
            // 
            // windowSettingsTab
            // 
            windowSettingsTab.Controls.Add(fullScreenCheckBox);
            windowSettingsTab.Controls.Add(adaptToScreenSizeButton);
            windowSettingsTab.Controls.Add(madeByLabel);
            windowSettingsTab.Controls.Add(widthLabel);
            windowSettingsTab.Controls.Add(heightInput);
            windowSettingsTab.Controls.Add(heightLabel);
            windowSettingsTab.Controls.Add(widthInput);
            windowSettingsTab.Location = new Point(4, 24);
            windowSettingsTab.Name = "windowSettingsTab";
            windowSettingsTab.Padding = new Padding(3);
            windowSettingsTab.Size = new Size(284, 329);
            windowSettingsTab.TabIndex = 1;
            windowSettingsTab.Text = "Window Settings";
            windowSettingsTab.UseVisualStyleBackColor = true;
            // 
            // fullScreenCheckBox
            // 
            fullScreenCheckBox.AutoSize = true;
            fullScreenCheckBox.Location = new Point(21, 176);
            fullScreenCheckBox.Name = "fullScreenCheckBox";
            fullScreenCheckBox.Size = new Size(84, 19);
            fullScreenCheckBox.TabIndex = 6;
            fullScreenCheckBox.Text = "Fullscreen?";
            fullScreenCheckBox.UseVisualStyleBackColor = true;
            // 
            // adaptToScreenSizeButton
            // 
            adaptToScreenSizeButton.Location = new Point(21, 134);
            adaptToScreenSizeButton.Name = "adaptToScreenSizeButton";
            adaptToScreenSizeButton.Size = new Size(127, 26);
            adaptToScreenSizeButton.TabIndex = 5;
            adaptToScreenSizeButton.Text = "Adapt to screen size";
            adaptToScreenSizeButton.UseVisualStyleBackColor = true;
            adaptToScreenSizeButton.Click += adaptToScreenSizeButton_Click;
            // 
            // manageProfilesTab
            // 
            manageProfilesTab.Controls.Add(manageProfileAdaptToScreenSize);
            manageProfilesTab.Controls.Add(manageProfileDeleteAllButton);
            manageProfilesTab.Controls.Add(manageProfileDeleteButton);
            manageProfilesTab.Controls.Add(manageProfileSaveButton);
            manageProfilesTab.Controls.Add(manageProfileFullscreenCheckBox);
            manageProfilesTab.Controls.Add(manageProfileHeightTextBox);
            manageProfilesTab.Controls.Add(label4);
            manageProfilesTab.Controls.Add(manageProfileWidthTextBox);
            manageProfilesTab.Controls.Add(label3);
            manageProfilesTab.Controls.Add(manageProfileNameTextBox);
            manageProfilesTab.Controls.Add(label2);
            manageProfilesTab.Controls.Add(manageProfileComboBox);
            manageProfilesTab.Controls.Add(selectProfileToModifyLabel);
            manageProfilesTab.Location = new Point(4, 24);
            manageProfilesTab.Name = "manageProfilesTab";
            manageProfilesTab.Size = new Size(284, 329);
            manageProfilesTab.TabIndex = 2;
            manageProfilesTab.Text = "Manage Profiles";
            // 
            // manageProfileDeleteAllButton
            // 
            manageProfileDeleteAllButton.BackColor = Color.Brown;
            manageProfileDeleteAllButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            manageProfileDeleteAllButton.ForeColor = Color.White;
            manageProfileDeleteAllButton.Location = new Point(69, 288);
            manageProfileDeleteAllButton.Name = "manageProfileDeleteAllButton";
            manageProfileDeleteAllButton.Size = new Size(127, 23);
            manageProfileDeleteAllButton.TabIndex = 11;
            manageProfileDeleteAllButton.Text = "Delete all profiles";
            manageProfileDeleteAllButton.UseVisualStyleBackColor = false;
            manageProfileDeleteAllButton.Click += manageProfileDeleteAllButton_Click;
            // 
            // manageProfileDeleteButton
            // 
            manageProfileDeleteButton.Location = new Point(69, 259);
            manageProfileDeleteButton.Name = "manageProfileDeleteButton";
            manageProfileDeleteButton.Size = new Size(127, 23);
            manageProfileDeleteButton.TabIndex = 10;
            manageProfileDeleteButton.Text = "Delete this profile";
            manageProfileDeleteButton.UseVisualStyleBackColor = true;
            manageProfileDeleteButton.Click += manageProfileDeleteButton_Click;
            // 
            // manageProfileSaveButton
            // 
            manageProfileSaveButton.Location = new Point(69, 230);
            manageProfileSaveButton.Name = "manageProfileSaveButton";
            manageProfileSaveButton.Size = new Size(127, 23);
            manageProfileSaveButton.TabIndex = 9;
            manageProfileSaveButton.Text = "Save changes";
            manageProfileSaveButton.UseVisualStyleBackColor = true;
            manageProfileSaveButton.Click += manageProfileSaveButton_Click;
            // 
            // manageProfileFullscreenCheckBox
            // 
            manageProfileFullscreenCheckBox.AutoSize = true;
            manageProfileFullscreenCheckBox.Location = new Point(18, 182);
            manageProfileFullscreenCheckBox.Name = "manageProfileFullscreenCheckBox";
            manageProfileFullscreenCheckBox.Size = new Size(84, 19);
            manageProfileFullscreenCheckBox.TabIndex = 8;
            manageProfileFullscreenCheckBox.Text = "Fullscreen?";
            manageProfileFullscreenCheckBox.UseVisualStyleBackColor = true;
            // 
            // manageProfileHeightTextBox
            // 
            manageProfileHeightTextBox.Location = new Point(145, 153);
            manageProfileHeightTextBox.Name = "manageProfileHeightTextBox";
            manageProfileHeightTextBox.Size = new Size(117, 23);
            manageProfileHeightTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 135);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 6;
            label4.Text = "Preffered height";
            // 
            // manageProfileWidthTextBox
            // 
            manageProfileWidthTextBox.Location = new Point(13, 153);
            manageProfileWidthTextBox.Name = "manageProfileWidthTextBox";
            manageProfileWidthTextBox.Size = new Size(110, 23);
            manageProfileWidthTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 135);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 4;
            label3.Text = "Preferred width";
            // 
            // manageProfileNameTextBox
            // 
            manageProfileNameTextBox.Location = new Point(13, 98);
            manageProfileNameTextBox.Name = "manageProfileNameTextBox";
            manageProfileNameTextBox.Size = new Size(249, 23);
            manageProfileNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 80);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 2;
            label2.Text = "Profile name";
            // 
            // manageProfileComboBox
            // 
            manageProfileComboBox.FormattingEnabled = true;
            manageProfileComboBox.Location = new Point(13, 34);
            manageProfileComboBox.Name = "manageProfileComboBox";
            manageProfileComboBox.Size = new Size(249, 23);
            manageProfileComboBox.TabIndex = 1;
            manageProfileComboBox.SelectedIndexChanged += manageProfileComboBox_SelectedIndexChanged;
            // 
            // selectProfileToModifyLabel
            // 
            selectProfileToModifyLabel.AutoSize = true;
            selectProfileToModifyLabel.Location = new Point(13, 16);
            selectProfileToModifyLabel.Name = "selectProfileToModifyLabel";
            selectProfileToModifyLabel.Size = new Size(153, 15);
            selectProfileToModifyLabel.TabIndex = 0;
            selectProfileToModifyLabel.Text = "Select the profile to modify:";
            // 
            // webViewPanel
            // 
            webViewPanel.BackColor = SystemColors.ActiveCaption;
            webViewPanel.Controls.Add(newsWindow);
            webViewPanel.Location = new Point(341, 12);
            webViewPanel.Name = "webViewPanel";
            webViewPanel.Size = new Size(911, 657);
            webViewPanel.TabIndex = 5;
            // 
            // manageProfileAdaptToScreenSize
            // 
            manageProfileAdaptToScreenSize.Location = new Point(138, 182);
            manageProfileAdaptToScreenSize.Name = "manageProfileAdaptToScreenSize";
            manageProfileAdaptToScreenSize.Size = new Size(124, 23);
            manageProfileAdaptToScreenSize.TabIndex = 12;
            manageProfileAdaptToScreenSize.Text = "Adapt to screen size";
            manageProfileAdaptToScreenSize.UseVisualStyleBackColor = true;
            manageProfileAdaptToScreenSize.Click += manageProfileAdaptToScreenSize_Click;
            // 
            // FlyffUniverseLauncher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(webViewPanel);
            Controls.Add(launcherTabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FlyffUniverseLauncher";
            Text = "Flyff Universe Launcher - ";
            ((System.ComponentModel.ISupportInitialize)newsWindow).EndInit();
            launcherTabControl.ResumeLayout(false);
            profileSettingsTab.ResumeLayout(false);
            profileSettingsTab.PerformLayout();
            windowSettingsTab.ResumeLayout(false);
            windowSettingsTab.PerformLayout();
            manageProfilesTab.ResumeLayout(false);
            manageProfilesTab.PerformLayout();
            webViewPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.TabPage manageProfilesTab;
        #endregion
        private Button playButton;
        private System.Windows.Forms.ComboBox selectUserInput;
        private System.Windows.Forms.Label selectUserLabel;
        private Microsoft.Web.WebView2.WinForms.WebView2 newsWindow;
        private Label heightLabel;
        private TextBox heightInput;
        private Label widthLabel;
        private TextBox widthInput;
        private Label madeByLabel;
        private System.Windows.Forms.TabControl launcherTabControl;
        private System.Windows.Forms.TabPage profileSettingsTab;
        private TabPage windowSettingsTab;
        private Panel webViewPanel;
        private Button closeNewsButton;
        private Button adaptToScreenSizeButton;
        private TextBox manageProfileHeightTextBox;
        private Label label4;
        private TextBox manageProfileWidthTextBox;
        private Label label3;
        private TextBox manageProfileNameTextBox;
        private Label label2;
        private ComboBox manageProfileComboBox;
        private Label selectProfileToModifyLabel;
        private Button manageProfileDeleteAllButton;
        private Button manageProfileDeleteButton;
        private Button manageProfileSaveButton;
        private CheckBox manageProfileFullscreenCheckBox;
        private CheckBox fullScreenCheckBox;
        private Button manageProfileAdaptToScreenSize;
    }
}
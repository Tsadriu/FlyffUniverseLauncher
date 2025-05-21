namespace FlyffUniverseLauncher
{
    sealed partial class FlyffUniverseLauncher
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
            panel1 = new System.Windows.Forms.Panel();
            launcherTabControl = new System.Windows.Forms.TabControl();
            profileSettingsTab = new System.Windows.Forms.TabPage();
            ful_language_comboBox = new System.Windows.Forms.ComboBox();
            ful_language_label = new System.Windows.Forms.Label();
            ful_credit_label = new System.Windows.Forms.Label();
            createNewProfileButton = new System.Windows.Forms.Button();
            selectUserInput = new System.Windows.Forms.ComboBox();
            selectUserLabel = new System.Windows.Forms.Label();
            playButton = new System.Windows.Forms.Button();
            manageProfilesTab = new System.Windows.Forms.TabPage();
            manageProfileAdaptToScreenSize = new System.Windows.Forms.Button();
            manageProfileDeleteAllButton = new System.Windows.Forms.Button();
            manageProfileDeleteButton = new System.Windows.Forms.Button();
            manageProfileSaveButton = new System.Windows.Forms.Button();
            manageProfileFullscreenCheckBox = new System.Windows.Forms.CheckBox();
            manageProfileHeightTextBox = new System.Windows.Forms.TextBox();
            manageProfileWidthTextBox = new System.Windows.Forms.TextBox();
            manageProfileNameTextBox = new System.Windows.Forms.TextBox();
            manageProfiles_preferredHeightLabel = new System.Windows.Forms.Label();
            manageProfiles_preferredWidthLabel = new System.Windows.Forms.Label();
            manageProfiles_profileNameLabel = new System.Windows.Forms.Label();
            manageProfileComboBox = new System.Windows.Forms.ComboBox();
            selectProfileToModifyLabel = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            launcherTabControl.SuspendLayout();
            profileSettingsTab.SuspendLayout();
            manageProfilesTab.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(launcherTabControl);
            panel1.Location = new System.Drawing.Point(48, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(301, 371);
            panel1.TabIndex = 6;
            // 
            // launcherTabControl
            // 
            launcherTabControl.Controls.Add(profileSettingsTab);
            launcherTabControl.Controls.Add(manageProfilesTab);
            launcherTabControl.Location = new System.Drawing.Point(3, 3);
            launcherTabControl.Name = "launcherTabControl";
            launcherTabControl.SelectedIndex = 0;
            launcherTabControl.Size = new System.Drawing.Size(292, 357);
            launcherTabControl.TabIndex = 4;
            // 
            // profileSettingsTab
            // 
            profileSettingsTab.Controls.Add(ful_language_comboBox);
            profileSettingsTab.Controls.Add(ful_language_label);
            profileSettingsTab.Controls.Add(ful_credit_label);
            profileSettingsTab.Controls.Add(createNewProfileButton);
            profileSettingsTab.Controls.Add(selectUserInput);
            profileSettingsTab.Controls.Add(selectUserLabel);
            profileSettingsTab.Controls.Add(playButton);
            profileSettingsTab.Location = new System.Drawing.Point(4, 24);
            profileSettingsTab.Name = "profileSettingsTab";
            profileSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            profileSettingsTab.Size = new System.Drawing.Size(284, 329);
            profileSettingsTab.TabIndex = 0;
            profileSettingsTab.Text = "Profile Settings";
            profileSettingsTab.UseVisualStyleBackColor = true;
            // 
            // ful_language_comboBox
            // 
            ful_language_comboBox.FormattingEnabled = true;
            ful_language_comboBox.Items.AddRange(new object[] { "English", "Italiano", "Deutsch" });
            ful_language_comboBox.Location = new System.Drawing.Point(137, 203);
            ful_language_comboBox.Name = "ful_language_comboBox";
            ful_language_comboBox.Size = new System.Drawing.Size(121, 23);
            ful_language_comboBox.TabIndex = 8;
            ful_language_comboBox.SelectedIndexChanged += ful__Language_ComboBox_SelectedIndexChanged;
            // 
            // ful_language_label
            // 
            ful_language_label.Location = new System.Drawing.Point(137, 177);
            ful_language_label.Name = "ful_language_label";
            ful_language_label.Size = new System.Drawing.Size(121, 23);
            ful_language_label.TabIndex = 7;
            ful_language_label.Text = "Launcher language";
            // 
            // ful_credit_label
            // 
            ful_credit_label.AutoSize = true;
            ful_credit_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            ful_credit_label.Location = new System.Drawing.Point(20, 285);
            ful_credit_label.Name = "ful_credit_label";
            ful_credit_label.Size = new System.Drawing.Size(177, 30);
            ful_credit_label.TabIndex = 6;
            ful_credit_label.Text = "Made by Tsadriu\r\nPowered by Microsoft WebView2";
            // 
            // createNewProfileButton
            // 
            createNewProfileButton.Location = new System.Drawing.Point(142, 53);
            createNewProfileButton.Name = "createNewProfileButton";
            createNewProfileButton.Size = new System.Drawing.Size(116, 23);
            createNewProfileButton.TabIndex = 5;
            createNewProfileButton.Text = "Create new profile";
            createNewProfileButton.UseVisualStyleBackColor = true;
            createNewProfileButton.Click += createNewProfileButton_Click;
            // 
            // selectUserInput
            // 
            selectUserInput.FormattingEnabled = true;
            selectUserInput.Location = new System.Drawing.Point(20, 27);
            selectUserInput.Name = "selectUserInput";
            selectUserInput.Size = new System.Drawing.Size(238, 23);
            selectUserInput.TabIndex = 1;
            selectUserInput.SelectedIndexChanged += selectUserInput_SelectedIndexChanged;
            selectUserInput.TextChanged += selectUserInput_TextChanged;
            // 
            // selectUserLabel
            // 
            selectUserLabel.AutoSize = true;
            selectUserLabel.Location = new System.Drawing.Point(20, 9);
            selectUserLabel.Name = "selectUserLabel";
            selectUserLabel.Size = new System.Drawing.Size(184, 15);
            selectUserLabel.TabIndex = 0;
            selectUserLabel.Text = "Select a profile or type a new one:";
            // 
            // playButton
            // 
            playButton.Location = new System.Drawing.Point(20, 53);
            playButton.Name = "playButton";
            playButton.Size = new System.Drawing.Size(116, 23);
            playButton.TabIndex = 1;
            playButton.Text = "Launch profile";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // manageProfilesTab
            // 
            manageProfilesTab.Controls.Add(manageProfileAdaptToScreenSize);
            manageProfilesTab.Controls.Add(manageProfileDeleteAllButton);
            manageProfilesTab.Controls.Add(manageProfileDeleteButton);
            manageProfilesTab.Controls.Add(manageProfileSaveButton);
            manageProfilesTab.Controls.Add(manageProfileFullscreenCheckBox);
            manageProfilesTab.Controls.Add(manageProfileHeightTextBox);
            manageProfilesTab.Controls.Add(manageProfileWidthTextBox);
            manageProfilesTab.Controls.Add(manageProfileNameTextBox);
            manageProfilesTab.Controls.Add(manageProfiles_preferredHeightLabel);
            manageProfilesTab.Controls.Add(manageProfiles_preferredWidthLabel);
            manageProfilesTab.Controls.Add(manageProfiles_profileNameLabel);
            manageProfilesTab.Controls.Add(manageProfileComboBox);
            manageProfilesTab.Controls.Add(selectProfileToModifyLabel);
            manageProfilesTab.Location = new System.Drawing.Point(4, 24);
            manageProfilesTab.Name = "manageProfilesTab";
            manageProfilesTab.Size = new System.Drawing.Size(284, 329);
            manageProfilesTab.TabIndex = 2;
            manageProfilesTab.Text = "Manage Profiles";
            // 
            // manageProfileAdaptToScreenSize
            // 
            manageProfileAdaptToScreenSize.Location = new System.Drawing.Point(138, 182);
            manageProfileAdaptToScreenSize.Name = "manageProfileAdaptToScreenSize";
            manageProfileAdaptToScreenSize.Size = new System.Drawing.Size(124, 23);
            manageProfileAdaptToScreenSize.TabIndex = 12;
            manageProfileAdaptToScreenSize.Text = "Adapt to screen size";
            manageProfileAdaptToScreenSize.UseVisualStyleBackColor = true;
            manageProfileAdaptToScreenSize.Click += manageProfileAdaptToScreenSize_Click;
            // 
            // manageProfileDeleteAllButton
            // 
            manageProfileDeleteAllButton.BackColor = System.Drawing.Color.Brown;
            manageProfileDeleteAllButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            manageProfileDeleteAllButton.ForeColor = System.Drawing.Color.White;
            manageProfileDeleteAllButton.Location = new System.Drawing.Point(69, 288);
            manageProfileDeleteAllButton.Name = "manageProfileDeleteAllButton";
            manageProfileDeleteAllButton.Size = new System.Drawing.Size(127, 23);
            manageProfileDeleteAllButton.TabIndex = 11;
            manageProfileDeleteAllButton.Text = "Delete all profiles";
            manageProfileDeleteAllButton.UseVisualStyleBackColor = false;
            manageProfileDeleteAllButton.Click += manageProfileDeleteAllButton_Click;
            // 
            // manageProfileDeleteButton
            // 
            manageProfileDeleteButton.Location = new System.Drawing.Point(69, 259);
            manageProfileDeleteButton.Name = "manageProfileDeleteButton";
            manageProfileDeleteButton.Size = new System.Drawing.Size(127, 23);
            manageProfileDeleteButton.TabIndex = 10;
            manageProfileDeleteButton.Text = "Delete this profile";
            manageProfileDeleteButton.UseVisualStyleBackColor = true;
            manageProfileDeleteButton.Click += manageProfileDeleteButton_Click;
            // 
            // manageProfileSaveButton
            // 
            manageProfileSaveButton.Location = new System.Drawing.Point(69, 230);
            manageProfileSaveButton.Name = "manageProfileSaveButton";
            manageProfileSaveButton.Size = new System.Drawing.Size(127, 23);
            manageProfileSaveButton.TabIndex = 9;
            manageProfileSaveButton.Text = "Save changes";
            manageProfileSaveButton.UseVisualStyleBackColor = true;
            manageProfileSaveButton.Click += manageProfileSaveButton_Click;
            // 
            // manageProfileFullscreenCheckBox
            // 
            manageProfileFullscreenCheckBox.AutoSize = true;
            manageProfileFullscreenCheckBox.Location = new System.Drawing.Point(18, 182);
            manageProfileFullscreenCheckBox.Name = "manageProfileFullscreenCheckBox";
            manageProfileFullscreenCheckBox.Size = new System.Drawing.Size(84, 19);
            manageProfileFullscreenCheckBox.TabIndex = 8;
            manageProfileFullscreenCheckBox.Text = "Fullscreen?";
            manageProfileFullscreenCheckBox.UseVisualStyleBackColor = true;
            // 
            // manageProfileHeightTextBox
            // 
            manageProfileHeightTextBox.Location = new System.Drawing.Point(145, 153);
            manageProfileHeightTextBox.Name = "manageProfileHeightTextBox";
            manageProfileHeightTextBox.Size = new System.Drawing.Size(117, 23);
            manageProfileHeightTextBox.TabIndex = 7;
            // 
            // manageProfileWidthTextBox
            // 
            manageProfileWidthTextBox.Location = new System.Drawing.Point(13, 153);
            manageProfileWidthTextBox.Name = "manageProfileWidthTextBox";
            manageProfileWidthTextBox.Size = new System.Drawing.Size(110, 23);
            manageProfileWidthTextBox.TabIndex = 5;
            // 
            // manageProfileNameTextBox
            // 
            manageProfileNameTextBox.Location = new System.Drawing.Point(13, 98);
            manageProfileNameTextBox.Name = "manageProfileNameTextBox";
            manageProfileNameTextBox.Size = new System.Drawing.Size(249, 23);
            manageProfileNameTextBox.TabIndex = 3;
            // 
            // manageProfiles_preferredHeightLabel
            // 
            manageProfiles_preferredHeightLabel.AutoSize = true;
            manageProfiles_preferredHeightLabel.Location = new System.Drawing.Point(145, 135);
            manageProfiles_preferredHeightLabel.Name = "manageProfiles_preferredHeightLabel";
            manageProfiles_preferredHeightLabel.Size = new System.Drawing.Size(92, 15);
            manageProfiles_preferredHeightLabel.TabIndex = 6;
            manageProfiles_preferredHeightLabel.Text = "Preffered height";
            // 
            // manageProfiles_preferredWidthLabel
            // 
            manageProfiles_preferredWidthLabel.AutoSize = true;
            manageProfiles_preferredWidthLabel.Location = new System.Drawing.Point(13, 135);
            manageProfiles_preferredWidthLabel.Name = "manageProfiles_preferredWidthLabel";
            manageProfiles_preferredWidthLabel.Size = new System.Drawing.Size(88, 15);
            manageProfiles_preferredWidthLabel.TabIndex = 4;
            manageProfiles_preferredWidthLabel.Text = "Preferred width";
            // 
            // manageProfiles_profileNameLabel
            // 
            manageProfiles_profileNameLabel.AutoSize = true;
            manageProfiles_profileNameLabel.Location = new System.Drawing.Point(13, 80);
            manageProfiles_profileNameLabel.Name = "manageProfiles_profileNameLabel";
            manageProfiles_profileNameLabel.Size = new System.Drawing.Size(74, 15);
            manageProfiles_profileNameLabel.TabIndex = 2;
            manageProfiles_profileNameLabel.Text = "Profile name";
            // 
            // manageProfileComboBox
            // 
            manageProfileComboBox.FormattingEnabled = true;
            manageProfileComboBox.Location = new System.Drawing.Point(13, 34);
            manageProfileComboBox.Name = "manageProfileComboBox";
            manageProfileComboBox.Size = new System.Drawing.Size(249, 23);
            manageProfileComboBox.TabIndex = 1;
            manageProfileComboBox.SelectedIndexChanged += manageProfileComboBox_SelectedIndexChanged;
            // 
            // selectProfileToModifyLabel
            // 
            selectProfileToModifyLabel.AutoSize = true;
            selectProfileToModifyLabel.Location = new System.Drawing.Point(13, 16);
            selectProfileToModifyLabel.Name = "selectProfileToModifyLabel";
            selectProfileToModifyLabel.Size = new System.Drawing.Size(153, 15);
            selectProfileToModifyLabel.TabIndex = 0;
            selectProfileToModifyLabel.Text = "Select the profile to modify:";
            // 
            // FlyffUniverseLauncher
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(399, 408);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
            MaximizeBox = false;
            Text = "Flyff Universe Launcher - ";
            panel1.ResumeLayout(false);
            launcherTabControl.ResumeLayout(false);
            profileSettingsTab.ResumeLayout(false);
            profileSettingsTab.PerformLayout();
            manageProfilesTab.ResumeLayout(false);
            manageProfilesTab.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label ful_language_label;
        private System.Windows.Forms.ComboBox ful_language_comboBox;

        #endregion
        private Panel panel1;
        private TabControl launcherTabControl;
        private System.Windows.Forms.TabPage profileSettingsTab;
        private Button createNewProfileButton;
        private ComboBox selectUserInput;
        private Label selectUserLabel;
        private Button playButton;
        private TabPage manageProfilesTab;
        private Button manageProfileAdaptToScreenSize;
        private Button manageProfileDeleteAllButton;
        private Button manageProfileDeleteButton;
        private Button manageProfileSaveButton;
        private CheckBox manageProfileFullscreenCheckBox;
        private TextBox manageProfileHeightTextBox;
        private TextBox manageProfileWidthTextBox;
        private TextBox manageProfileNameTextBox;
        private Label manageProfiles_preferredHeightLabel;
        private Label manageProfiles_preferredWidthLabel;
        private Label manageProfiles_profileNameLabel;
        private ComboBox manageProfileComboBox;
        private Label selectProfileToModifyLabel;
        private Label ful_credit_label;
    }
}
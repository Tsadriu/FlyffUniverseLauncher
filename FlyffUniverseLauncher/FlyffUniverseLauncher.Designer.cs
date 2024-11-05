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
            panel1 = new Panel();
            launcherTabControl = new TabControl();
            profileSettingsTab = new TabPage();
            label1 = new Label();
            createNewProfileButton = new Button();
            selectUserInput = new ComboBox();
            selectUserLabel = new Label();
            playButton = new Button();
            manageProfilesTab = new TabPage();
            manageProfileAdaptToScreenSize = new Button();
            manageProfileDeleteAllButton = new Button();
            manageProfileDeleteButton = new Button();
            manageProfileSaveButton = new Button();
            manageProfileFullscreenCheckBox = new CheckBox();
            manageProfileHeightTextBox = new TextBox();
            manageProfileWidthTextBox = new TextBox();
            manageProfileNameTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            manageProfileComboBox = new ComboBox();
            selectProfileToModifyLabel = new Label();
            panel1.SuspendLayout();
            launcherTabControl.SuspendLayout();
            profileSettingsTab.SuspendLayout();
            manageProfilesTab.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(launcherTabControl);
            panel1.Location = new Point(48, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 371);
            panel1.TabIndex = 6;
            // 
            // launcherTabControl
            // 
            launcherTabControl.Controls.Add(profileSettingsTab);
            launcherTabControl.Controls.Add(manageProfilesTab);
            launcherTabControl.Location = new Point(3, 3);
            launcherTabControl.Name = "launcherTabControl";
            launcherTabControl.SelectedIndex = 0;
            launcherTabControl.Size = new Size(292, 357);
            launcherTabControl.TabIndex = 4;
            // 
            // profileSettingsTab
            // 
            profileSettingsTab.Controls.Add(label1);
            profileSettingsTab.Controls.Add(createNewProfileButton);
            profileSettingsTab.Controls.Add(selectUserInput);
            profileSettingsTab.Controls.Add(selectUserLabel);
            profileSettingsTab.Controls.Add(playButton);
            profileSettingsTab.Location = new Point(4, 24);
            profileSettingsTab.Name = "profileSettingsTab";
            profileSettingsTab.Padding = new Padding(3);
            profileSettingsTab.Size = new Size(284, 329);
            profileSettingsTab.TabIndex = 0;
            profileSettingsTab.Text = "Profile Settings";
            profileSettingsTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label1.Location = new Point(20, 285);
            label1.Name = "label1";
            label1.Size = new Size(177, 30);
            label1.TabIndex = 6;
            label1.Text = "Made by Tsadriu\r\nPowered by Microsoft WebView2";
            // 
            // createNewProfileButton
            // 
            createNewProfileButton.Location = new Point(142, 53);
            createNewProfileButton.Name = "createNewProfileButton";
            createNewProfileButton.Size = new Size(116, 23);
            createNewProfileButton.TabIndex = 5;
            createNewProfileButton.Text = "Create new profile";
            createNewProfileButton.UseVisualStyleBackColor = true;
            createNewProfileButton.Click += createNewProfileButton_Click;
            // 
            // selectUserInput
            // 
            selectUserInput.FormattingEnabled = true;
            selectUserInput.Location = new Point(20, 27);
            selectUserInput.Name = "selectUserInput";
            selectUserInput.Size = new Size(238, 23);
            selectUserInput.TabIndex = 1;
            selectUserInput.SelectedIndexChanged += selectUserInput_SelectedIndexChanged;
            selectUserInput.TextChanged += selectUserInput_TextChanged;
            // 
            // selectUserLabel
            // 
            selectUserLabel.AutoSize = true;
            selectUserLabel.Location = new Point(20, 9);
            selectUserLabel.Name = "selectUserLabel";
            selectUserLabel.Size = new Size(184, 15);
            selectUserLabel.TabIndex = 0;
            selectUserLabel.Text = "Select a profile or type a new one:";
            // 
            // playButton
            // 
            playButton.Location = new Point(20, 53);
            playButton.Name = "playButton";
            playButton.Size = new Size(116, 23);
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
            manageProfilesTab.Controls.Add(label4);
            manageProfilesTab.Controls.Add(label3);
            manageProfilesTab.Controls.Add(label2);
            manageProfilesTab.Controls.Add(manageProfileComboBox);
            manageProfilesTab.Controls.Add(selectProfileToModifyLabel);
            manageProfilesTab.Location = new Point(4, 24);
            manageProfilesTab.Name = "manageProfilesTab";
            manageProfilesTab.Size = new Size(284, 329);
            manageProfilesTab.TabIndex = 2;
            manageProfilesTab.Text = "Manage Profiles";
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
            // manageProfileDeleteAllButton
            // 
            manageProfileDeleteAllButton.BackColor = Color.Brown;
            manageProfileDeleteAllButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
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
            // manageProfileWidthTextBox
            // 
            manageProfileWidthTextBox.Location = new Point(13, 153);
            manageProfileWidthTextBox.Name = "manageProfileWidthTextBox";
            manageProfileWidthTextBox.Size = new Size(110, 23);
            manageProfileWidthTextBox.TabIndex = 5;
            // 
            // manageProfileNameTextBox
            // 
            manageProfileNameTextBox.Location = new Point(13, 98);
            manageProfileNameTextBox.Name = "manageProfileNameTextBox";
            manageProfileNameTextBox.Size = new Size(249, 23);
            manageProfileNameTextBox.TabIndex = 3;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 135);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 4;
            label3.Text = "Preferred width";
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
            // FlyffUniverseLauncher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 408);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FlyffUniverseLauncher";
            Text = "Flyff Universe Launcher - ";
            panel1.ResumeLayout(false);
            launcherTabControl.ResumeLayout(false);
            profileSettingsTab.ResumeLayout(false);
            profileSettingsTab.PerformLayout();
            manageProfilesTab.ResumeLayout(false);
            manageProfilesTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TabControl launcherTabControl;
        private TabPage profileSettingsTab;
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
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox manageProfileComboBox;
        private Label selectProfileToModifyLabel;
        private Label label1;
    }
}
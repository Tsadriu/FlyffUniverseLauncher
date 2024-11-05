using System.ComponentModel;

namespace FlyffUniverseLauncher;

partial class FlyffUniverseNewProfileWindow
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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

        Program.launcher.Show();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new Container();
        ComponentResourceManager resources = new ComponentResourceManager(typeof(FlyffUniverseNewProfileWindow));
        newProfileAdaptScreenSizeButton = new Button();
        newProfileSaveButton = new Button();
        newProfileFullscreenCheckBox = new CheckBox();
        newProfilePrefHeightTextBox = new TextBox();
        newProfilePrefHeightLabel = new Label();
        newProfilePrefWidthTextBox = new TextBox();
        newProfilePrefWidthLabel = new Label();
        newProfileNameTextBox = new TextBox();
        newProfileNameLabel = new Label();
        newProfileTooltip = new ToolTip(components);
        SuspendLayout();
        // 
        // newProfileAdaptScreenSizeButton
        // 
        newProfileAdaptScreenSizeButton.Location = new Point(219, 141);
        newProfileAdaptScreenSizeButton.Name = "newProfileAdaptScreenSizeButton";
        newProfileAdaptScreenSizeButton.Size = new Size(122, 23);
        newProfileAdaptScreenSizeButton.TabIndex = 23;
        newProfileAdaptScreenSizeButton.Text = "Adapt to screen size";
        newProfileTooltip.SetToolTip(newProfileAdaptScreenSizeButton, "Not sure about the width and/or height of your screen?\r\nPress this button and it will automatically adapt to your screen");
        newProfileAdaptScreenSizeButton.UseVisualStyleBackColor = true;
        newProfileAdaptScreenSizeButton.Click += newProfileAdaptScreenSizeButton_Click;
        // 
        // newProfileSaveButton
        // 
        newProfileSaveButton.Location = new Point(150, 182);
        newProfileSaveButton.Name = "newProfileSaveButton";
        newProfileSaveButton.Size = new Size(127, 23);
        newProfileSaveButton.TabIndex = 20;
        newProfileSaveButton.Text = "Save profile";
        newProfileSaveButton.UseVisualStyleBackColor = true;
        newProfileSaveButton.Click += newProfileSaveButton_Click;
        // 
        // newProfileFullscreenCheckBox
        // 
        newProfileFullscreenCheckBox.AutoSize = true;
        newProfileFullscreenCheckBox.Location = new Point(92, 145);
        newProfileFullscreenCheckBox.Name = "newProfileFullscreenCheckBox";
        newProfileFullscreenCheckBox.Size = new Size(84, 19);
        newProfileFullscreenCheckBox.TabIndex = 19;
        newProfileFullscreenCheckBox.Text = "Fullscreen?";
        newProfileTooltip.SetToolTip(newProfileFullscreenCheckBox, "If it's checked, when the profile is launched, the window will be at fullscreen");
        newProfileFullscreenCheckBox.UseVisualStyleBackColor = true;
        // 
        // newProfilePrefHeightTextBox
        // 
        newProfilePrefHeightTextBox.Location = new Point(219, 109);
        newProfilePrefHeightTextBox.Name = "newProfilePrefHeightTextBox";
        newProfilePrefHeightTextBox.Size = new Size(122, 23);
        newProfilePrefHeightTextBox.TabIndex = 18;
        // 
        // newProfilePrefHeightLabel
        // 
        newProfilePrefHeightLabel.AutoSize = true;
        newProfilePrefHeightLabel.Location = new Point(219, 91);
        newProfilePrefHeightLabel.Name = "newProfilePrefHeightLabel";
        newProfilePrefHeightLabel.Size = new Size(92, 15);
        newProfilePrefHeightLabel.TabIndex = 17;
        newProfilePrefHeightLabel.Text = "Preffered height";
        newProfileTooltip.SetToolTip(newProfilePrefHeightLabel, "The height of the program when the profile is launched.");
        // 
        // newProfilePrefWidthTextBox
        // 
        newProfilePrefWidthTextBox.Location = new Point(92, 109);
        newProfilePrefWidthTextBox.Name = "newProfilePrefWidthTextBox";
        newProfilePrefWidthTextBox.Size = new Size(110, 23);
        newProfilePrefWidthTextBox.TabIndex = 16;
        // 
        // newProfilePrefWidthLabel
        // 
        newProfilePrefWidthLabel.AutoSize = true;
        newProfilePrefWidthLabel.Location = new Point(92, 91);
        newProfilePrefWidthLabel.Name = "newProfilePrefWidthLabel";
        newProfilePrefWidthLabel.Size = new Size(88, 15);
        newProfilePrefWidthLabel.TabIndex = 15;
        newProfilePrefWidthLabel.Text = "Preferred width";
        newProfileTooltip.SetToolTip(newProfilePrefWidthLabel, "The width of the program when the profile is launched.");
        // 
        // newProfileNameTextBox
        // 
        newProfileNameTextBox.Location = new Point(92, 51);
        newProfileNameTextBox.Name = "newProfileNameTextBox";
        newProfileNameTextBox.Size = new Size(249, 23);
        newProfileNameTextBox.TabIndex = 14;
        // 
        // newProfileNameLabel
        // 
        newProfileNameLabel.AutoSize = true;
        newProfileNameLabel.Location = new Point(92, 33);
        newProfileNameLabel.Name = "newProfileNameLabel";
        newProfileNameLabel.Size = new Size(74, 15);
        newProfileNameLabel.TabIndex = 13;
        newProfileNameLabel.Text = "Profile name";
        // 
        // newProfileTooltip
        // 
        newProfileTooltip.ToolTipIcon = ToolTipIcon.Info;
        newProfileTooltip.ToolTipTitle = "Info";
        // 
        // FlyffUniverseNewProfileWindow
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(446, 239);
        Controls.Add(newProfileAdaptScreenSizeButton);
        Controls.Add(newProfileSaveButton);
        Controls.Add(newProfileFullscreenCheckBox);
        Controls.Add(newProfilePrefHeightTextBox);
        Controls.Add(newProfilePrefHeightLabel);
        Controls.Add(newProfilePrefWidthTextBox);
        Controls.Add(newProfilePrefWidthLabel);
        Controls.Add(newProfileNameTextBox);
        Controls.Add(newProfileNameLabel);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        Name = "FlyffUniverseNewProfileWindow";
        Text = "FlyffUniverseNewProfileWindow";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button newProfileAdaptScreenSizeButton;
    private Button newProfileSaveButton;
    private CheckBox newProfileFullscreenCheckBox;
    private TextBox newProfilePrefHeightTextBox;
    private Label newProfilePrefHeightLabel;
    private TextBox newProfilePrefWidthTextBox;
    private Label newProfilePrefWidthLabel;
    private TextBox newProfileNameTextBox;
    private Label newProfileNameLabel;
    private ToolTip newProfileTooltip;
}
using System.Text.RegularExpressions;
using FlyffUniverseLauncher.Classes;
using FlyffUniverseLauncher.Properties;

namespace FlyffUniverseLauncher;

public sealed partial class FlyffUniverseNewProfile : Form
{
    public FlyffUniverseNewProfile()
    {
        InitializeComponent();
        Text = "Flyff Universe Launcher - " + Program.CurrentVersion + " - New profile";
        StartPosition = Program.launcher.StartPosition;
        Location = Program.launcher.Location;
        Program.launcher.Hide();
        UpdateAllLabelsLanguage();
        Show();
        Focus();
    }

    private void newProfileSaveButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(newProfileNameTextBox.Text))
        {
            MessageBox.Show(Resources.FULNP_saveButton_invalidUsername, Resources.FULNP_saveButton_invalidUsername_caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (string.IsNullOrEmpty(newProfilePrefWidthTextBox.Text) || string.IsNullOrEmpty(newProfilePrefHeightTextBox.Text))
        {
            MessageBox.Show(Resources.FULNP_saveButton_invalidWidthAndHeight, Resources.FULNP_saveButton_invalidWidthAndHeight_caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!newProfilePrefWidthTextBox.Text.All(char.IsDigit))
        {
            MessageBox.Show(Resources.FULNP_saveButton_invalidWidth, Resources.FULNP_saveButton_invalidWidth_caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!newProfilePrefHeightTextBox.Text.All(char.IsDigit))
        {
            MessageBox.Show(Resources.FULNP_saveButton_invalidHeight, Resources.FULNP_saveButton_invalidHeight_caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Profile profile = new Profile()
        {
            Name = Regex.Replace(newProfileNameTextBox.Text, @"[^\w\d]", string.Empty),
            Width = int.Parse(newProfilePrefWidthTextBox.Text),
            Height = int.Parse(newProfilePrefHeightTextBox.Text),
            IsFullScreen = newProfileFullscreenCheckBox.Checked,
        };

        FlyffUniverseLauncher.SaveProfile(profile);
        Program.launcher.SetCurrentProfile(profile);
        Program.launcher.ReloadComboBoxes();
        MessageBox.Show(Resources.FULNP_saveButton_success, Resources.FULNP_saveButton_success_caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        Dispose();
    }

    private void newProfileAdaptScreenSizeButton_Click(object sender, EventArgs e)
    {
        newProfilePrefWidthTextBox.Text = Screen.FromControl(this).Bounds.Width.ToString();
        newProfilePrefHeightTextBox.Text = Screen.FromControl(this).Bounds.Height.ToString();
    }
    
    private void UpdateAllLabelsLanguage()
    {
        newProfileNameLabel.Text = Resources.FUL_manageProfiles_profileNameLabel;
        newProfilePrefWidthLabel.Text = Resources.FUL_manageProfiles_preferredWidthLabel;
        newProfileTooltip.SetToolTip(newProfilePrefWidthLabel, Resources.FULNP_preferredWidthLabel_tooltip);
        newProfilePrefHeightLabel.Text = Resources.FUL_manageProfiles_preferredHeightLabel;
        newProfileTooltip.SetToolTip(newProfilePrefHeightLabel, Resources.FULNP_preferredHeightLabel_tooltip);
        newProfileFullscreenCheckBox.Text = Resources.FUL_manageProfiles_fullscreenLabel;
        newProfileTooltip.SetToolTip(newProfileFullscreenCheckBox, Resources.FULNP_fullscreenLabel_tooltip);
        newProfileAdaptScreenSizeButton.Text = Resources.FUL_manageProfiles_adaptToScreenSizeButton;
        newProfileTooltip.SetToolTip(newProfileAdaptScreenSizeButton, Resources.FULNP_adaptScreenSize_tooltip);
        newProfileSaveButton.Text = Resources.FULNP_saveButton;
    }
}

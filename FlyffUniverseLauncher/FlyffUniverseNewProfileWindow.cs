using System.Text.RegularExpressions;
using FlyffUniverseLauncher.Classes;

namespace FlyffUniverseLauncher;

public partial class FlyffUniverseNewProfileWindow : Form
{
    public FlyffUniverseNewProfileWindow()
    {
        InitializeComponent();
        Text = "Flyff Universe Launcher - " + Program.CurrentVersion + " - New profile";
        StartPosition = Program.launcher.StartPosition;
        Location = Program.launcher.Location;
        Program.launcher.Hide();
        Show();
        Focus();
    }

    private void newProfileSaveButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(newProfileNameTextBox.Text))
        {
            ShowMessageToUser(MessageBoxIcon.Warning, "Profile name missing", "Please enter a name for the new profile");
            return;
        }

        if (string.IsNullOrEmpty(newProfilePrefWidthTextBox.Text) || string.IsNullOrEmpty(newProfilePrefHeightTextBox.Text))
        {
            ShowMessageToUser(MessageBoxIcon.Warning, "Window width or height missing", "Please enter a valid window width or height for the new profile.\nIf you're not sure, press the \"Adapt to screen size\" button");
            return;
        }

        if (!newProfilePrefWidthTextBox.Text.All(char.IsDigit))
        {
            ShowMessageToUser(MessageBoxIcon.Error, "Invalid width", "Please enter a valid number for the width");
            return;
        }

        if (!newProfilePrefHeightTextBox.Text.All(char.IsDigit))
        {
            ShowMessageToUser(MessageBoxIcon.Error, "Invalid height", "Please enter a valid number for the height");
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
        MessageBox.Show("Profile successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        Dispose();
    }

    private void newProfileAdaptScreenSizeButton_Click(object sender, EventArgs e)
    {
        newProfilePrefWidthTextBox.Text = Screen.FromControl(this).Bounds.Width.ToString();
        newProfilePrefHeightTextBox.Text = Screen.FromControl(this).Bounds.Height.ToString();
    }
    private void ShowMessageToUser(MessageBoxIcon icon, string caption, string message)
    {
        MessageBox.Show(message, caption, MessageBoxButtons.OK, icon);
    }
}

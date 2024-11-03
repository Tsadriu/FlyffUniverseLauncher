namespace FlyffUniverseLauncher;

public partial class FlyffUniverseNewProfileWindow : Form
{
    public FlyffUniverseNewProfileWindow()
    {
        InitializeComponent();
        Text = "Flyff Universe Launcher - " + Program.GetVersionAsString() + " - New profile";
        StartPosition = Program.launcher.StartPosition;
        Location = Program.launcher.Location;
        Program.launcher.Hide();
        Show();
        Focus();
    }

    private void newProfileSaveButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(newProfileNameTextBox.Text))
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

    }

    private void SaveCurrentProfile(string user, string selectedWidth, string selectedHeight, bool isFullScreen)
    {
        int userIndex = GetProfileIndex(user);
        bool hasProfile = userIndex != -1;

        if (hasProfile)
        {
            _profilesTable[PreferredWidthColumn].RowList[userIndex] = selectedWidth;
            _profilesTable[PreferredHeightColumn].RowList[userIndex] = selectedHeight;
            _profilesTable[IsFullScreenColumn].RowList[userIndex] = isFullScreen ? "1" : "0";
        }
        else
        {
            _profilesTable[ProfileColumn].AddRow(user);
            _profilesTable[LastLoginColumn].AddRow(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
            _profilesTable[PreferredWidthColumn].AddRow(selectedWidth);
            _profilesTable[PreferredHeightColumn].AddRow(selectedHeight);
            _profilesTable[IsFullScreenColumn].AddRow(isFullScreen ? "1" : "0");
            selectUserInput.Items.Add(user);
        }

        File.WriteAllLines(ProfilesFile, _profilesTable.ToList());
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

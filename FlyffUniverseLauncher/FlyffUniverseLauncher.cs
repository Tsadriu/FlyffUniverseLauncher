using Microsoft.Web.WebView2.Core;
using System.Reflection;
using FlyffUniverseLauncher.Helpers;
using TsadriuUtilities;
using TsadriuUtilities.Csv;
using TsadriuUtilities.Enums.StringHelper;
using TsadriuUtilitiesOld;
using System.Windows.Forms;

namespace FlyffUniverseLauncher
{
    public partial class FlyffUniverseLauncher : Form
    {
        public static readonly string CurrentDirectory = Path.GetPathRoot(Environment.CurrentDirectory) ?? Directory.GetCurrentDirectory();
        public static readonly string ProgramStorage = Path.Combine(CurrentDirectory, "Flyff Universe Launcher");
        public static readonly string ProgramNetworkStorage = Path.Combine(ProgramStorage, "Network Data");
        public static readonly string ProfilesDirectory = Path.Combine(ProgramStorage, "Profile");
        public static readonly string OldProfilesFile = Path.Combine(ProfilesDirectory, "profiles.txt");
        public static readonly string NewProfilesFile = Path.Combine(ProfilesDirectory, "profiles.csv");

        private static ICsvTable _profilesTable = new CsvTable();
        private const string ProfileColumn = "Profile";
        private const string LastLoginColumn = "Last Login";
        private const string PreferredWidthColumn = "Preferred Width";
        private const string PreferredHeightColumn = "Preferred Height";
        private const string IsFullScreenColumn = "Is Full Screen";

        private static int DefaultWidth => 800;
        private static int DefaultHeight => 600;

        public FlyffUniverseLauncher()
        {
            InitializeComponent();
            PickRandomImage();
            AssignUsersToComboBox();
            Text += Program.GetVersionAsString();
            Resize += new EventHandler(ResizeWebView);
        }

        /// <summary>
        /// Sets up and sends a web request to show the news page.
        /// </summary>
        public async Task SetUpUri()
        {
            var name = "FlyffNews".ToLower();
            var directory = Path.Combine(ProgramNetworkStorage, name);
            var webViewEnvironment = await CoreWebView2Environment.CreateAsync(string.Empty, directory);
            await newsWindow.EnsureCoreWebView2Async(webViewEnvironment);
            newsWindow.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
            newsWindow.CoreWebView2.Settings.AreDevToolsEnabled = false;
            newsWindow.Source = new Uri(FlyffUrls.News);
        }

        private void AssignUsersToComboBox()
        {
            if (!Directory.Exists(ProfilesDirectory))
            {
                Directory.CreateDirectory(ProfilesDirectory);
            }

            bool hasSetupData = false;

            // If the old profiles file exists, replace it with the new format
            if (File.Exists(OldProfilesFile))
            {
                _profilesTable = new CsvTable(File.ReadAllText(OldProfilesFile).SplitBy(SplitType.EnvironmentNewLine), ";");
                _profilesTable["Width"].Name = PreferredWidthColumn;
                _profilesTable["Height"].Name = PreferredHeightColumn;
                _profilesTable.AddColumn(IsFullScreenColumn);
                _profilesTable[IsFullScreenColumn].AddRow("0");
                File.Delete(OldProfilesFile);
                File.WriteAllLines(NewProfilesFile, _profilesTable.ToList());
                hasSetupData = true;
            }

            if (File.Exists(NewProfilesFile))
            {
                _profilesTable = new CsvTable(File.ReadAllText(NewProfilesFile).SplitBy(SplitType.EnvironmentNewLine), ";");
                hasSetupData = true;
            }

            if (!hasSetupData)
            {
                _profilesTable = new CsvTable(new CsvColumn(ProfileColumn), new CsvColumn(LastLoginColumn),
                    new CsvColumn(PreferredWidthColumn), new CsvColumn(PreferredHeightColumn),
                    new CsvColumn(IsFullScreenColumn));
            }

            ReloadComboBoxes();
        }

        /// <summary>
        /// Clears both <b><see cref="selectUserInput"/></b> and <b><see cref="manageProfileComboBox"/></b> and reloads the profiles into them.
        /// </summary>
        private void ReloadComboBoxes()
        {
            selectUserInput.Items.Clear();
            manageProfileComboBox.Items.Clear();

            foreach (string? profile in _profilesTable[ProfileColumn].RowList.Where(profile => !string.IsNullOrEmpty(profile)))
            {
                if (profile == null)
                {
                    continue;
                }

                selectUserInput.Items.Add(profile);
                manageProfileComboBox.Items.Add(profile);
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            string currentUser = selectUserInput.Text.ToLower();

            if (string.IsNullOrEmpty(currentUser))
            {
                return;
            }

            int selectedWidth = widthInput.Text.ToInt().ClampValue(DefaultWidth, Screen.FromControl(this).Bounds.Width);
            int selectedHeight = heightInput.Text.ToInt().ClampValue(DefaultHeight, Screen.FromControl(this).Bounds.Height);
            bool isFullScreen = fullScreenCheckBox.Checked;

            SaveCurrentProfile(currentUser, selectedWidth.ToString(), selectedHeight.ToString(), isFullScreen);

            var flyff = new FlyffUniverseWindow(currentUser, selectedWidth, selectedHeight, isFullScreen);
            _ = flyff.LaunchGame();
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

            File.WriteAllLines(NewProfilesFile, _profilesTable.ToList());
        }

        private void ResizeWebView(object? sender, EventArgs e)
        {
            newsWindow.Size = ClientSize - new Size(newsWindow.Location);
        }

        private void newsWindow_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            if (e.Uri.OrContains(StringComparison.OrdinalIgnoreCase, "play", "login"))
            {
                newsWindow.CoreWebView2.Navigate(FlyffUrls.News);
            }
        }

        private void selectUserInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            int profileIndex = GetProfileIndex(selectUserInput.Text);

            if (profileIndex == -1)
            {
                throw new ArgumentOutOfRangeException(nameof(profileIndex), @"Could not determine the index of the selected profile. Has the program been tampered with in runtime?");
            }

            widthInput.Text = _profilesTable[PreferredWidthColumn].RowList[profileIndex];
            heightInput.Text = _profilesTable[PreferredHeightColumn].RowList[profileIndex];
            fullScreenCheckBox.Checked = _profilesTable[IsFullScreenColumn].RowList[profileIndex] == "1";
        }

        private void selectUserInput_TextChanged(object sender, EventArgs e)
        {
            if (GetProfileIndex(selectUserInput.Text) == -1)
            {
                return;
            }

            widthInput.Text = DefaultWidth.ToString();
            heightInput.Text = DefaultHeight.ToString();
            fullScreenCheckBox.Checked = false;
        }

        private void PickRandomImage()
        {
            var listOfImages = new List<Bitmap>
            {
                Properties.Resources.img0,
                Properties.Resources.img1,
                Properties.Resources.img2,
                Properties.Resources.img3,
                Properties.Resources.img4,
                Properties.Resources.img5,
                Properties.Resources.img6,
                Properties.Resources.img7,
                Properties.Resources.img8,
                Properties.Resources.img9,
                Properties.Resources.img10,
                Properties.Resources.img11
            };

            var random = new Random();
            var randomNumber = random.Next(0, listOfImages.Count - 1);

            BackgroundImage = listOfImages[randomNumber];
        }

        private void closeNewsButton_Click(object sender, EventArgs e)
        {
            if (newsWindow.IsDisposed)
            {
                return;
            }

            newsWindow.Dispose();
        }

        private void adaptToScreenSizeButton_Click(object sender, EventArgs e)
        {
            widthInput.Text = Screen.FromControl(this).Bounds.Width.ToString();
            heightInput.Text = Screen.FromControl(this).Bounds.Height.ToString();
        }

        private void manageProfileSaveButton_Click(object sender, EventArgs e)
        {
            int userIndex = GetProfileIndex(manageProfileComboBox.Text);

            _profilesTable[ProfileColumn].RowList[userIndex] = manageProfileNameTextBox.Text.ToLower();
            _profilesTable[PreferredWidthColumn].RowList[userIndex] = manageProfileWidthTextBox.Text;
            _profilesTable[PreferredHeightColumn].RowList[userIndex] = manageProfileHeightTextBox.Text;
            _profilesTable[IsFullScreenColumn].RowList[userIndex] = manageProfileFullscreenCheckBox.Checked ? "1" : "0";

            File.WriteAllLines(NewProfilesFile, _profilesTable.ToList());
            ReloadComboBoxes();
            ResetManageProfileFields();

            // Go back to the launcher tab
            launcherTabControl.SelectedTab = launcherTabControl.TabPages[0];
        }

        private void ResetManageProfileFields()
        {
            manageProfileComboBox.Text = string.Empty;
            manageProfileNameTextBox.Text = string.Empty;
            manageProfileWidthTextBox.Text = string.Empty;
            manageProfileHeightTextBox.Text = string.Empty;
            manageProfileFullscreenCheckBox.Checked = false;
        }

        private void manageProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int userIndex = GetProfileIndex(manageProfileComboBox.Text);

            if (userIndex == -1)
            {
                throw new ArgumentOutOfRangeException(nameof(userIndex), @"Could not determine the index of the selected profile. Has the program been tampered with in runtime?");
            }

            manageProfileNameTextBox.Text = _profilesTable[ProfileColumn].RowList[userIndex]?.ToLower();
            manageProfileWidthTextBox.Text = _profilesTable[PreferredWidthColumn].RowList[userIndex];
            manageProfileHeightTextBox.Text = _profilesTable[PreferredHeightColumn].RowList[userIndex];
            manageProfileFullscreenCheckBox.Checked = _profilesTable[IsFullScreenColumn].RowList[userIndex] == "1";
        }

        private void manageProfileDeleteButton_Click(object sender, EventArgs e)
        {
            string manageProfileSelectedUser = manageProfileComboBox.Text;
            if (string.IsNullOrEmpty(manageProfileSelectedUser))
            {
                return;
            }

            int userIndex = GetProfileIndex(manageProfileSelectedUser);

            if (userIndex == -1)
            {
                return;
            }

            for (int i = 0; i < _profilesTable.ColumnList.Count; i++)
            {
                _profilesTable[i].RowList.RemoveAt(userIndex);
            }

            File.WriteAllLines(ProfilesDirectory, _profilesTable.ToList());

            ResetManageProfileFields();
            ReloadComboBoxes();
        }

        private void manageProfileDeleteAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _profilesTable.ColumnList.Count; i++)
            {
                _profilesTable[i].RowList.Clear();
            }

            File.WriteAllLines(ProfilesDirectory, _profilesTable.ToList());

            ResetManageProfileFields();
            ReloadComboBoxes();
            launcherTabControl.SelectedTab = launcherTabControl.TabPages[0];
        }

        private int GetProfileIndex(string profile)
        {
            return _profilesTable[ProfileColumn].RowList.FindIndex(x => x != null && x.Equals(profile, StringComparison.OrdinalIgnoreCase));
        }

        private void manageProfileAdaptToScreenSize_Click(object sender, EventArgs e)
        {
            string manageProfileSelectedUser = manageProfileComboBox.Text;
            if (string.IsNullOrEmpty(manageProfileSelectedUser))
            {
                return;
            }

            manageProfileWidthTextBox.Text = Screen.FromControl(this).Bounds.Width.ToString();
            manageProfileHeightTextBox.Text = Screen.FromControl(this).Bounds.Height.ToString();
        }
    }
}
using Microsoft.Web.WebView2.Core;
using System.Reflection;
using System.Text.RegularExpressions;
using FlyffUniverseLauncher.Helpers;
using TsadriuUtilities;
using TsadriuUtilities.Csv;
using TsadriuUtilities.Enums.StringHelper;
using TsadriuUtilitiesOld;
using System.Windows.Forms;
using FlyffUniverseLauncher.Classes;

namespace FlyffUniverseLauncher
{
    public partial class FlyffUniverseLauncher : Form
    {
        public static readonly string CurrentDirectory = Path.GetPathRoot(Environment.CurrentDirectory) ?? Directory.GetCurrentDirectory();
        public static readonly string ProgramStorage = Path.Combine(CurrentDirectory, "Flyff Universe Launcher");
        public static readonly string ProgramNetworkStorage = Path.Combine(ProgramStorage, "Network Data");
        public static readonly string ProfilesDirectory = Path.Combine(ProgramStorage, "Profile");
        public static readonly string OldProfilesFile = Path.Combine(ProfilesDirectory, "profiles.txt");
        public static readonly string ProfilesFile = Path.Combine(ProfilesDirectory, "profiles.csv");

        private static ICsvTable _profilesTable = new CsvTable();
        private const string ProfileColumn = "Profile";
        private const string LastLoginColumn = "Last Login";
        private const string PreferredWidthColumn = "Preferred Width";
        private const string PreferredHeightColumn = "Preferred Height";
        private const string IsFullScreenColumn = "Is Full Screen";

        private static Profile _selectedProfile = null!;
        private static List<Profile> _profiles = new List<Profile>();

        public FlyffUniverseLauncher()
        {
            InitializeComponent();
            PickRandomImage();
            AssignUsersToComboBox();
            Text += Program.CurrentVersion;
        }


        public static void SaveProfile(Profile profile)
        {
            _profilesTable[ProfileColumn].AddRow(profile.Name);
            _profilesTable[LastLoginColumn].AddRow($"{DateTime.Now:dd/MM/yyyy HH:mm:ss}");
            _profilesTable[PreferredWidthColumn].AddRow(profile.Width.ToString());
            _profilesTable[PreferredHeightColumn].AddRow(profile.Height.ToString());
            _profilesTable[IsFullScreenColumn].AddRow(profile.IsFullScreen ? "1" : "0");
            File.WriteAllLines(ProfilesFile, _profilesTable.ToList());

            _profiles.Add(profile);
        }

        public void SetCurrentProfile(Profile profile)
        {
            _selectedProfile = profile;
            selectUserInput.Text = profile.Name;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            string currentUser = selectUserInput.Text.ToLower();

            if (string.IsNullOrEmpty(currentUser))
            {
                return;
            }

            var flyff = new FlyffUniverseWindow(_selectedProfile);
            _ = flyff.LaunchGame();
        }

        private void selectUserInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            Profile? profileToSearch = _profiles.Find(x => x.Name.Equals(selectUserInput.Text, StringComparison.CurrentCultureIgnoreCase));

            if (profileToSearch == null)
            {
                MessageBox.Show("That profile does not exist. Please select a different one.", "Profile doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _selectedProfile = null!;
                selectUserInput.Text = string.Empty;
                return;
            }

            _selectedProfile = profileToSearch;
        }

        private void selectUserInput_TextChanged(object sender, EventArgs e)
        {
            if (GetProfileIndex(selectUserInput.Text) == -1)
            {
                return;
            }

            Profile? profileToSearch = _profiles.Find(x => x.Name.Equals(selectUserInput.Text, StringComparison.CurrentCultureIgnoreCase));

            if (profileToSearch == null)
            {
                MessageBox.Show("That profile does not exist. Please select a different one.", "Profile doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _selectedProfile = null!;
                selectUserInput.Text = string.Empty;
                return;
            }
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

        private void manageProfileSaveButton_Click(object sender, EventArgs e)
        {
            int userIndex = GetProfileIndex(manageProfileComboBox.Text);

            if (userIndex == -1)
            {
                return;
            }

            var oldProfileName = Regex.Replace(manageProfileComboBox.Text, @"[^\w\d]", string.Empty);
            var newProfileName = Regex.Replace(manageProfileNameTextBox.Text.ToLower(), @"[^\w\d]", string.Empty);
            _profilesTable[ProfileColumn].RowList[userIndex] = newProfileName;
            _profilesTable[PreferredWidthColumn].RowList[userIndex] = manageProfileWidthTextBox.Text;
            _profilesTable[PreferredHeightColumn].RowList[userIndex] = manageProfileHeightTextBox.Text;
            _profilesTable[IsFullScreenColumn].RowList[userIndex] = manageProfileFullscreenCheckBox.Checked ? "1" : "0";

            File.WriteAllLines(ProfilesFile, _profilesTable.ToList());

            Directory.Move(Path.Combine(ProgramNetworkStorage, oldProfileName), Path.Combine(ProgramNetworkStorage, newProfileName));

            var newProfile = new Profile()
            {
                Name = newProfileName,
                Width = manageProfileWidthTextBox.Text.ToInt(),
                Height = manageProfileHeightTextBox.Text.ToInt(),
                IsFullScreen = manageProfileFullscreenCheckBox.Checked,
            };

            AssignUsersToComboBox();
            _selectedProfile = newProfile;
            selectUserInput.Text = newProfile.Name;
            ResetManageProfileFields();

            MessageBox.Show("Profile changes saved succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Go back to the launcher tab
            launcherTabControl.SelectedTab = launcherTabControl.TabPages[0];

        }

        private void manageProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int userIndex = GetProfileIndex(manageProfileComboBox.Text);

            if (userIndex == -1)
            {
                return;
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

            File.WriteAllLines(ProfilesFile, _profilesTable.ToList());

            DeleteNetworkData(manageProfileSelectedUser);
            ResetManageProfileFields();
            AssignUsersToComboBox();
        }

        private void manageProfileDeleteAllButton_Click(object sender, EventArgs e)
        {
            var foldersToDelete = Directory.GetDirectories(ProgramNetworkStorage).Where(x => !x.Contains("flyffwiki") && !x.Contains("flyffnews"));

            foreach (var folder in foldersToDelete)
            {
                Directory.Delete(folder, true);
            }

            for (int i = 0; i < _profilesTable.ColumnList.Count; i++)
            {
                _profilesTable[i].RowList.Clear();
            }

            File.WriteAllLines(ProfilesFile, _profilesTable.ToList());
            ResetManageProfileFields();
            AssignUsersToComboBox();
            launcherTabControl.SelectedTab = launcherTabControl.TabPages[0];
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

        /// <summary>
        /// Resets the fields related to profile management to their default state.
        /// </summary>
        /// <remarks>
        /// This method clears the text boxes for profile name, profile width, profile height, 
        /// and unchecks the fullscreen checkbox in the profile management section of the Flyff Universe Launcher.
        /// </remarks>
        private void ResetManageProfileFields()
        {
            manageProfileComboBox.Text = string.Empty;
            manageProfileNameTextBox.Text = string.Empty;
            manageProfileWidthTextBox.Text = string.Empty;
            manageProfileHeightTextBox.Text = string.Empty;
            manageProfileFullscreenCheckBox.Checked = false;
        }

        private void DeleteNetworkData(string username)
        {
            var networkDataToDelete = Path.Combine(ProgramNetworkStorage, username);

            if (Directory.Exists(networkDataToDelete))
            {
                Directory.Delete(networkDataToDelete, true);
            }
        }

        private int GetProfileIndex(string profile)
        {
            return _profilesTable[ProfileColumn].RowList.FindIndex(x => x != null && x.Equals(profile, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Initializes and assigns user profiles to the ComboBox controls. 
        /// If the old profiles file exists, it converts the data to a new format, deletes the old file, and creates a new profiles file. 
        /// If no profile data is found, it creates a new profiles table with default columns.
        /// </summary>
        /// <remarks>
        /// The method ensures that the profiles directory exists and checks if there is any setup data available in the old or new profiles files. 
        /// If old data is present in the old profiles file, it is converted and saved in the new profiles file format.
        /// After setting up the profiles table, the <see cref="ReloadComboBoxes"/> method is called to reload the ComboBoxes with the updated profiles.
        /// </remarks>
        private void AssignUsersToComboBox()
        {
            if (!Directory.Exists(ProfilesDirectory))
            {
                Directory.CreateDirectory(ProfilesDirectory);
            }

            _profiles.Clear();
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
                File.WriteAllLines(ProfilesFile, _profilesTable.ToList());
                hasSetupData = true;
            }

            if (File.Exists(ProfilesFile))
            {
                _profilesTable = new CsvTable(File.ReadAllText(ProfilesFile).SplitBy(SplitType.EnvironmentNewLine), ";");
                hasSetupData = true;
            }

            if (!hasSetupData)
            {
                _profilesTable = new CsvTable(new CsvColumn(ProfileColumn), new CsvColumn(LastLoginColumn),
                    new CsvColumn(PreferredWidthColumn), new CsvColumn(PreferredHeightColumn),
                    new CsvColumn(IsFullScreenColumn));

                return;
            }

            for (int i = 0; i < _profilesTable[ProfileColumn].RowCount; i++)
            {
                var profile = new Profile
                {
                    Name = _profilesTable[ProfileColumn].RowList[i]!,
                    LastLogin = _profilesTable[LastLoginColumn].RowList[i].ToDateTime("dd/MM/yyyy HH:mm:ss"),
                    Width = _profilesTable[PreferredWidthColumn].RowList[i].ToInt(),
                    Height = _profilesTable[PreferredHeightColumn].RowList[i].ToInt(),
                    IsFullScreen = _profilesTable[IsFullScreenColumn].RowList[i] == "1",
                };

                _profiles.Add(profile);
            }

            ReloadComboBoxes();
        }

        /// <summary>
        /// Clears both <b><see cref="selectUserInput"/></b> and <b><see cref="manageProfileComboBox"/></b> and reloads the profiles into them.
        /// </summary>
        public void ReloadComboBoxes()
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

        /// <summary>
        /// Handles the click event of the createNewProfileButton.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void createNewProfileButton_Click(object sender, EventArgs e)
        {
            _ = new FlyffUniverseNewProfileWindow();
        }
    }
}
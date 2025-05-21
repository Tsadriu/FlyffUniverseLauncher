using System.Globalization;
using System.Text.Json;
using System.Text.RegularExpressions;
using FlyffUniverseLauncher.Helpers;
using TsadriuUtilities;
using TsadriuUtilities.Csv;
using TsadriuUtilities.Enums.StringHelper;
using TsadriuUtilitiesOld;
using FlyffUniverseLauncher.Classes;
using FlyffUniverseLauncher.Classes.Json;
using FlyffUniverseLauncher.Properties;

namespace FlyffUniverseLauncher
{
    public sealed partial class FlyffUniverseLauncher : Form
    {
        private static ICsvTable _profilesTable = new CsvTable();
        private const string ProfileColumn = "Profile";
        private const string LastLoginColumn = "Last Login";
        private const string PreferredWidthColumn = "Preferred Width";
        private const string PreferredHeightColumn = "Preferred Height";
        private const string IsFullScreenColumn = "Is Full Screen";

        private static Profile _selectedProfile = null!;
        private static List<Profile> _profiles = [];

        public FlyffUniverseLauncher()
        {
            InitializeComponent();
            PickRandomImage();
            AssignUsersToComboBox();
            Text += Program.CurrentVersion;
            ManageProfileHelpers.Setup(_profilesTable);
            LoadLauncherProperties();
        }

        public static void SaveProfile(Profile profile)
        {
            _profilesTable[ProfileColumn].AddRow(profile.Name);
            _profilesTable[LastLoginColumn].AddRow($"{DateTime.Now:dd/MM/yyyy HH:mm:ss}");
            _profilesTable[PreferredWidthColumn].AddRow(profile.Width.ToString());
            _profilesTable[PreferredHeightColumn].AddRow(profile.Height.ToString());
            _profilesTable[IsFullScreenColumn].AddRow(profile.IsFullScreen ? "1" : "0");
            File.WriteAllLines(FlyffUniverseConstants.Directory.ProfilesFile, _profilesTable.ToList());

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
                MessageBox.Show(Resources.FUL_playButton_no_profile_selected, Resources.FUL_playButton_no_profile_selected_caption, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (!_profiles.Any(x => x.Name.Equals(currentUser, StringComparison.CurrentCultureIgnoreCase)))
            {
                MessageBox.Show(Resources.FUL_playButton_selected_profile_does_not_exist, Resources.FUL_playButton_selected_profile_does_not_exist_caption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(Resources.FUL_selectUserInput_profileDoesNotExist, Resources.FUL_selectUserInput_profileDoesNotExist_caption, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
                MessageBox.Show(Resources.FUL_selectUserInput_profileDoesNotExist, Resources.FUL_profileSettingsLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
                _selectedProfile = null!;
                selectUserInput.Text = string.Empty;
            }
        }

        private void PickRandomImage()
        {
            var listOfImages = new List<Bitmap>
            {
                Resources.img0,
                Resources.img1,
                Resources.img2,
                Resources.img3,
                Resources.img4,
                Resources.img5,
                Resources.img6,
                Resources.img7,
                Resources.img8,
                Resources.img9,
                Resources.img10,
                Resources.img11,
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
                MessageBox.Show(Resources.FUL_selectUserInput_profileDoesNotExist, Resources.FUL_selectUserInput_profileDoesNotExist_caption, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var doesNewUsernameExist = ManageProfileHelpers.DoesProfileToOverrideExist(manageProfileNameTextBox.Text);
            var areProfileNamesEqual = ManageProfileHelpers.AreProfileNamesEqual(manageProfileComboBox.Text, manageProfileNameTextBox.Text);

            if (doesNewUsernameExist && !areProfileNamesEqual)
            {
                MessageBox.Show(Resources.FUL_manageProfileSaveButton_profileAlreadyExists, Resources.FUL_manageProfileSaveButton_profileAlreadyExists_caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var oldProfileName = Regex.Replace(manageProfileComboBox.Text, @"[^\w\d]", string.Empty);
            var newProfileName = Regex.Replace(manageProfileNameTextBox.Text.ToLower(), @"[^\w\d]", string.Empty);

            var oldDirectory = Path.Combine(FlyffUniverseConstants.Directory.ProgramNetworkStorage, oldProfileName);
            var newDirectory = Path.Combine(FlyffUniverseConstants.Directory.ProgramNetworkStorage, newProfileName);

            if (!Directory.Exists(oldDirectory))
            {
                MessageBox.Show(Resources.FUL_manageProfileSaveButton_oldProfile_doesNotExist, Resources.FUL_manageProfileSaveButton_oldProfile_doesNotExist_caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                Directory.CreateDirectory(newDirectory);
            }
            else
            {
                if (!doesNewUsernameExist || !areProfileNamesEqual)
                {
                    Directory.Move(oldDirectory, newDirectory);
                }
            }

            _profilesTable[ProfileColumn].RowList[userIndex] = newProfileName;
            _profilesTable[PreferredWidthColumn].RowList[userIndex] = manageProfileWidthTextBox.Text;
            _profilesTable[PreferredHeightColumn].RowList[userIndex] = manageProfileHeightTextBox.Text;
            _profilesTable[IsFullScreenColumn].RowList[userIndex] = manageProfileFullscreenCheckBox.Checked ? "1" : "0";

            File.WriteAllLines(FlyffUniverseConstants.Directory.ProfilesFile, _profilesTable.ToList());

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

            MessageBox.Show(Resources.FUL_manageProfileSaveButton_success, Resources.FUL_manageProfileSaveButton_success_caption, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
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

            var message = Resources.FUL_manageProfile_deleteProfileButton_confirmation.Replace("$USERNAME$", manageProfileSelectedUser);
            var caption = Resources.FUL_manageProfile_deleteProfileButton_confirmation_caption.Replace("$USERNAME$", manageProfileSelectedUser);

            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            for (int i = 0; i < _profilesTable.ColumnList.Count; i++)
            {
                _profilesTable[i].RowList.RemoveAt(userIndex);
            }

            File.WriteAllLines(FlyffUniverseConstants.Directory.ProfilesFile, _profilesTable.ToList());

            DeleteNetworkData(manageProfileSelectedUser);
            ResetManageProfileFields();
            AssignUsersToComboBox();
        }

        private void manageProfileDeleteAllButton_Click(object sender, EventArgs e)
        {
            if (_profilesTable[ProfileColumn].ContainsEmptyRows)
            {
                return;
            }

            DialogResult result = MessageBox.Show(Resources.FUL_manageProfile_deleteAllProfilesButton_confirmation,
                Resources.FUL_manageProfile_deleteAllProfilesButton_confirmation_caption, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            // Delete all profiles from the local profile file
            for (int i = 0; i < _profilesTable.ColumnList.Count; i++)
            {
                _profilesTable[i].RowList.Clear();
            }

            // Delete all folders (if there is any)
            if (Directory.Exists(FlyffUniverseConstants.Directory.ProgramNetworkStorage))
            {
                var foldersToDelete = Directory.GetDirectories(FlyffUniverseConstants.Directory.ProgramNetworkStorage)
                    .Where(x => !x.Contains("flyffwiki") && !x.Contains("flyffnews")).ToList();

                if (foldersToDelete.Count == 0)
                {
                    return;
                }

                foreach (var folder in foldersToDelete)
                {
                    Directory.Delete(folder, true);
                }
            }

            File.WriteAllLines(FlyffUniverseConstants.Directory.ProfilesFile, _profilesTable.ToList());
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

        /// <summary>
        /// Deletes the network data associated with the specified username from the program's storage.
        /// </summary>
        /// <param name="username">The username whose network data should be deleted.</param>
        private void DeleteNetworkData(string username)
        {
            var networkDataToDelete = Path.Combine(FlyffUniverseConstants.Directory.ProgramNetworkStorage, username);

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
            if (!Directory.Exists(FlyffUniverseConstants.Directory.ProfilesDirectory))
            {
                Directory.CreateDirectory(FlyffUniverseConstants.Directory.ProfilesDirectory);
            }

            _profiles.Clear();
            bool hasSetupData = false;

            // If the old profiles file exists, replace it with the new format
            if (File.Exists(FlyffUniverseConstants.Directory.OldProfilesFile))
            {
                _profilesTable = new CsvTable(File.ReadAllText(FlyffUniverseConstants.Directory.OldProfilesFile).SplitBy(SplitType.EnvironmentNewLine), ";");
                _profilesTable["Width"].Name = PreferredWidthColumn;
                _profilesTable["Height"].Name = PreferredHeightColumn;
                _profilesTable.AddColumn(IsFullScreenColumn);
                _profilesTable[IsFullScreenColumn].AddRow("0");
                File.Delete(FlyffUniverseConstants.Directory.OldProfilesFile);
                File.WriteAllLines(FlyffUniverseConstants.Directory.ProfilesFile, _profilesTable.ToList());
                hasSetupData = true;
            }

            if (File.Exists(FlyffUniverseConstants.Directory.ProfilesFile))
            {
                _profilesTable = new CsvTable(File.ReadAllText(FlyffUniverseConstants.Directory.ProfilesFile).SplitBy(SplitType.EnvironmentNewLine), ";");
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
                    LastLogin = _profilesTable[LastLoginColumn].RowList[i].ToDateTime("dd/MM/yyyy HH:mm:ss", "dd.MM.yyyy HH:mm:ss"),
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
            _ = new FlyffUniverseNewProfile();
        }

        private void ful__Language_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCulture = ful_language_comboBox.SelectedItem?.ToString() switch
            {
                "English" => FlyffUniverseConstants.Language.English,
                "Italiano" => FlyffUniverseConstants.Language.Italian,
                "Deutsch" => FlyffUniverseConstants.Language.German,
                _ => FlyffUniverseConstants.Language.English,
            };

            Resources.Culture = CultureInfo.GetCultureInfoByIetfLanguageTag(selectedCulture);
            UpdateAllLabelsLanguage();
            UpdateLauncherLanguageProperties(selectedCulture);
        }

        private void UpdateAllLabelsLanguage()
        {
            // Profile Settings tab
            profileSettingsTab.Text = Resources.FUL_profileSettingsLabel;
            manageProfilesTab.Text = Resources.FUL_manageProfilesLabel;
            selectUserLabel.Text = Resources.FUL_selectUserLabel;
            playButton.Text = Resources.FUL_playButton;
            createNewProfileButton.Text = Resources.FUL_createNewProfileButton;
            ful_language_label.Text = Resources.FUL_language_label;
            ful_credit_label.Text = Resources.FUL_credit_label;

            // Manage Profiles tab
            selectProfileToModifyLabel.Text = Resources.FUL_manageProfiles_selectProfileToModifyLabel;
            manageProfiles_profileNameLabel.Text = Resources.FUL_manageProfiles_profileNameLabel;
            manageProfiles_preferredWidthLabel.Text = Resources.FUL_manageProfiles_preferredWidthLabel;
            manageProfiles_preferredHeightLabel.Text = Resources.FUL_manageProfiles_preferredHeightLabel;
            manageProfileFullscreenCheckBox.Text = Resources.FUL_manageProfiles_fullscreenLabel;
            manageProfileAdaptToScreenSize.Text = Resources.FUL_manageProfiles_adaptToScreenSizeButton;
            manageProfileSaveButton.Text = Resources.FUL_manageProfiles_saveChangesButton;
            manageProfileDeleteButton.Text = Resources.FUL_manageProfiles_deleteProfileButton;
            manageProfileDeleteAllButton.Text = Resources.FUL_manageProfiles_deleteAllProfilesButton;
        }

        private void LoadLauncherProperties()
        {
            if (!Directory.Exists(FlyffUniverseConstants.Directory.ProgramStorage))
            {
                Directory.CreateDirectory(FlyffUniverseConstants.Directory.ProgramStorage);
            }

            LauncherPropertiesJson launcherProperties = new LauncherPropertiesJson();

            if (File.Exists(FlyffUniverseConstants.Directory.LauncherFile))
            {
                var fileContent = File.ReadAllText(FlyffUniverseConstants.Directory.LauncherFile);
                try
                {
                    launcherProperties = JsonSerializer.Deserialize<LauncherPropertiesJson>(fileContent)!;
                }
                catch (Exception exception)
                {
                    string fileName = $"{DateTime.Now:yyyy_MM_dd_HH_mm_ss}_launcher_error.log";
                    string description = Resources.FUL_launcherPropertiesJson_error.Replace("$LOCATION$",
                        Path.Combine(FlyffUniverseConstants.Directory.LogStorage, FlyffUniverseConstants.Directory.LauncherFile));
                    MessageBox.Show(description, Resources.FUL_launcherPropertiesJson_error_caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    string errorMessage = "Could not deserialize the JSON launcher properties! File content: " + fileContent + " - Exception: " + exception;
                    File.WriteAllText(Path.Combine(FlyffUniverseConstants.Directory.LogStorage, fileName), errorMessage);
                }
            }

            ful_language_comboBox.SelectedIndex = launcherProperties.Language switch
            {
                FlyffUniverseConstants.Language.English => 0,
                FlyffUniverseConstants.Language.Italian => 1,
                FlyffUniverseConstants.Language.German => 2,
                _ => 0,
            };

            UpdateLauncherLanguageProperties(launcherProperties.Language);
            UpdateAllLabelsLanguage();
        }

        /// <summary>
        /// Updates the launcher language properties by saving the specified culture code
        /// into the launcher configuration file.
        /// </summary>
        /// <param name="selectedCultureCode">The culture code representing the chosen language (e.g., "en-us").</param>
        /// <remarks>
        /// This method reads the current launcher configuration file, updates the language property
        /// with the provided culture code, and writes the changes back to the file. If the configuration
        /// file does not exist, it creates a new configuration file in the designated program storage directory.
        /// </remarks>
        private void UpdateLauncherLanguageProperties(string selectedCultureCode)
        {
            if (!Directory.Exists(FlyffUniverseConstants.Directory.ProgramStorage))
            {
                Directory.CreateDirectory(FlyffUniverseConstants.Directory.ProgramStorage);
            }

            LauncherPropertiesJson launcherProperties = new LauncherPropertiesJson();

            if (File.Exists(FlyffUniverseConstants.Directory.LauncherFile))
            {
                var fileContent = File.ReadAllText(FlyffUniverseConstants.Directory.LauncherFile);
                try
                {
                    launcherProperties = JsonSerializer.Deserialize<LauncherPropertiesJson>(fileContent)!;
                }
                catch (Exception exception)
                {
                    string fileName = $"{DateTime.Now:yyyy_MM_dd_HH_mm_ss}_update_launcher_error.log";
                    string description = Resources.FUL_launcherPropertiesJson_error.Replace("$LOCATION$",
                        Path.Combine(FlyffUniverseConstants.Directory.LogStorage, FlyffUniverseConstants.Directory.LauncherFile));
                    MessageBox.Show(description, Resources.FUL_launcherPropertiesJson_error_caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    string errorMessage = "Could not deserialize the JSON launcher properties during the update! File content: " + fileContent + " - Exception: " +
                                          exception;
                    File.WriteAllText(Path.Combine(FlyffUniverseConstants.Directory.LogStorage, fileName), errorMessage);
                }
            }

            if (launcherProperties.Language.Equals(selectedCultureCode, StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            launcherProperties.Language = selectedCultureCode;
            File.WriteAllText(FlyffUniverseConstants.Directory.LauncherFile, JsonSerializer.Serialize(launcherProperties));
        }
    }
}
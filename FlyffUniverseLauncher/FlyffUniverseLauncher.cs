using Microsoft.Web.WebView2.Core;
using System.Reflection;
using TsadriuUtilities;

namespace FlyffUniverseLauncher
{
    public partial class FlyffUniverseLauncher : Form
    {
        public static readonly string CurrentDirectory = Path.GetPathRoot(Environment.CurrentDirectory) ?? Directory.GetCurrentDirectory();
        public static readonly string ProgramStorage = Path.Combine(CurrentDirectory, "Flyff Universe Launcher");
        public static readonly string ProgramNetworkStorage = Path.Combine(ProgramStorage, "Network Data");
        public static readonly string ProfilesDirectory = Path.Combine(ProgramStorage, "Profile");
        public static readonly string ProfilesFile = Path.Combine(ProfilesDirectory, "profiles.txt");
        public static readonly string newsLink = "https://universe.flyff.com/news";
        public static readonly int defaultWidth = 800;
        public static readonly int defaultHeight = 600;
        public static TTable usersInFile = new TTable();

        public FlyffUniverseLauncher()
        {
            InitializeComponent();
            PickRandomImage();
            AssignUsers();
            Text += Program.GetVersionAsString();
            SetUpUri();
            Resize += new EventHandler(ResizeWebView);
        }

        /// <summary>
        /// Sets up and sends a web request to show the news page.
        /// </summary>
        public async void SetUpUri()
        {
            var name = "FlyffNews".ToLower();
            var directory = Path.Combine(ProgramNetworkStorage, name);
            var webViewEnvironment = await CoreWebView2Environment.CreateAsync(string.Empty, directory);
            await newsWindow.EnsureCoreWebView2Async(webViewEnvironment);
            newsWindow.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
            newsWindow.CoreWebView2.Settings.AreDevToolsEnabled = false;
            newsWindow.Source = new Uri(newsLink);
        }

        private void AssignUsers()
        {
            if (!Directory.Exists(ProfilesDirectory))
            {
                Directory.CreateDirectory(ProfilesDirectory);
            }

            if (!File.Exists(ProfilesFile))
            {
                usersInFile.AddColumn("Profile", "Last Login", "Width", "Height");
                return;
            }

            usersInFile.CsvToTable(ProfilesFile);

            if (usersInFile.GetColumn("User") != null)
            {
                usersInFile.RenameColumn("User", "Profile");
            }

            selectUserInput.Items.AddRange(usersInFile.GetData("Profile").ToArray());
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            string currentUser = selectUserInput.Text;

            if (currentUser.IsNotEmpty())
            {
                currentUser = currentUser.ToLower();
                SaveCurrentUser(currentUser);
                var selectedWidth = widthInput.Text.ToInt().ClampValue(defaultWidth, Screen.FromControl(this).Bounds.Width);
                var selectedHeight = heightInput.Text.ToInt().ClampValue(defaultHeight, Screen.FromControl(this).Bounds.Height);

                var flyff = new FlyffUniverseWindow(currentUser, selectedWidth, selectedHeight);
                flyff.Show();
            }
        }

        private void SaveCurrentUser(string user)
        {
            if (!usersInFile.ExistsData("Profile", user))
            {
                usersInFile.AddData("Profile", user.ToLower());
                usersInFile.AddData("Last Login", DateTime.Now);
                usersInFile.AddData("Width", widthInput.Text.IsEmpty() ? defaultWidth : widthInput.Text);
                usersInFile.AddData("Height", heightInput.Text.IsEmpty() ? defaultHeight : heightInput.Text);
                File.WriteAllLines(ProfilesFile, usersInFile.TableToCsv());
                selectUserInput.Items.Clear();
                selectUserInput.Items.AddRange(usersInFile.GetData("Profile").ToArray());
            }
            else
            {
                widthInput.Text = widthInput.Text.IsEmpty() ? defaultWidth.ToString() : widthInput.Text;
                heightInput.Text = heightInput.Text.IsEmpty() ? defaultHeight.ToString() : heightInput.Text;

                File.WriteAllLines(ProfilesFile, usersInFile.TableToCsv());
            }
        }

        private void ResizeWebView(object? sender, EventArgs e)
        {
            newsWindow.Size = ClientSize - new Size(newsWindow.Location);
        }

        private void newsWindow_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            if (e.Uri.OrContains(StringComparison.OrdinalIgnoreCase, "play", "login"))
            {
                newsWindow.CoreWebView2.Navigate(newsLink);
            }
        }

        private void selectUserInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            widthInput.Text = usersInFile.GetData("Width")[selectUserInput.SelectedIndex].ToString();
            heightInput.Text = usersInFile.GetData("Height")[selectUserInput.SelectedIndex].ToString();
        }

        private void selectUserInput_TextChanged(object sender, EventArgs e)
        {
            if (!usersInFile.ExistsData("Profile", selectUserInput.Text.ToLower()))
            {
                widthInput.Text = defaultWidth.ToString();
                heightInput.Text = defaultHeight.ToString();
            }
        }

        private void PickRandomImage()
        {
            var listOfImages = new List<Bitmap>();
            listOfImages.Add(Properties.Resources.img0);
            listOfImages.Add(Properties.Resources.img1);
            listOfImages.Add(Properties.Resources.img2);
            listOfImages.Add(Properties.Resources.img3);
            listOfImages.Add(Properties.Resources.img4);
            listOfImages.Add(Properties.Resources.img5);
            listOfImages.Add(Properties.Resources.img6);
            listOfImages.Add(Properties.Resources.img7);
            listOfImages.Add(Properties.Resources.img8);
            listOfImages.Add(Properties.Resources.img9);
            listOfImages.Add(Properties.Resources.img10);
            listOfImages.Add(Properties.Resources.img11);

            var random = new Random();
            var randomNumber = random.Next(0, listOfImages.Count - 1);
            
            BackgroundImage = listOfImages[randomNumber];
        }
    }
}
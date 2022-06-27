using Microsoft.Web.WebView2.Core;
using TsadriuUtilities;

namespace FlyffUniverseLauncher
{
    public partial class FlyffUniverseLauncher : Form
    {
        public static readonly string CurrentDirectory = Directory.GetCurrentDirectory();
        public static readonly string UsersDirectory = Path.Combine(CurrentDirectory, "Users");
        public static readonly string UsersFile = Path.Combine(UsersDirectory, "users.txt");
        public static readonly string newsLink = "https://universe.flyff.com/news";
        public static readonly int defaultWidth = 800;
        public static readonly int defaultHeight = 600;
        public static TTable usersInFile = new TTable();

        public FlyffUniverseLauncher()
        {
            InitializeComponent();
            AssignUsers();
            Text += Program.GetVersionAsString();
            SetUpUri();
            Resize += new EventHandler(ResizeWebView);
        }

        public async void SetUpUri()
        {
            var name = "FlyffNews";
            var directory = Path.Combine(Directory.GetCurrentDirectory(), name);
            var webViewEnvironment = await CoreWebView2Environment.CreateAsync(string.Empty, directory);
            await newsWindow.EnsureCoreWebView2Async(webViewEnvironment);
            newsWindow.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
            newsWindow.CoreWebView2.Settings.AreDevToolsEnabled = false;
            newsWindow.Source = new Uri(newsLink);
        }

        private void AssignUsers()
        {
            if (!Directory.Exists(UsersDirectory))
            {
                Directory.CreateDirectory(UsersDirectory);
            }

            if (!File.Exists(UsersFile))
            {
                usersInFile.AddColumn("User", "Last Login", "Width", "Height");
                return;
            }

            usersInFile.CsvToTable(UsersFile);
            selectUserInput.Items.AddRange(usersInFile.GetData("User").ToArray());
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            string currentUser = selectUserInput.Text;

            if (currentUser.IsNotEmpty())
            {
                currentUser = currentUser.ToLower();
                SaveCurrentUser(currentUser);
                var flyff = new FlyffUniverseWindow(currentUser, widthInput.Text.ToInt(), heightInput.Text.ToInt());
                flyff.Show();
            }
        }

        private void SaveCurrentUser(string user)
        {
            if (!usersInFile.ExistsData("User", user))
            {
                usersInFile.AddData("User", user.ToLower());
                usersInFile.AddData("Last Login", DateTime.Now);
                usersInFile.AddData("Width", widthInput.Text.IsEmpty() ? defaultWidth : widthInput.Text);
                usersInFile.AddData("Height", heightInput.Text.IsEmpty() ? defaultHeight : heightInput.Text);
                File.WriteAllLines(UsersFile, usersInFile.TableToCsv());
                selectUserInput.Items.Clear();
                selectUserInput.Items.AddRange(usersInFile.GetData("User").ToArray());
            }
            else
            {
                widthInput.Text = widthInput.Text.IsEmpty() ? defaultWidth.ToString() : widthInput.Text;
                heightInput.Text = heightInput.Text.IsEmpty() ? defaultHeight.ToString() : heightInput.Text;

                File.WriteAllLines(UsersFile, usersInFile.TableToCsv());
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
            if (!usersInFile.ExistsData("User", selectUserInput.Text.ToLower()))
            {
                widthInput.Text = defaultWidth.ToString();
                heightInput.Text = defaultHeight.ToString();
            }
        }
    }
}
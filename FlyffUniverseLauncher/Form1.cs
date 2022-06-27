using Microsoft.Web.WebView2.Core;
using TsadriuUtilities;

namespace FlyffUniverseLauncher
{
    public partial class Form1 : Form
    {
        public static readonly string CurrentDirectory = Directory.GetCurrentDirectory();
        public static readonly string UsersDirectory = Path.Combine(CurrentDirectory, "Users");
        public static readonly string UsersFile = Path.Combine(UsersDirectory, "users.txt");
        public static TTable usersInFile = new TTable();

        public Form1()
        {
            InitializeComponent();
            AssignUsers();
        }

        private void AssignUsers()
        {
            if (!Directory.Exists(UsersDirectory))
            {
                Directory.CreateDirectory(UsersDirectory);
            }

            if (!File.Exists(UsersFile))
            {
                usersInFile.AddColumn("User", "Last Login");
                return;
            }

            usersInFile.CsvToTable(UsersFile);
            comboBox1.Items.AddRange(usersInFile.GetData("User").ToArray());
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string currentUser = comboBox1.Text;

            if (currentUser.IsNotEmpty())
            {
                currentUser = currentUser.ToLower();
                SaveCurrentUser(currentUser);
                var flyff = new FlyffUniverseWindow(currentUser);
                flyff.Show();
            }
        }

        private void SaveCurrentUser(string user)
        {
            if (!usersInFile.ExistsData("User", user))
            {
                usersInFile.AddData("User", user.ToLower());
                usersInFile.AddData("Last Login", DateTime.Now);
                File.WriteAllLines(UsersFile, usersInFile.TableToCsv());
            }
        }
    }
}
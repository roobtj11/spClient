using System.Security.Cryptography;
using System.Text;
namespace Client_For_SemesterProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Network.Close_Connection();
        }

        private void ConnectToServer_Click(object sender, EventArgs e)
        {
            ConnectToServer.Enabled = false;
            if (!Network.Connect())
            {
                CouldNotConnect.Visible = true;
                ConnectToServer.Enabled = true;
            }
            else
            {
                welcomeANDstandard.SelectedIndex = 1;

            }
        }

        private void GotoCreateNewUser_Click(object sender, EventArgs e)
        {
            welcomeANDstandard.SelectedIndex = 3;
            Network.SendMessage("C");
        }

        private void GotoSignIn_Click(object sender, EventArgs e)
        {
            welcomeANDstandard.SelectedIndex = 2;
            Network.SendMessage("L");
        }
        private void BackToWelcome(object sender, EventArgs e)
        {
            welcomeANDstandard.SelectedIndex = 1;
            SignInPassword.Clear();
            SignInUname.Clear();
            NewUserConfirmPword.Clear();
            NewUserPword.Clear();
            NewUserUname.Clear();
            Network.SendMessage("back");
        }
        static string gethash(string text)
        {
            using (SHA256 mySHA256 = SHA256.Create())
            {
                byte[] bytes = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(text));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            CreateUserButton.Enabled = false;
            string username = NewUserUname.Text;
            string Password = gethash(NewUserPword.Text);
            bool invalid = false;
            NewUserErrorMessage.Text = "";
            if (username.Length <= 3 || username.Length > 12)
            {
                NewUserErrorMessage.Text = "*Username must be 3 or more characters and less than 12\n";
                invalid = true;
            }
            if (username.Contains(','))
            {
                NewUserErrorMessage.Text = NewUserErrorMessage.Text + "* Usernames Cannot Contain Commas\n";
                invalid = true;
            }
            if (NewUserPword.Text.Length < 5 || NewUserPword.Text.Length > 20)
            {
                NewUserErrorMessage.Text = NewUserErrorMessage.Text + "*Passwords must be between 6 and 19 characters\n";
                invalid = true;
            }
            if (!NewUserPword.Text.Contains('1') && !NewUserPword.Text.Contains('2') && !NewUserPword.Text.Contains('3') && !NewUserPword.Text.Contains('4') && !NewUserPword.Text.Contains('5') && !NewUserPword.Text.Contains('6') && !NewUserPword.Text.Contains('7') && !NewUserPword.Text.Contains('8') && !NewUserPword.Text.Contains('9') && !NewUserPword.Text.Contains('0'))
            {
                NewUserErrorMessage.Text = NewUserErrorMessage.Text + "*Passwords must contain a number\n";
                invalid = true;
            }
            if (!NewUserPword.Text.Contains('!') && !NewUserPword.Text.Contains('@') && !NewUserPword.Text.Contains('#') && !NewUserPword.Text.Contains('$') && !NewUserPword.Text.Contains('%') && !NewUserPword.Text.Contains('^') && !NewUserPword.Text.Contains('&') && !NewUserPword.Text.Contains('*') && !NewUserPword.Text.Contains('=') && !NewUserPword.Text.Contains('+'))
            {
                NewUserErrorMessage.Text = NewUserErrorMessage.Text + "*Passwords must contain a symbol\n";
                invalid = true;
            }
            if (Password != gethash(NewUserConfirmPword.Text))
            {
                NewUserErrorMessage.Text = NewUserErrorMessage.Text + "* Passwords do not match\n";
                invalid = true;
            }
            if (invalid)
            {
                CreateUserButton.Enabled = true;
                return;
            }
            Network.SendMessage(username);
            string response = Network.RecieveMessage();
            if (response.Contains("E:1\r"))
            {
                NewUserErrorMessage.Text = "* Username is Already used please try another quit\n";
                invalid = true;
            }
            if (invalid)
            {
                CreateUserButton.Enabled = true;
                return;
            }
            else
            {
                Network.SendMessage(Password);
                NewUserUname.Text = "";
                NewUserPword.Text = "";
                NewUserConfirmPword.Text = "";
                //LoggedIn(1, username);
            }


        }
    }
}
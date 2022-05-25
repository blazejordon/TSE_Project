using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSE
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CreateFile GetPath = new CreateFile();
            string filepath = GetPath.LoginData();
        }
        private bool VerifyLogin(string AttemptUsername, string AttemptEmail, string AttemptPassword)
        {
            CreateFile GetPath = new CreateFile();
            string filepath = GetPath.LoginData(); //Retrieves the file path

            //Retrieves all Login data
            List<List<string>> AllLogins = new List<List<string>>();
            List<string> current = null;
            foreach (var line in File.ReadAllLines(filepath))
            {
                if (line.Contains("UserLoginStart//") && current == null)
                {
                    current = new List<string>();
                }
                else if (line.Contains("//UserLoginEnd") && current != null)
                {
                    AllLogins.Add(current);
                    current = null;
                }
                if (current != null)
                {
                    current.Add(line);
                }
            }

            //Sequetinally goes through all retireved data to find if the username and password are correct and match
            int x = 0;
            int y = 0;
            string EncryptPassword = Encrypt(AttemptPassword);
            foreach (var list in AllLogins)
            {
                foreach (var item in list)
                {
                    if (AllLogins[x][y] == AttemptUsername && AllLogins[x][y + 1] == EncryptPassword && AllLogins[x][y + 2] == AttemptEmail)
                    {
                        return true;
                    }
                    y++;
                }
                y = 0;
                x++;
            }
            return false;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool Verified = false;
            string AttemptUsername = EnterUserName.Text;
            string AttemptEmail = EnterEmail.Text;
            string AttemptPassword = EnterPassword.Text;
            Verified = VerifyLogin(AttemptUsername, AttemptEmail, AttemptPassword); //Checks if eneted login is valid

            if (Verified == true)
            {
                correct();
            }             
            else
            {
                MessageBox.Show("Incorrect Username, Password or Email!", "Error");
            }
        }

        private void correct() //opens the main form.
        {
            MainMenu Menu = new MainMenu();
            Menu.Show();
            this.Hide();
        }

        private string Encrypt(string Password) //Encrypts a password
        {
            Encryption encrypt = new Encryption();
            return encrypt.Encode(Password);
        }

        private string Decrypt(string Password) //Decrypts a password
        {
            Encryption decrypt = new Encryption();
            return decrypt.decode(Password);
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        } //Moves to Register Screen

        private void ForgotPasswordButton_Click(object sender, EventArgs e)
        {
            Forgot_Password Forgot = new Forgot_Password();
            Forgot.Show();
            this.Hide();
        } //Moves to Forgot Password Screen

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoginButton.PerformClick();
        } //Allows Enter to be used to click Login

    }
}

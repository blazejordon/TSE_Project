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

            string path = "TSEprogramdata.txt";
            using (StreamWriter sw = (File.Exists(path)) ? File.AppendText(path) : File.CreateText(path))
            {
                sw.Close();
            }
        }
        private bool VerifyLogin(string AttemptUsername, string AttemptPassword)
        {
            string path = "TSEprogramdata.txt";
           
            //var UserLogin = from line in File.ReadLines(path) //Use for changing passwords and making them.
            //                    where (line.StartsWith("UserLogin:") &
            //                    line.StartsWith("TestUsername")) &
            //                    line.Contains("123")
            //                    select line;

            //Retrieves all pieces of data that are related to login from the program text file
            List<List<string>> AllLogins = new List<List<string>>();
            List<string> current = null;
            foreach (var line in File.ReadAllLines(path))
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
            foreach (var list in AllLogins)
            {
                foreach (var item in list)
                {
                    string values = x.ToString() + " " + y.ToString();
                    //MessageBox.Show(groups[x][y], values);
                    if (AllLogins[x][y] == AttemptUsername && AllLogins[x][y + 1] == AttemptPassword)
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
            //string testencrypt = Encrypt("1234");
            //string testdecrypt = Decrypt("CUFmrcVwQLU=");
            //MessageBox.Show(testencrypt);
            //MessageBox.Show(testdecrypt);
            bool Verified = false;
            string AttemptUsername = EnterUserName.Text;
            string AttemptPassword = EnterPassword.Text;
            Verified = VerifyLogin(AttemptUsername, AttemptPassword);

            if (Verified == true)
            {
                correct();
            }             
            else
            {
                //string testencrypt = Encrypt("Test"); //test, not feature
                //
                // PUT 'correct();' HERE TO SKIP TYPING IN LOGIN DATA.
                //
                MessageBox.Show("Incorrect Username or Password!","Error");
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
            this.Close();
        } //Moves to Register Screen

        private void ForgotPasswordButton_Click(object sender, EventArgs e)
        {
            Forgot_Password Forgot = new Forgot_Password();
            Forgot.Show();
            this.Close();
        } //Moves to Forgot Password Screen

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoginButton.PerformClick();
        } //Allows Enter to be used to click Login

    }
}

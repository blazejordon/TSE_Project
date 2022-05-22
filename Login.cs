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
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (EnterUserName.Text == "TestPassword" && EnterPassword.Text == "1234") //this will change to an actual encryption system with a database of registered people
            {
                correct();
            }
            else
            {
                string testencrypt = Encrypt("Test"); //test, not feature
                MessageBox.Show("Invalid username or password " + testencrypt , "Login");
            }
        }

        private void correct() //opens the main form.
        {
            MainMenu Menu = new MainMenu();
            Menu.Show();
            this.Close();
        }

        private string Encrypt(string Password)
        {
            Encryption encrypt = new Encryption();
            return encrypt.Encode(Password);
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
        }

        private void ForgotPasswordButton_Click(object sender, EventArgs e)
        {
            Forgot_Password Forgot = new Forgot_Password();
            Forgot.Show();
            this.Close();
        }
    }
}

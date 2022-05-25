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
    public partial class Forgot_Password : Form
    {
        
        public Forgot_Password()
        {
            InitializeComponent();
        }

        int Code; //Creates a global variable for a code so it can be accessed everywhere

        private void ButtonForgotPasswordBack_Click(object sender, EventArgs e) //Goes back to Login Screen
        {
            Login Login = new Login();
            Login.Show();
            this.Hide();
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {

            CreateFile GetPath = new CreateFile();
            string filepath = GetPath.LoginData();
            //Checks if the username and email exists
            if (EnterForgotPasswordUserName.Text != null && EnterForgotPasswordEmail.Text != null)
            {
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

                Random rnd = new Random();
                Code = rnd.Next(100000); //randomises the code for each new email
               
                string ForgotUsername = EnterForgotPasswordUserName.Text;
                string ForgotEmail = EnterForgotPasswordEmail.Text;

                int x = 0;
                int y = 0;
                foreach (var list in AllLogins)
                {
                    foreach (var item in list)
                    {
                        if (AllLogins[x][y] == ForgotUsername && AllLogins[x][y + 2] == ForgotEmail) //If the username matches the email
                        {
                            Email email = new Email();
                            string Recipient = AllLogins[x][y + 2].ToString();
                            string Subject = "Forgot Password Code";
                            string Body = "Hello, " + AllLogins[x][y] + "! Here is your one time code to use for retrieving your password: " + Code;
                            email.MakeEmail(Recipient, Subject, Body);
                        }
                        y++;
                    }
                    y = 0;
                    x++;
                }
            }
            else
            {
                MessageBox.Show("Username or Email does not exist!", "Error");
            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ButtonConfirm.PerformClick();
        }

        private void CheckCode_Click(object sender, EventArgs e) //checks the code from the email against the one the user input
        {
            CreateFile GetPath = new CreateFile();
            string filepath = GetPath.LoginData();
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
            int x = 0;
            int y = 0;
            foreach (var list in AllLogins)
            {
                foreach (var item in list)
                {
                    if (AllLogins[x][y] == EnterForgotPasswordUserName.Text && AllLogins[x][y + 2] == EnterForgotPasswordEmail.Text)
                    {
                        if (EnterEmailCode.Text == Code.ToString()) //if correct code, show the password
                        {
                            Encryption decrypt = new Encryption(); //decrypts the password from the file
                            OutputPassword.Text = decrypt.decode(AllLogins[x][y + 1].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Unique code does not match!", "Forgot Password Error");
                        }
                    }
                    y++;
                }
                y = 0;
                x++;
            }        
        }
    }
}

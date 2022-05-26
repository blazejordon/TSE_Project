using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TSE
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterBack_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            this.Hide();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            CreateFile GetPath = new CreateFile();
            string filepath = GetPath.LoginData();
            Encryption encrypt = new Encryption();

            if ((RegisterConfirmPassword.Text == RegisterPassword.Text) && RegisterPassword != null && RegisterEmail != null)
            {
                string email = RegisterEmail.Text;
                string pattern2 = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"; //creates regular expression pattern for an email format.
                Regex rx = new Regex(pattern2); //creates regex.
                Match rxemail = rx.Match(email); //tests if it fits the regular expression
                if (rxemail.Success) //checks if the email is a valid email
                {
                    bool NewEmailCheck = CheckEmail(); //checks if the email exists in login
                    if (NewEmailCheck == true)
                    {
                        string NewUsername = EnterRegisterUserName.Text;
                        string NewEmail = RegisterEmail.Text;
                        string NewPassword = RegisterPassword.Text;
                        string EncryptedPassword = encrypt.Encode(NewPassword);

                        using (StreamWriter sw = File.AppendText(filepath)) //saves the login to file
                        {
                            sw.WriteLine("UserLoginStart//");
                            sw.WriteLine(NewUsername);
                            sw.WriteLine(EncryptedPassword);
                            sw.WriteLine(NewEmail);
                            sw.WriteLine("//UserLoginEnd");
                            sw.Close();
                        }
                        MessageBox.Show("Account Registered!","Confirmation");
                    }
                    else
                    {
                        MessageBox.Show("Email is already in use!", "Error");
                    }
                }
                else
                {
                    MessageBox.Show(email + " is an invalid email!", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please Enter all areas for making a log in!", "Error");
            }
        }

        private bool CheckEmail()
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
                    if (AllLogins[x][y] == RegisterEmail.Text) //checks if the email exists or not
                    {
                        return false;
                    }
                    y++;
                }
                y = 0;
                x++;
            }
            return true;
        }
    }
}

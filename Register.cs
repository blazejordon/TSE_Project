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
            if (RegisterConfirmPassword.Text == RegisterPassword.Text && RegisterPassword != null)
            {
                string path = "TSEprogramdata.txt";
                string NewUsername = EnterRegisterUserName.Text;
                string NewPassword = RegisterPassword.Text;

                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("UserLoginStart//");
                    sw.WriteLine(NewUsername);
                    sw.WriteLine(NewPassword);
                    sw.WriteLine("//UserLoginEnd");
                    sw.Close();
                }
            }
            else
            {
                MessageBox.Show("Password and Confirm Password do not match!", "Error");
            }
        }
    }
}

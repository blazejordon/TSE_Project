using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using S22.Imap;

namespace TSE
{
    internal class Email
    {
        public void MakeEmail(string Recipient, string Subject, string Body)
        {
            string Email = "tsehealthassist@gmail.com";
            string Password = "mxxcFbs0RxxoGWU062sXrK28/Kd0Abw5"; //Encrypted Password for the email
            var message = new MailMessage(Email, Recipient);
            message.Subject = Subject;
            message.Body = Body;
            try
            {
                Encryption decrypt = new Encryption();
                string DecodedPassword = decrypt.decode(Password);
                using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587))
                {
                    mailer.Credentials = new NetworkCredential(Email, DecodedPassword);
                    mailer.EnableSsl = true;
                    mailer.Send(message);
                }
                MessageBox.Show("Email successfully sent!", "Email");
            }
            catch (SmtpException ex)
            {
                MessageBox.Show("Cannot send file, Error Message: " + ex.ToString(), "Email Error");
            }
            
        }
    }
}

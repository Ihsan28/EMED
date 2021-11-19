using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace EMED
{
    class sendemail
    {
        public static bool isValidMail(string email)
        {
            bool isValid=false;
            //var v=new DataAnnotations

            return isValid;
        }
        public static bool isemail(string subject, string message, string reciever)
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("group.project.csharp@gmail.com");
                mailMessage.To.Add(reciever);
                mailMessage.Subject = subject;
                mailMessage.Body = message;

                NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "group.project.csharp@gmail.com";
                ntcd.Password = "qwertyuioplkjhgf";

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Credentials = ntcd;
                smtp.EnableSsl = true;
                smtp.Port = 587;

                smtp.Send(mailMessage);

                return true;
            }
            catch(SmtpException)
            {
                return false;
            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Format is'nt correct.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public static bool check(string reciever)
        {
            
            try
            {
                if (reciever.Contains("."))
                {
                    MailMessage mailMessage = new MailMessage();
                    mailMessage.To.Add(reciever);

                    return true;
                }
                else
                    return false;
                
            }
            catch(FormatException)
            {
                //MessageBox.Show("Format is'nt correct.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;      
            }

        }
    }
}

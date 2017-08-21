using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorDataLogger.Utilities
{
    public sealed class MailManager
    {
        private static MailManager instance = null;
        private static readonly object padlock = new object();

        public MailManager()
        {

        }

        public static MailManager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new MailManager();
                    }
                    return instance;
                }
            }
        }
        public void SendEmail(string ToEmail,string title, string body,string attachmentFile )
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("argatesystems@gmail.com");

                mail.To.Add(ToEmail);
                mail.Subject = title;
                mail.Body = body;

                //System.Net.Mail.Attachment attachment;
                //attachment = new System.Net.Mail.Attachment("your attachment file");
                //mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("argatesystems@gmail.com", "Okyanus1900");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}

using SensorDataLogger.Screens;
using SensorDataLogger.StructObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SensorDataLogger.Utilities
{
    public sealed class MailManager
    {
        private static MailManager instance = null;
        private static readonly object padlock = new object();
        private Params XmlData;

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
        public void SendEmail(string title, string body, string attachmentFile)
        {
            Deserialize();
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("argatesystems@gmail.com");
                for(int i = 0; i < XmlData.MailUsers.Count;i++)
                {
                    mail.To.Add(XmlData.MailUsers[i].mailAddr);
                }
                //Burada XML den email listesini çekmesi gerekicek
                mail.Subject = title;
                mail.Body = body;

                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(attachmentFile);
                mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("argatesystems@gmail.com", "Okyanus1900");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Mail Başarıyla Gönderildi!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mail Gönderimi sırasında hata meydana geldi "+ex.ToString());
            }
        }
        private void Deserialize()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Params));
            TextReader reader = new StreamReader(AppConstants.ConfigurationFilePath);
            object obj = deserializer.Deserialize(reader);
            XmlData = (Params)obj;
            reader.Close();
        }
    }
}

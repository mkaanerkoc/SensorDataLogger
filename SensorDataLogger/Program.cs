using SensorDataLogger.Devices;
using SensorDataLogger.Screens;
using SensorDataLogger.StructObjects;
using SensorDataLogger.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SensorDataLogger
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CheckForParameterFile();
            Application.Run(new OpeningScreen());
            
            //Application.Run(new PG250Page());
        }
        static private void CheckForParameterFile()
        {
            if(System.IO.File.Exists(AppConstants.ConfigurationFilePath))
            {
                return;
            }
            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);
            XmlNode productsNode = doc.CreateElement("Params");
            doc.AppendChild(productsNode);
            doc.Save(AppConstants.ConfigurationFilePath);
        }

        static void OnProcessExit(object sender,EventArgs e)
        {
            Console.WriteLine("App closing");
            //MessageBox.Show("App Closing");
           
        }
    }
}

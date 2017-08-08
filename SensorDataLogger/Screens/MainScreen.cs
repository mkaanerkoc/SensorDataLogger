using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace SensorDataLogger
{
    public partial class Form1 : Form
    {
        dynamic xmlContent;
        public Form1()
        {
            InitializeComponent();
            //ValidateDevicesFile();
            parseDevicesXML();
        }
        private void ValidateDevicesFile()
        {
            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.Add("", "../../SensorConfiguration/SensorsSchema.xsd");
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
            settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
            settings.Schemas = schemaSet;
            // Create the XmlReader object.
            XmlReader reader = XmlReader.Create("../../SensorConfiguration/SensorsConfiguration.xml", settings);

            // Parse the file. 
            while (reader.Read()) ;
        }

        private static void ValidationCallBack(object sender, ValidationEventArgs args)
        {
            if (args.Severity == XmlSeverityType.Warning)
                Console.WriteLine("\tWarning: Matching schema not found.  No validation occurred." + args.Message);
            else
                Console.WriteLine("\tValidation error: " + args.Message);

        }

        private void parseDevicesXML()
        {

            //clearing up UI elements..
            listBox1.Items.Clear();
            var xmlDocument = XDocument.Load("../../SensorConfiguration/SensorsConfiguration.xml");

            // Convert the XML document in to a dynamic C# object.
            List<string> listNodes = new List<string>() { "Device,Param,Command" };
            xmlContent = new ExpandoObject();
            ExpandoObjectHelper.Parse(xmlContent, xmlDocument.Root, listNodes);

            foreach(dynamic device in xmlContent.Devices.Device)
            {
                Console.WriteLine("Device Brand : {0}, Device Model : {1}", device.Brand, device.Model);
                listBox1.Items.Add(device.Brand + "," + device.Model);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clearing up UI components
            deviceCommandsBox.Items.Clear();
            deviceParamsBox.Items.Clear();
            deviceCommandsBox.Text = "";
            deviceParamsBox.Text = "";

            dynamic device = xmlContent.Devices.Device[listBox1.SelectedIndex];
            deviceBrand.Text = "Brand : "+device.Brand;
            deviceModel.Text = "Model : " + device.Model;
            deviceProtocol.Text = "Protocol : " + device.Protocol;
            devicePhysicalLayer.Text = "Physical Layer : " + device.PhysicalLayer;
            if (((IDictionary<String, object>)device).ContainsKey("Commands"))
            {
                foreach(var command in device.Commands.Command)
                {
                    deviceCommandsBox.Items.Add(command.Type + "," + command.Code);
                }
            }
            if (((IDictionary<String, object>)device).ContainsKey("Params"))
            {
                foreach (var param in device.Params.Param)
                {
                    deviceParamsBox.Items.Add(param.Name + "," + param.Unit);
                }
            }
        }

        private void deviceSettingsBt_Click(object sender, EventArgs e)
        {

        }

        private void connectDeviceBt_Click(object sender, EventArgs e)
        {

        }
    }
}

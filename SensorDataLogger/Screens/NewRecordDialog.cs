using SensorDataLogger.Utilities;
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
using System.Xml.Linq;

namespace SensorDataLogger.Screens
{
    public partial class NewRecordDialog : Form
    {
        private DateTime dateTime;
        private dynamic xmlContent;
        private SensorReadingForm sensorForm;

        public NewRecordDialog()
        {
            InitializeComponent();
            LoadParamsFromFile();
        }

        private void startRecordBt_Click(object sender, EventArgs e)
        {
            if(operatorSelectionCb.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Operatör İsmini Giriniz!");
                return;
            }

            if (factorySelectionCb.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Fabrika İsmini Giriniz!");
                return;
            }
            if (shaftSelectionCb.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Baca İsmini Giriniz!");
                return;
            }
            if(label8.Text.Length<2)
            {
                MessageBox.Show("Lütfen Tarihi Yenile butonuna basarak güncelleyiniz!");
                return;
            }
            if (filePathTextBox.Text.Length < 2)
            {
                MessageBox.Show("Lütfen kaydedilecek dosyanın adresini seçiniz!");
                return;
            }

            ExcelManager.Instance.StartNewFileThread((short)comboBox1.SelectedIndex,
                                                        operatorSelectionCb.SelectedItem.ToString(),
                                                        factorySelectionCb.SelectedItem.ToString(),
                                                        shaftSelectionCb.SelectedItem.ToString(),
                                                        dateTime.ToString(),
                                                        fileNameTextBox.Text,
                                                        filePathTextBox.Text);

            //Burada SensorReadingForm acilacak , parametre olarak sensor türü verilecek
            sensorForm = new SensorReadingForm(comboBox1.SelectedItem.ToString());
            sensorForm.Show();
        }

        private void tarihSaatGuncelle_Click(object sender, EventArgs e)
        {
            dateTime = DateTime.Now;
            label8.Text = dateTime.ToString();
            fileNameTextBox.Text = factorySelectionCb.SelectedItem.ToString()+ "-" + dateTime.ToString("dd-MM-yyyy");
            
        }

        private void browseNewFile_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                filePathTextBox.Text =  (folderBrowserDialog1.SelectedPath);
                //MessageBox.Show(sr.ReadToEnd());
                //sr.Close();
            }
        }


        //Util Functions
        private void LoadParamsFromFile()
        {
            //clearing up UI elements..
            operatorSelectionCb.Items.Clear();
            factorySelectionCb.Items.Clear();
            shaftSelectionCb.Items.Clear();
            var xmlDocument = XDocument.Load("../../SensorConfiguration/AppParams.xml");

            // Convert the XML document in to a dynamic C# object.
            List<string> listNodes = new List<string>() { "Operators,Factories,Shafts" }; // Array Olan elementleri yaziyoruz
            xmlContent = new ExpandoObject();
            ExpandoObjectHelper.Parse(xmlContent, xmlDocument.Root, listNodes);

            foreach (dynamic oprtr in xmlContent.Params.Operators.Operator)
            {
                //Console.WriteLine("Device Brand : {0}, Device Model : {1}", device.Brand, device.Model);
                operatorSelectionCb.Items.Add(oprtr.Name + " " + oprtr.Surname + " - " + oprtr.ID);
            }
            foreach (dynamic factories in xmlContent.Params.Factories.Factory)
            {
                //Console.WriteLine("Device Brand : {0}, Device Model : {1}", device.Brand, device.Model);
                factorySelectionCb.Items.Add(factories.Name + " , " + factories.City + " , " + factories.ID);
            }
        }

        private void factorySelectionCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            shaftSelectionCb.Items.Clear();
            dynamic factry = xmlContent.Params.Factories.Factory[factorySelectionCb.SelectedIndex];
            if (((IDictionary<String, object>)factry).ContainsKey("Shafts"))
            {
                foreach (var shaft in factry.Shafts.Shaft)
                {
                    shaftSelectionCb.Items.Add(shaft.Name);
                }
            }
        }
    }
}

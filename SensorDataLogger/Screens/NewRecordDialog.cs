using SensorDataLogger.Devices;
using SensorDataLogger.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace SensorDataLogger.Screens
{
    public partial class NewRecordDialog : Form
    {
        private DateTime dateTime;
        Params XmlData;
        private SensorReadingForm sensorForm;
        private PG300Page pg300Page;
        private PG250Page pg250Page;

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
            string deviceName = comboBox1.SelectedItem.ToString();
            if (deviceName.Equals("PG250"))
            {
                pg250Page = new PG250Page();
                pg250Page.Show();
                //sensorContent.Controls.Add(pg250Page);
            }
            else if (deviceName.Equals("PG300"))
            {
                pg300Page = new PG300Page();
                pg300Page.Show();
            }
            this.Close();
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

            XmlSerializer deserializer = new XmlSerializer(typeof(Params));
            TextReader reader = new StreamReader(@"../../SensorConfiguration/AppParams.xml");
            object obj = deserializer.Deserialize(reader);
            XmlData = (Params)obj;
            reader.Close();
            //Update Views
            for (int i = 0; i < XmlData.Operators.Count; i++)
            {
                operatorSelectionCb.Items.Add(XmlData.Operators[i].Name + " " + XmlData.Operators[i].Surname + " - " + XmlData.Operators[i].ID);
            }
            for (int k = 0; k < XmlData.Factories.Count; k++)
            {
                factorySelectionCb.Items.Add(XmlData.Factories[k].Name + " , " + XmlData.Factories[k].City + " - " + XmlData.Factories[k].ID);
            }
        }

        private void factorySelectionCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = factorySelectionCb.SelectedIndex;
            shaftSelectionCb.Items.Clear();
            for (int k = 0; k < XmlData.Factories[i].Shafts.Count; k++)
            {
                shaftSelectionCb.Items.Add(XmlData.Factories[i].Shafts[k].Name);
            }
        }
    }
}

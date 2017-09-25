using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using SensorDataLogger.Dialogs;
using SensorDataLogger.StructObjects;
using System.Xml.Serialization;
using System.IO;

namespace SensorDataLogger.Screens
{
    public partial class ProgramParameters : Form
    {
        //private dynamic xmlContent;
        Params XmlData;
        public ProgramParameters()
        {
            InitializeComponent();
            //parseParametersXML();
            userList.Items.Clear();
            factoryList.Items.Clear();
            bacaList.Items.Clear();
            mailList.Items.Clear();
            Deserialize();
        }


        private void Serialize(Params appParams)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Params));
            using (TextWriter writer = new StreamWriter(AppConstants.ConfigurationFilePath))
            {
                serializer.Serialize(writer, appParams);
                MessageBox.Show("Kaydedildi!");
            }
        }
        private void Deserialize()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Params));
            TextReader reader = new StreamReader(AppConstants.ConfigurationFilePath);
            object obj = deserializer.Deserialize(reader);
            XmlData = (Params)obj;
            reader.Close();
            //Update Views
            for(int i = 0; i < XmlData.Operators.Count;i++)
            {
                userList.Items.Add(XmlData.Operators[i].Name + " " + XmlData.Operators[i].Surname + " - " + XmlData.Operators[i].ID);
            }
            for (int k = 0; k < XmlData.Factories.Count; k++)
            {
                //factories.Name + " , " + factories.City + " - " + factories.ID);
                factoryList.Items.Add(XmlData.Factories[k].Name + " , " + XmlData.Factories[k].City+" - "+XmlData.Factories[k].ID);
            }
            for (int m = 0; m < XmlData.MailUsers.Count;m++)
            {
                mailList.Items.Add(XmlData.MailUsers[m].mailAddr);
            }
        }
        private void newFactorySelected(object sender, EventArgs e)
        {
            int i = factoryList.SelectedIndex;
            if(i == -1)
            {
                return;
            }
            bacaList.Items.Clear();
            for(int k = 0; k < XmlData.Factories[i].Shafts.Count;k++)
            {
                bacaList.Items.Add(XmlData.Factories[i].Shafts[k].Name);
            }
        }

        private void addUserBt_Click(object sender, EventArgs e)
        {
            using (var form = new AddUserDialog())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Operator newOperator = form.operatorModel;            //values preserved after close
                    userList.Items.Add(newOperator.Name + " " + newOperator.Surname + " - " + newOperator.ID);
                    XmlData.Operators.Add(newOperator);
                }
            }
        }

        private void addFactoryBt_Click(object sender, EventArgs e)
        {
            using (var form = new AddFactoryDialog())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Factory newFactory = form.factoryModel;            //values preserved after close
                    factoryList.Items.Add(newFactory.Name + " , " + newFactory.City + " - " + newFactory.ID);
                    XmlData.Factories.Add(newFactory);
                }
            }
        }
        private void addBacaBt_Click(object sender, EventArgs e)
        {
            int i = factoryList.SelectedIndex;
            if(i == -1)
            {
                MessageBox.Show("Tesis listesinden tesis seçiniz");
                return;
            }
            using (var form = new AddShaftDialog())
            {
                var result = form.ShowDialog();
                if(result == DialogResult.OK)
                {
                    Shaft newShaft = form.shaftModel;
                    bacaList.Items.Add(newShaft.Name);
                    XmlData.Factories[i].Shafts.Add(newShaft);
                }
            }
        }

        private void mailListAddBt_Click(object sender, EventArgs e)
        {
            //int i = factoryList.SelectedIndex;
            using (var form = new AddMailUserDialog())
            {
                var result = form.ShowDialog();
                if(result == DialogResult.OK)
                {
                    MailUser mailusr = form.mailUsrModel;
                    if(IsValidEmail(mailusr.mailAddr))
                    {
                        mailList.Items.Add(mailusr.mailAddr);
                        XmlData.MailUsers.Add(mailusr);
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Geçerli bir Email Adresi giriniz");
                        return;
                    }
                    
                }
            }
        }

        private void deleteUserBt_Click(object sender, EventArgs e)
        {
            if(userList.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Kullanıcı Listesinden bir kullanıcı seçiniz");
                return;
            }
            XmlData.Operators.RemoveAt(userList.SelectedIndex);
            userList.Items.RemoveAt(userList.SelectedIndex);
        }

        private void deleteFactoryBt_Click(object sender, EventArgs e)
        {
            if (factoryList.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Tesis Listesinden bir tesis seçiniz");
                return;
            }
            XmlData.Factories.RemoveAt(factoryList.SelectedIndex);
            factoryList.Items.RemoveAt(factoryList.SelectedIndex);
        }

        private void deleteBacaBt_Click(object sender, EventArgs e)
        {
            if (factoryList.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Tesis Listesinden bir tesis seçiniz");
                return;
            }
            if (bacaList.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Ölcüm Noktası Listesinden bir ölçüm noktası seçiniz");
                return;
            }
            int k = factoryList.SelectedIndex;
            XmlData.Factories[k].Shafts.RemoveAt(bacaList.SelectedIndex);
            bacaList.Items.RemoveAt(bacaList.SelectedIndex);
        }
        private void mailListRemoveBt_Click(object sender, EventArgs e)
        {
            if(mailList.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Mail listesinden bir item seçiniz");
                return;
            }
            XmlData.MailUsers.RemoveAt(mailList.SelectedIndex);
            mailList.Items.RemoveAt(mailList.SelectedIndex);
        }

        private void loadXmlButton_Click(object sender, EventArgs e)
        {
            userList.Items.Clear();
            factoryList.Items.Clear();
            bacaList.Items.Clear();
            Deserialize();
        }

        private void saveXmlButton_Click(object sender, EventArgs e)
        {
            Serialize(XmlData);
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


    }
    public class Params
    {
        public List<Operator> Operators;
        public List<Factory> Factories;
        public List<Shaft> Shatfs;
        public List<Device> Devices;
        public List<MailUser> MailUsers;

        public Params()
        {
            Operators = new List<Operator>();
            Factories = new List<Factory>();
            MailUsers = new List<MailUser>();
        }
    }
    public class Operator
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ID { get; set; }
    }
    public class Factory
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string ID { get; set; }
        public List<Shaft> Shafts;
        public Factory()
        {
            Shafts = new List<Shaft>();
        }
    }
    public class Shaft
    {
        public string Name { get; set; }
        public string ID { get; set; }
    }
    public class MailUser
    {
        public string mailAddr { get; set; }
        public int groupID { get; set; }
    }
    public class Device
    {

    }
}

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

namespace SensorDataLogger.Screens
{
    public partial class ProgramParameters : Form
    {
        private dynamic xmlContent;
        public ProgramParameters()
        {
            InitializeComponent();
            parseParametersXML();
        }

        private void parseParametersXML()
        {

            //clearing up UI elements..
            userList.Items.Clear();
            factoryList.Items.Clear();
            bacaList.Items.Clear();
            var xmlDocument = XDocument.Load("../../SensorConfiguration/AppParams.xml");

            // Convert the XML document in to a dynamic C# object.
            List<string> listNodes = new List<string>() { "Operators,Factories,Shafts" }; // Array Olan elementleri yaziyoruz
            xmlContent = new ExpandoObject();
            ExpandoObjectHelper.Parse(xmlContent, xmlDocument.Root, listNodes);

            foreach (dynamic oprtr in xmlContent.Params.Operators.Operator)
            {
                //Console.WriteLine("Device Brand : {0}, Device Model : {1}", device.Brand, device.Model);
                userList.Items.Add(oprtr.Name + " " + oprtr.Surname+ " - "+oprtr.ID);
            }
            foreach (dynamic factories in xmlContent.Params.Factories.Factory)
            {
                //Console.WriteLine("Device Brand : {0}, Device Model : {1}", device.Brand, device.Model);
                factoryList.Items.Add(factories.Name + " , " + factories.City + " - " + factories.ID);
            }
        }

        private void newFactorySelected(object sender, EventArgs e)
        {
            Console.WriteLine("factory selected : {0}", factoryList.SelectedValue);
            bacaList.Items.Clear();
            dynamic factry = xmlContent.Params.Factories.Factory[factoryList.SelectedIndex];
            if (((IDictionary<String, object>)factry).ContainsKey("Shafts"))
            {
                foreach (var shaft in factry.Shafts.Shaft)
                {
                    bacaList.Items.Add(shaft.Name);
                }
            }
        }

        private void addUserBt_Click(object sender, EventArgs e)
        {
            using (var form = new AddUserDialog())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    OperatorModel newOperator = form.operatorModel;            //values preserved after close
                    userList.Items.Add(newOperator.Name + " " + newOperator.Surname + " - " + newOperator.ID);
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
                    FactoryModel newFactory = form.factoryModel;            //values preserved after close
                    factoryList.Items.Add(newFactory.Name + " , " + newFactory.City + " - " + newFactory.ID);
                    //Do something here with these values

                    //for example
                    //this.txtSomething.Text = val;
                }
            }
        }

        private void deleteUserBt_Click(object sender, EventArgs e)
        {
            userList.ClearSelected();
        }

        private void deleteFactoryBt_Click(object sender, EventArgs e)
        {
            factoryList.ClearSelected();
        }

        private void deleteBacaBt_Click(object sender, EventArgs e)
        {
            bacaList.ClearSelected();
        }
    }
}

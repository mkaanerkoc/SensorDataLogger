using SensorDataLogger.StructObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorDataLogger.Dialogs
{
    public partial class AddFactoryDialog : Form
    {
        public FactoryModel factoryModel { get; set; }
        public AddFactoryDialog()
        {
            InitializeComponent();
            this.factoryModel = new FactoryModel();
        }

        private void saveBt_Click(object sender, EventArgs e)
        {
            this.factoryModel.Name = factoryNameTb.Text;
            this.factoryModel.City = cityComboBox.SelectedItem.ToString(); //example
            this.factoryModel.ID = factoryIDTb.Text; //example

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

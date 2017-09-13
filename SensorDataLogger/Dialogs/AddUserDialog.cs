using SensorDataLogger.Screens;
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
   
    public partial class AddUserDialog : Form
    {
        public Operator operatorModel { get; set; }

        public AddUserDialog()
        {
            InitializeComponent();
            this.operatorModel = new Operator();
        }

        private void saveBt_Click(object sender, EventArgs e)
        {
            this.operatorModel.Name = opNameTb.Text;
            this.operatorModel.Surname = opSurnameTb.Text; //example
            this.operatorModel.ID = opIDTb.Text; //example

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

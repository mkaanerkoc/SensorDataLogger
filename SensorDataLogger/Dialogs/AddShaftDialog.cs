using SensorDataLogger.Screens;
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
    public partial class AddShaftDialog : Form
    {
        public Shaft shaftModel { get; set; }

        public AddShaftDialog()
        {
            InitializeComponent();
            this.shaftModel = new Shaft();
        }

        private void saveBt_Click(object sender, EventArgs e)
        {
            this.shaftModel.Name = bacaName.Text;
            this.shaftModel.ID = bacaID.Text; //example
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

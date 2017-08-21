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
    public partial class OldRecordInformationDialog : Form
    {
        public OldRecordInformationDialog(string deviceType,string operatorName,string city,
                                            string factoryName,string shaftCode,string startDt,string lastDt)
        {
            InitializeComponent();
            this.devType.Text = deviceType;
            this.City.Text = city;
            this.opName.Text = operatorName;
            this.factoryName.Text = factoryName;
            this.shaftCode.Text = shaftCode;
            this.startDt.Text = startDt;
            this.lastRecordDt.Text = lastDt;
        }

        private void yesBt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void noBt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

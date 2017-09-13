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
    public partial class AddMailUserDialog : Form
    {
        public MailUser mailUsrModel { get; set; }
        public AddMailUserDialog()
        {
            InitializeComponent();
            this.mailUsrModel = new MailUser();
        }

        private void saveBt_Click(object sender, EventArgs e)
        {
            this.mailUsrModel.mailAddr = emailTextBox.Text;
            this.mailUsrModel.groupID = emailGrupID.SelectedIndex+1; //example

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

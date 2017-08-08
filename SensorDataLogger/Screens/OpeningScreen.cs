using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorDataLogger.Screens
{
    public partial class OpeningScreen : Form
    {
        private ProgramParameters prgParamsPage;
        private NewRecordDialog newRecDialog;
        public OpeningScreen()
        {
            InitializeComponent();
        }

        private void oldRecordBt_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }
        }

        private void newRecordBt_Click(object sender, EventArgs e)
        {
            newRecDialog = new NewRecordDialog();
            newRecDialog.Show();
        }

        private void recordParameterSettingsClick(object sender, EventArgs e)
        {
            //TODO: ProgramParameters Singleton object olmali
            prgParamsPage = new ProgramParameters();
            prgParamsPage.Show();
        }
    }
}

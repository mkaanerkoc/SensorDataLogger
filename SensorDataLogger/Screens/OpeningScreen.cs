using SensorDataLogger.Devices;
using SensorDataLogger.Utilities;
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

        //Screen Variables//
        private PG250Page pg250Page;
        private PG300Page pg300Page;

        public OpeningScreen()
        {
            InitializeComponent();
            openFileDialog1.Filter = "XML files (*.xls)|*.xlsx";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.Multiselect = false;
        }

        private void oldRecordBt_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int result = ExcelManager.Instance.ValidateWorkFile(openFileDialog1.FileName);
                if(result == 10)
                {
                    pg250Page = new PG250Page();
                    pg250Page.Show();
                    //sensorContent.Controls.Add(pg250Page);
                }
                else if(result ==11)
                {
                    pg300Page = new PG300Page();
                    pg300Page.Show();
                }
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

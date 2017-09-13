using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO.Ports;
using System.Threading;
using SensorDataLogger.StructObjects;
using System.Collections;
using SensorDataLogger.Controls;
using SensorDataLogger.Interfaces;

using SensorDataLogger.Utilities;

namespace SensorDataLogger.Devices
{
    public partial class PG300Page : Form,IPG300ManagerToPage
    {

        private PG300Manager pg300Manager;
        private List<DataUnit> dataUnitList;

        public PG300Page()
        {
            InitializeComponent();
            pg300Manager = new PG300Manager();
            pg300Manager.pageInterface = this;
            InitializeDataUnits();
        }

        
        private void InitializeDataUnits()
        {
            dataUnitList = new List<DataUnit>();
            dataUnitList.Clear();
            for (int i = 0; i < pg300Manager.parameterTable.Count;i++)
            {
                DataUnit du = new DataUnit();
                du.Location = new Point(218 * (i%4) + 4, (i / 4) * 180);
                du.Size = new Size(218, 180);
                du.Label = (string)pg300Manager.parameterTable[i].name;
                du.CodeType = pg300Manager.parameterTable[i].id;
                MeasuredValuesPanel.Controls.Add(du);
                dataUnitList.Add(du);
            }
            
        }
        private void InitializeDiagnosticsUnits()
        {

        }
        //TODO burada delagation felan bi sikler yapılacak
        public void ReceiveR201DataFromManager(List<PG300ChannelModel> list)
        {
            //Console.WriteLine("Data received from manager , DataUnits.Count : {0},ReceivedList.Count : {1}",dataUnitList.Count,list.Count);
            for (int i = 0; i < list.Count; i++)
            {

                DataUnit du = dataUnitList.Find(x => x.CodeType == list[i].dataType) ;//Daha iyi bi getirme yöntemi bulunabilir
                du.Invoke((MethodInvoker)delegate {
                    // Running on the UI thread
                    //du.Label = 
                    du.Range = list[i].Range;
                    du.Value = list[i].Value;
                    du.Unit = list[i].Unit;
                });
            }
            pg300Manager.SendR202Command();
        }

        public void ReceiveR202DataFromManager(PG300DiagnosticsModel pg300Diagnostics)
        {
            ndirCorrectionText.Invoke((MethodInvoker)delegate
            {
                ndirCorrectionText.Text = pg300Diagnostics.NDIRCorrectionTemperature.ToString();
                ndirControlTmp.Text = pg300Diagnostics.NDIRControlTemperature.ToString();
                o2ControlTmp.Text = pg300Diagnostics.O2ControlTemperature.ToString();
                claControlTmp.Text = pg300Diagnostics.CLAControlTemperature.ToString();
                internalTmp.Text = pg300Diagnostics.InternalTemperature.ToString();
                electronicCoolrTmp.Text = pg300Diagnostics.ElectronicCoolerTemperature.ToString();
                atmPrsText.Text = pg300Diagnostics.AtmosphericPressure.ToString();
                flowRateTmp.Text = pg300Diagnostics.FlowRate.ToString();
                lastReadDate.Text = DateTime.Now.ToLongTimeString();
            });
        }

        private void SendEmailBt_Click(object sender, EventArgs e)
        {
            MailManager.Instance.SendEmail("mkaanerkoc@gmail.com", "Hello World", "This is a test email", "");
        }

        private void pg300Timer_Tick(object sender, EventArgs e)
        {
            pg300Manager.SendR201Command();
            pg300Manager.SendR202Command();
        }
        //GUI Function Calls
        private void sendCmdBt_Click(object sender, EventArgs e)
        {
            pg300Manager.SendR200Command();
        }

        private void R201CmdBt_Click(object sender, EventArgs e)
        {
            pg300Manager.SendR201Command();
        }

        private void R202CmdBt_Click(object sender, EventArgs e)
        {
            pg300Manager.SendR202Command();
        }

        private void recordStart_Click(object sender, EventArgs e)
        {
            recordStop.Enabled = true;
            recordStart.Enabled = false;
            pg300Manager.StartUDPListener();
            try
            {
                pg300Timer.Interval = Convert.ToInt32(pg300TimerIntervalTb.Text) * 1000;
                pg300Timer.Enabled = true;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Zamanlayıcı ayarlarını kontrol ediniz");
            }
        }

        private void recordStop_Click(object sender, EventArgs e)
        {
            recordStop.Enabled = false;
            pg300Timer.Enabled = false;
            recordStart.Enabled = true;
        }

        private void setReadPeriod_Click(object sender, EventArgs e)
        {
            try
            {
                pg300Manager.SetPG300IPAddress(deviceIPAddr.Text);
                pg300Timer.Interval = Convert.ToInt32(pg300TimerIntervalTb.Text) * 1000;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Zamanlayıcı ayarlarını kontrol ediniz");
            }
        }

        private void PG300Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExcelManager.Instance.CloseExcelApplication();
        }
    }
}

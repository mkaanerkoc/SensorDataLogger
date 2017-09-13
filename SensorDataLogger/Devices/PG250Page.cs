using SensorDataLogger.Controls;
using SensorDataLogger.Interfaces;
using SensorDataLogger.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorDataLogger.Devices
{
    public partial class PG250Page : Form, IPG250ManagerToPage
    {
        private PG250Manager pg250Manager;
        private List<DataUnit> dataUnitList;

        public PG250Page()
        {
            InitializeComponent();
            pg250Manager = new PG250Manager();
            pg250Manager.pageInterface = this;
            InitializeDataUnits();
            fillPortList();
        }

        private void InitializeDataUnits()
        {
            dataUnitList = new List<DataUnit>();
            dataUnitList.Clear();
            for (int i = 0; i < pg250Manager.parameterTable.Count; i++)
            {
                DataUnit du = new DataUnit();
                du.Location = new Point(218 * (i % 4) + 4, (i / 4) * 180);
                du.Size = new Size(218, 180);
                du.Label = (string)pg250Manager.parameterTable[i].name;
                du.CodeType = pg250Manager.parameterTable[i].id;
                MeasuredValuesPanel.Controls.Add(du);
                dataUnitList.Add(du);
            }
        }

        public void ReceiveR01DataFromManager(List<PG250ChannelModel> list)
        {
            for (int i = 0; i < list.Count; i++)
            {

                DataUnit du = dataUnitList[i];
                du.Invoke((MethodInvoker)delegate {
                    // Running on the UI thread
                    du.Range = (float)list[i].Range;
                    du.Value = list[i].Value;
                    if(list[i].CCode =='A')
                    {
                        du.Unit = "PPM";
                    }
                    else if(list[i].CCode =='B')
                    {
                        du.Unit = "vol %";
                    }
                    else if (list[i].CCode == 'c')
                    {
                        du.Unit = "Invalid";
                    }
                    else if (list[i].CCode == 'D')
                    {
                        du.Unit = "Over Range";
                    }
                    else if (list[i].CCode == 'E')
                    {
                        du.Unit = "Under Range";
                    }

                });
            }
            pg250Manager.SendC23Command();
        }

        public void ReceiveR23DataFromManager(PG250DiagnosticsModel model)
        {
            lastReadDate.Invoke((MethodInvoker)delegate
            {
                sampleFlowRateTxt.Text = model.FLOW.ToString();
                ndirTempText.Text = model.NDIR.ToString();
                lastReadDate.Text = DateTime.Now.ToLongTimeString();
            });
                
        }

        private void recordStart_Click(object sender, EventArgs e)
        {
            recordStop.Enabled = true;
            recordStart.Enabled = false;
            if (comboBox1.SelectedItem != null)
            {
                pg250Manager.ConnectCOMPort((string)comboBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Lütfen COM port seçiniz", "Hata");
            }
            try
            {
                pg250Timer.Interval = Convert.ToInt32(pg250TimerIntervalTb.Text) * 1000;
                pg250Timer.Enabled = true;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Zamanlayıcı ayarlarını kontrol ediniz");
            }
        }

        private void recordStop_Click(object sender, EventArgs e)
        {
            recordStop.Enabled = false;
            pg250Timer.Enabled = false;
            recordStart.Enabled = true;
            pg250Manager.DisconnectCOMPort();
        }

        private void pg250Timer_Tick(object sender, EventArgs e)
        {
            pg250Manager.SendC01Command();
            
        }

        private void connectBt_Click(object sender, EventArgs e)
        {
            
        }
        private void C01CmdBt_Click(object sender, EventArgs e)
        {
            pg250Manager.SendC01Command();
        }

        private void C23CmdBt_Click(object sender, EventArgs e)
        {
            pg250Manager.SendC23Command();
        }
        //Util Functions
        private void fillPortList()
        {
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;

            ArrayComPortsNames = SerialPort.GetPortNames();
            for (int i = 0; i < ArrayComPortsNames.Length; i++)
            {
                comboBox1.Items.Add(ArrayComPortsNames[i]);
            }

        }

        private void setReadPeriod_Click(object sender, EventArgs e)
        {
            fillPortList();
            pg250Timer.Interval = Convert.ToUInt16(pg250TimerIntervalTb.Text);
        }

        private void PG250Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExcelManager.Instance.CloseExcelApplication();
        }
    }
}

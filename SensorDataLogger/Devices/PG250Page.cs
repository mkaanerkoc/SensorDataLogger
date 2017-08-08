using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SensorDataLogger.Devices
{
    public partial class PG250Page : UserControl
    {
        private bool Recording = false;
        private bool Connected = false;

        public PG250Page()
        {
            InitializeComponent();
            InitializeViews();
        }

        //Parser Functions

        //Packer Functions

        //GUI Event Callbacks
        private void setReadPeriod_Click(object sender, EventArgs e)
        {
            try
            {
                pg250Timer.Interval = Convert.ToInt32(pg250TimerIntervalTb.Text) * 1000;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Zamanlayıcı ayarlarını kontrol ediniz");
            }
        }
        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                if (comboBox1.SelectedItem != null)
                {
                    serialPort1.PortName = comboBox1.SelectedItem.ToString();
                    serialPort1.BaudRate = 9600;
                    serialPort1.Parity = Parity.None;
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Handshake = Handshake.None;
                    serialPort1.RtsEnable = true;

                    serialPort1.Open();
                    connectButton.Text = "Bitir";
                }
                else
                {
                    MessageBox.Show("Lütfen COM port seçiniz", "Hata");
                }

            }
            else
            {
                serialPort1.Close();
                connectButton.Text = "Başlat";
            }
        }

        private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string ResponseData = serialPort1.ReadLine();
            /*mPG250.ParseResponse(ResponseData);
            switch (mPG250.lastCommand)
            {
                case "C01":
                    updatePG250ChannelTable(mPG250);
                    break;
                case "C23":
                    updatePG250StatusTable();
                    break;
                default:
                    break;
            }*/
        }
        private void updatePG250ChannelTable(PG250 pg250)
        {
            /*if (pg250CO2Label.InvokeRequired)
            {
                // this is worker thread
                updatePG250ChannelTableDelegate del = new updatePG250ChannelTableDelegate(updatePG250ChannelTable);
                pg250NOLabel.Invoke(del, new object[] { pg250 });
                pg250NOxLabel.Invoke(del, new object[] { pg250 });
                pg250CorrNOLabel.Invoke(del, new object[] { pg250 });
                pg250CorrNOxLabel.Invoke(del, new object[] { pg250 });
                pg250COLabel.Invoke(del, new object[] { pg250 });
                pg250CO2Label.Invoke(del, new object[] { pg250 });
                pg250O2Label.Invoke(del, new object[] { pg250 });
                pg250SO2Label.Invoke(del, new object[] { pg250 });
                pg250CorrSO2Label.Invoke(del, new object[] { pg250 });
            }
            else
            {
                // this is UI thread
                pg250NOLabel.Text = mPG250.channelList[0].value.ToString();
                pg250NOxLabel.Text = mPG250.channelList[1].value.ToString();
                pg250CorrNOLabel.Text = mPG250.channelList[2].value.ToString();
                pg250CorrNOxLabel.Text = mPG250.channelList[3].value.ToString();
                pg250COLabel.Text = mPG250.channelList[4].value.ToString();
                pg250CO2Label.Text = mPG250.channelList[5].value.ToString();
                pg250O2Label.Text = mPG250.channelList[6].value.ToString();
                pg250SO2Label.Text = mPG250.channelList[7].value.ToString();
                pg250CorrSO2Label.Text = mPG250.channelList[8].value.ToString();
            }*/
        }

        private void recordStart_Click(object sender, EventArgs e)
        {
            if(Connected)
            {
                recordStop.Enabled = true;
                recordStart.Enabled = false;
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
            else
            {
                MessageBox.Show("Cihaz ile bağlantı sağlanmadan kayıt alma başlayamaz");
                return;
            }
            

        }

        private void recordStop_Click(object sender, EventArgs e)
        {
            recordStop.Enabled = false;
            pg250Timer.Enabled = false;
            recordStart.Enabled = true;
        }

        //Timer Functions

        private void pg250Timer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Timer Tick");
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

        
        private void updatePG250StatusTable()
        {
            /*if (pg250NdirTempLabel.InvokeRequired)
            {
                // this is worker thread
                updatePG250StatusTableDelegate del = new updatePG250StatusTableDelegate(updatePG250StatusTable);

                pg250NdirTempLabel.Invoke(del);
                pg250DrainDiscLabel.Invoke(del);
                pg250SampleFlowRateLabel.Invoke(del);

            }
            else
            {
                // this is UI thread
                pg250DrainDiscLabel.Text = mPG250.DFLG.ToString();
                pg250SampleFlowRateLabel.Text = mPG250.FLOW.ToString() + " l/min";
                pg250NdirTempLabel.Text = mPG250.NDIR.ToString() + "  °C";*/
            }

       

        private void InitializeViews()
        {
            recordStop.Enabled = false;
            pg250Timer.Enabled = false;
        }

       
    }
   
}

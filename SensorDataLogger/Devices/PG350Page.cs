using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.IO.Ports;
using System.Threading;
using SensorDataLogger.StructObjects;
using System.Collections;

namespace SensorDataLogger.Devices
{
    public partial class PG350Page : Form
    {
        private SerialPort serialPort1;
        private UdpClient udpClient;
        private IPEndPoint ep;
        private bool ListenerThreadCreated = false;
        private Thread UdpListenerThread;
        private Thread TcpListenerThread;
        private const byte SOH  = 0x01;
        private const byte STX  = 0x02;
        private const byte ETX  = 0x03;
        private const byte DEV_ID_1 = 49;
        private const byte DEV_ID_2 = 50;
        private byte FRM_ID = 0x00;
        Hashtable parameterTable;
        Hashtable unitTable;
        string[] diagnosticsTable;
        /*PG300 FrameFormat*/
        /*
         * 
         * <SOH>+<SendID>+<RecvID>+<FrmID>+<CmdStr>+<STX>+<PrmStr>+<FCS>+<ETX>
         * 
         * 
         */
        public PG350Page()
        {
            InitializeComponent();
            udpClient = new UdpClient();
            ep = new IPEndPoint(IPAddress.Parse("192.168.1.1"), AppConstants.PG300_UDP_PORT); // endpoint where server is listening (testing localy)
            InitializeHashTables();
        }

        private void sendCmdBt_Click(object sender, EventArgs e)
        {
            byte[] OutputBuffer = new byte[] { SOH, DEV_ID_1, DEV_ID_2, 70, 70, 66, 66, 82, 50, 48, 48, STX };
            udpClient.Connect(ep);
            OutputBuffer = CalculateCheckSum(OutputBuffer);
            udpClient.Send(OutputBuffer, OutputBuffer.Length);
            StartUDPListener();
        }

        private void R201CmdBt_Click(object sender, EventArgs e)
        {
            byte[] OutputBuffer = new byte[] { SOH, DEV_ID_1, DEV_ID_2, 70, 70, 66, 66, 82, 50, 48, 49, STX};
            udpClient.Connect(ep);
            OutputBuffer = CalculateCheckSum(OutputBuffer);
            udpClient.Send(OutputBuffer, OutputBuffer.Length);
            StartUDPListener();
            //udpClient.Close();
        }

        private void R202CmdBt_Click(object sender, EventArgs e)
        {
            byte[] OutputBuffer = new byte[] { SOH, DEV_ID_1, DEV_ID_2, 70, 70, 66, 66, 82, 50, 48, 50, STX };
            udpClient.Connect(ep);
            OutputBuffer = CalculateCheckSum(OutputBuffer);
            udpClient.Send(OutputBuffer, OutputBuffer.Length);
            StartUDPListener();
            //udpClient.Close();
        }

        byte[] CalculateCheckSum(byte[] frame)
        {
            UInt16 fcs;
            byte[] returnArray = new byte[frame.Length + 3];
            fcs = 0x00;
            for (int i = 0; i < frame.Length; i++)
            {
                fcs ^= (byte)frame[i];
                returnArray[i] = frame[i];
            }
            //Console.WriteLine("Hex value is :{0}, First Digit Val :{1}, Second Digit val :{2}", fcs.ToString("X2"), , (byte)fcs.ToString("X2").ToCharArray()[1]);
            returnArray[frame.Length ] = (byte)fcs.ToString("X2").ToCharArray()[0];
            returnArray[frame.Length + 1] = (byte)fcs.ToString("X2").ToCharArray()[1];
            returnArray[frame.Length + 2] = ETX;
            return returnArray;
        }

        private void StartUDPListener()
        {
            if(!ListenerThreadCreated)
            {
                UdpListenerThread = new Thread(() =>
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Listening on UDP");
                            Byte[] receiveBytes = new byte[196];
                            var remoteEP = new IPEndPoint(IPAddress.Any, 60300);
                            receiveBytes = udpClient.Receive(ref remoteEP);
                            //Burada gelen veri Validate edilip Parse fonksiyonlarına dağıtılacak.
                            if (ValidateData(receiveBytes))
                            {
                                Console.WriteLine("Message received succesfully");
                                string[] returnData = Encoding.UTF8.GetString(receiveBytes).Split(AppConstants.PG300_SPLITTER_CHAR);
                                string rcvdCmd = returnData[0].Substring(7,4);
                                if(rcvdCmd.Equals("R200"))
                                {
                                    ParseR200Response(returnData);
                                }
                                else if (rcvdCmd.Equals("R201"))
                                {
                                    ParseR201Response(returnData);
                                }
                                else if (rcvdCmd.Equals("R202"))
                                {
                                    ParseR202Response(returnData);
                                }
                                else
                                {
                                    Console.WriteLine("Tanımlı olmayan bir dönüt geldi. Dönüt : {0}",rcvdCmd);
                                }
                            }
                        }
                        catch (Exception ee)
                        {

                        }
                    }
                });

                UdpListenerThread.IsBackground = true;
                UdpListenerThread.Start();
                ListenerThreadCreated = true;
            }
            
        }
        private bool ValidateData(byte[] InputBuffer)
        {
            UInt16 fcs  = 0x00;
            for (int i = 0; i < InputBuffer.Length-3; i++)
            {
                fcs ^= (byte)InputBuffer[i];
            }
            byte FCS_1 = (byte)fcs.ToString("X2").ToCharArray()[0];
            byte FCS_2 = (byte)fcs.ToString("X2").ToCharArray()[1];
            //Console.WriteLine("FCS1 : {0},FCS1 : {1},xFCS1 : {2},xFCS2 : {3}", FCS_1, FCS_2, InputBuffer[InputBuffer.Length - 3], InputBuffer[InputBuffer.Length - 2]);
            if (FCS_1  == InputBuffer[InputBuffer.Length-3] && FCS_2 == InputBuffer[InputBuffer.Length - 2])
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        private void ParseR200Response(string[] InputBuffer)
        {

            
        }
        private void ParseR201Response(string[] InputBuffer)
        {
            int DataParam = 0x00;
            int UnitType = 0x00;
            int DataCode = 0x00;
            int DataRange = 0x00;
            int DecimalPlaces = 0x00;
            string DataValue = "";
            double value = 0x00;
            /*0. kelime error status */
            if (!InputBuffer[0].Equals("00"))
            {

            }
            /*1. kelime Date Time */

            /*2 ile 34. parçalarda data verileri var */
            for (int i = 2; i < InputBuffer.Length-1; i++)
            {
                DataCode = Convert.ToByte(InputBuffer[i].Substring(0, 2));
                try
                {
                    DataRange = Convert.ToInt16(InputBuffer[i].Substring(2, 5));
                    UnitType = Convert.ToInt16(InputBuffer[i].Substring(5, 1));
                    DecimalPlaces = Convert.ToInt16(InputBuffer[i].Substring(6, 1));
                    DataValue = InputBuffer[i].Substring(9);
                    value = Double.Parse(DataValue);
                }
                catch(Exception e)
                {
                   
                }
                //Console.WriteLine("Parameter Name : {0}, Range : {1}, Unit : {2}", (string)parameterTable[DataCode], DataRange, (string)unitTable[UnitType]);
                Console.WriteLine("Parameter Name : {0}, Range : {1}, Unit : {2}, Decimal Place : {3},Value :{4}, Double Value : {5}", parameterTable[DataCode], DataRange, unitTable[UnitType], DecimalPlaces,DataValue, value);
            }
            /* 35.Kelimede event bilgisi var*/
        }
        private void ParseR202Response(string[] InputBuffer)
        {
            int DecimalPlaces = 0x00;
            string DataValue = "";
            double value = 0x00;

            /*0. kelime error status */
            if (!InputBuffer[0].Equals("00"))
            {

            }
            /*1. ile 11.kelimeler arası cihaz diagnostics bilgileri */
            for (int i = 1; i < 11; i++)
            {
                try
                {
                    DecimalPlaces = Convert.ToInt16(InputBuffer[i].Substring(0, 1));
                    DataValue = InputBuffer[i].Substring(1);
                    value = Double.Parse(DataValue);
                }
                catch (Exception e)
                {

                }

                Console.WriteLine("Parameter Name : {0}, Decimal Place : {1},Value :{2}, Double Value : {3}", diagnosticsTable[i-1], DecimalPlaces, DataValue, value);
            
            }
        }
        private void InitializeHashTables()
        {
            parameterTable = new Hashtable();
            unitTable = new Hashtable();
            diagnosticsTable = new string[] {"NaN" ,"NDIR correction temperature" ,"NaN", "O2 control temperature", "CLA control temperature", "NDIR control temperature",
                                            "Internal temperature", "Electronic cooler temperature", "Atmospheric pressure data(hPa)",
                                            "Flow rate data (L/min)" };
            parameterTable.Add(1, "NO");
            parameterTable.Add(2, "Converted NO");
            parameterTable.Add(3, "NO integrated");
            parameterTable.Add(4, "Converted NO Integrated");
            parameterTable.Add(9, "NO2");
            parameterTable.Add(10, "NO2");
            parameterTable.Add(11, "NO2");
            parameterTable.Add(12, "NO2");
            parameterTable.Add(13, "NO2");
            parameterTable.Add(14, "NO2");
            parameterTable.Add(15, "NO2");
            parameterTable.Add(16, "NO2");
            parameterTable.Add(17, "NO2");
            parameterTable.Add(18, "NO2");
            parameterTable.Add(19, "NO2");
            parameterTable.Add(21, "NO2");
            parameterTable.Add(22, "NO2");
            parameterTable.Add(23, "NO2");
            parameterTable.Add(24, "NO2");
            parameterTable.Add(25, "NO2");
            parameterTable.Add(27, "NO2");
            parameterTable.Add(29, "NO2");
            parameterTable.Add(31, "NO2");
            unitTable.Add(0, "ppm");
            unitTable.Add(1, "Vol %");
            unitTable.Add(2, "mg / m3");
            unitTable.Add(3, "g / m3");

        }
    }
}

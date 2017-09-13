using SensorDataLogger.Interfaces;
using SensorDataLogger.StructObjects;
using SensorDataLogger.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorDataLogger.Devices
{
    public class PG300Manager
    {
        private UdpClient udpClient;
        private IPEndPoint ep;
        private Thread UdpListenerThread;
        private Thread thdUDPServer;
        private PG300Model pg300Model;
        private IPAddress IpAdressOfPG300;
        private bool ListenerThreadCreated = false;
        public IPG300ManagerToPage pageInterface { get; set; }
        private const byte SOH = 0x01;
        private const byte STX = 0x02;
        private const byte ETX = 0x03;
        private const byte DEV_ID_1 = 49;
        private const byte DEV_ID_2 = 50;
        private byte FRM_ID = 0x00;

        public List<PG300Param> parameterTable;

        public string[] unitTable = new string[4] { "ppm","Vol %", "mg / m3", "g / m3"};
        public string[] diagnosticsTable  = new string[10] {"NaN" ,"NDIR correction temperature" ,"NaN", "O2 control temperature", "CLA control temperature", "NDIR control temperature",
                                            "Internal temperature", "Electronic cooler temperature", "Atmospheric pressure data(hPa)",
                                            "Flow rate data (L/min)" };


        public class PG300Param
        {
            public string name { get; set; }
            public int id { get; set; }
            public PG300Param( int d, string n)
            {
                this.id = d;
                this.name = n;
            }
        }
        /*PG300 FrameFormat*/
        /*
         * 
         * <SOH>+<SendID>+<RecvID>+<FrmID>+<CmdStr>+<STX>+<PrmStr>+<FCS>+<ETX>
         * 
         * 
         */
        public PG300Manager()
        {

            pg300Model = new PG300Model();
            InitializeHashTables();
            //ep = new IPEndPoint(IPAddress.Parse("192.168.1.1"), AppConstants.PG300_UDP_PORT); // endpoint where server is listening (testing localy)
            thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();

        }
        ~PG300Manager()
        {
            Console.WriteLine("From pg300 destructor"); 
        }
        public void SetPG300IPAddress(string ipAddress)
        {
            IPAddress ipAddr;
            if (ep!=null)
            {
                try
                {
                    ipAddr = IPAddress.Parse(ipAddress);
                }
                catch(FormatException LolZa)
                {
                    MessageBox.Show("Lütfen Geçerli Bir IP Adresi giriniz  "+LolZa.Message);
                    return;
                }
                ep.Address = ipAddr;
                this.IpAdressOfPG300 = ipAddr;
            }
            else
            {
                try
                {
                    ipAddr = IPAddress.Parse(ipAddress);
                }
                catch (FormatException LolZa)
                {
                    MessageBox.Show("Lütfen Geçerli Bir IP Adresi giriniz  " + LolZa.Message);
                    return;
                }
                ep = new IPEndPoint(ipAddr, AppConstants.PG300_UDP_PORT);
                this.IpAdressOfPG300 = ipAddr;
            }
        }
        /*will be deprecated */
        public void StartUDPListener()
        {
            if (!ListenerThreadCreated)
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
  
                                string[] returnData = Encoding.UTF8.GetString(receiveBytes).Split(AppConstants.PG300_SPLITTER_CHAR);
                                string rcvdCmd = returnData[0].Substring(7, 4);
                                if (rcvdCmd.Equals("R200"))
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
                                    Console.WriteLine("Tanımlı olmayan bir dönüt geldi. Dönüt : {0}", rcvdCmd);
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

        //Listener Thread
        public void serverThread()
        {
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
            udpClient = new UdpClient(60300);
            while (true)
            {
                //udpClient.Client.Bind(RemoteIpEndPoint);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnDataStr = Encoding.ASCII.GetString(receiveBytes);
                Console.WriteLine("Received Data " + returnDataStr);
                if (ValidateData(receiveBytes))
                {
                    string[] returnData = returnDataStr.Split(AppConstants.PG300_SPLITTER_CHAR);
                    string rcvdCmd = returnData[0].Substring(7, 4);
                    if (rcvdCmd.Equals("R200"))
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
                        Console.WriteLine("Tanımlı olmayan bir dönüt geldi. Dönüt : {0}", rcvdCmd);
                    }
                }
            }
        }
        //Packer functions
        public void SendR200Command()
        {
            byte[] OutputBuffer = new byte[] { SOH, DEV_ID_1, DEV_ID_2, 70, 70, 66, 66, 82, 50, 48, 48, STX };
            udpClient.Connect(ep);
            OutputBuffer = CalculateCheckSum(OutputBuffer);
            udpClient.Send(OutputBuffer, OutputBuffer.Length);
        }
        public void SendR201Command()
        {
            byte[] OutputBuffer = new byte[] { SOH, DEV_ID_1, DEV_ID_2, 70, 70, 66, 66, 82, 50, 48, 49, STX };
            udpClient.Connect(ep);
            OutputBuffer = CalculateCheckSum(OutputBuffer);
            udpClient.Send(OutputBuffer, OutputBuffer.Length);
            //StartUDPListener();
        }
        public void SendR202Command()
        {
            byte[] OutputBuffer = new byte[] { SOH, DEV_ID_1, DEV_ID_2, 70, 70, 66, 66, 82, 50, 48, 50, STX };
            udpClient.Connect(ep);
            OutputBuffer = CalculateCheckSum(OutputBuffer);
            udpClient.Send(OutputBuffer, OutputBuffer.Length);
           //StartUDPListener();
        }

        //Parser functions
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
            pg300Model.channelList.Clear();
            /*0. kelime error status */
            if (!InputBuffer[0].Equals("00"))
            {

            }
            /*1. kelime Date Time */

            /*2 ile 34. parçalarda data verileri var */
            for (int i = 2; i < InputBuffer.Length - 1; i++)
            {
                PG300ChannelModel chModel = new PG300ChannelModel();
                //Console.WriteLine("Received words : " + InputBuffer[i]);
                DataCode = Convert.ToByte(InputBuffer[i].Substring(0, 2));
                chModel.Name = parameterTable.Find(x => x.id == DataCode).name;
                chModel.dataType = DataCode;
                try
                {
                    chModel.Range = Convert.ToInt16(InputBuffer[i].Substring(2, 5));
                    chModel.Unit  = unitTable[Convert.ToInt16(InputBuffer[i].Substring(5, 1))]; 
                    //DecimalPlaces = Convert.ToInt16(InputBuffer[i].Substring(6, 1));
                    DataValue     = InputBuffer[i].Substring(9);
                    chModel.Value = Double.Parse(DataValue);
                }
                catch (Exception e)
                {
                    chModel.Range = 2000;
                    chModel.Unit = "-";
                    chModel.Value = 0;
                }
                pg300Model.channelList.Add(chModel);
                //Console.WriteLine("Parameter Name : {0}, Range : {1}, Unit : {2}", (string)parameterTable[DataCode], DataRange, (string)unitTable[UnitType]);
                //Console.WriteLine("Parameter Name : {0}, Range : {1}, Unit : {2}, Double Value : {3}", chModel.Name, chModel.Range, unitTable[chModel.unitType], chModel.Value);
            }
            pageInterface.ReceiveR201DataFromManager(pg300Model.channelList);
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
            //NDIR Correction Temperature
            try
            {
                pg300Model.diagnosticsModel.NDIRCorrectionTemperature = Double.Parse(InputBuffer[2].Substring(1));
            }
            catch(Exception e )
            {

            }
            //O2 Control Temperature
            try
            {
                pg300Model.diagnosticsModel.O2ControlTemperature = Double.Parse(InputBuffer[4].Substring(1));
            }
            catch (Exception e)
            {
                pg300Model.diagnosticsModel.O2ControlTemperature = -1;
            }
            //CLA Control Temperature
            try
            {
                pg300Model.diagnosticsModel.CLAControlTemperature = Double.Parse(InputBuffer[5].Substring(1));
            }
            catch (Exception e)
            {
                pg300Model.diagnosticsModel.CLAControlTemperature = -1;
            }
            //NDIR Control Temperature
            try
            {
                pg300Model.diagnosticsModel.NDIRControlTemperature = Double.Parse(InputBuffer[6].Substring(1));
            }
            catch(Exception e)
            {
                pg300Model.diagnosticsModel.NDIRControlTemperature = -1;
            }
            //Internal Temperature
            try
            {
                pg300Model.diagnosticsModel.InternalTemperature = Double.Parse(InputBuffer[7].Substring(1));
            }
            catch (Exception e)
            {
                pg300Model.diagnosticsModel.InternalTemperature = -1;
            }
            //Electronic Cooler Temperature
            try
            {
                pg300Model.diagnosticsModel.ElectronicCoolerTemperature = Double.Parse(InputBuffer[8].Substring(1));
            }
            catch (Exception e)
            {
                pg300Model.diagnosticsModel.ElectronicCoolerTemperature = -1;
            }
            //Atmospheric Pressure
            try
            {
                pg300Model.diagnosticsModel.AtmosphericPressure = Double.Parse(InputBuffer[9].Substring(1));
            }
            catch (Exception e)
            {
                pg300Model.diagnosticsModel.AtmosphericPressure = -1;
            }
            //FlowRate
            try
            {
                pg300Model.diagnosticsModel.FlowRate = Double.Parse(InputBuffer[10].Substring(1));
            }
            catch (Exception e)
            {
                pg300Model.diagnosticsModel.FlowRate = -1;
            }
            
            PG300ExcelRowModel pg300ExcelRow = new PG300ExcelRowModel();
            pg300ExcelRow.date = DateTime.Now.ToShortDateString();
            pg300ExcelRow.time = DateTime.Now.ToLongTimeString();
            pg300ExcelRow.pg300Diag = pg300Model.diagnosticsModel;
            pg300ExcelRow.pg300Channels = pg300Model.channelList;
            ExcelManager.Instance.AppendLog(AppConstants.PG300_TYPE, pg300ExcelRow);

            pageInterface.ReceiveR202DataFromManager(pg300Model.diagnosticsModel);

        }

        //Excel Functions
        private void AppendDataBuffer()
        {
            PG300ExcelRowModel pg300ExcelRow = new PG300ExcelRowModel();
            pg300ExcelRow.date = DateTime.Now.ToShortDateString();
            pg300ExcelRow.time = DateTime.Now.ToLongTimeString();
            //for(int i = 0; i < pg300Model.channelList)
            //pg300ExcelRow.pg300Channels
        }
        private void WriteBufferToExcel()
        {

        }
        public void CloseConnection()
        {
            udpClient.Client.Close();
            udpClient.Close();
            udpClient = null;
            thdUDPServer.Abort();
        }
        //Util Functions
        private byte[] CalculateCheckSum(byte[] frame)
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
            returnArray[frame.Length] = (byte)fcs.ToString("X2").ToCharArray()[0];
            returnArray[frame.Length + 1] = (byte)fcs.ToString("X2").ToCharArray()[1];
            returnArray[frame.Length + 2] = ETX;
            return returnArray;
        }
        private bool ValidateData(byte[] InputBuffer)
        {
            UInt16 fcs = 0x00;
            for (int i = 0; i < InputBuffer.Length - 3; i++)
            {
                fcs ^= (byte)InputBuffer[i];
            }
            byte FCS_1 = (byte)fcs.ToString("X2").ToCharArray()[0];
            byte FCS_2 = (byte)fcs.ToString("X2").ToCharArray()[1];
            //Console.WriteLine("FCS1 : {0},FCS1 : {1},xFCS1 : {2},xFCS2 : {3}", FCS_1, FCS_2, InputBuffer[InputBuffer.Length - 3], InputBuffer[InputBuffer.Length - 2]);
            if (FCS_1 == InputBuffer[InputBuffer.Length - 3] && FCS_2 == InputBuffer[InputBuffer.Length - 2])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void InitializeHashTables()
        {
            parameterTable = new List<PG300Param>();
            parameterTable.Add(new PG300Param(1,"NO"));
            parameterTable.Add(new PG300Param(2, "Converted NO"));
            parameterTable.Add(new PG300Param(3, "NO moving avarage"));
            parameterTable.Add(new PG300Param(4, "Converted NO moving avarage"));

            parameterTable.Add(new PG300Param(9, "NOx"));
            parameterTable.Add(new PG300Param(10, "Converted NOX"));
            parameterTable.Add(new PG300Param(11, "NOx moving avarage"));
            parameterTable.Add(new PG300Param(12, "Converted NOx moving avarage"));

            parameterTable.Add(new PG300Param(13, "SO2"));
            parameterTable.Add(new PG300Param(14, "Converted SO2"));
            parameterTable.Add(new PG300Param(15, "SO2 moving avarage"));
            parameterTable.Add(new PG300Param(16, "Converted SO2 moving avarage"));

            parameterTable.Add(new PG300Param(17, "CH4"));
            parameterTable.Add(new PG300Param(19, "CH4 moving avarage"));

            parameterTable.Add(new PG300Param(21, "CO"));
            parameterTable.Add(new PG300Param(22, "Converted CO"));
            parameterTable.Add(new PG300Param(23, "CO moving avarage"));
            parameterTable.Add(new PG300Param(24, "Converted CO moving avarage"));

            parameterTable.Add(new PG300Param(25, "CO2"));
            parameterTable.Add(new PG300Param(27, "CO2 moving avarage"));

            parameterTable.Add(new PG300Param(29, "O2"));
            parameterTable.Add(new PG300Param(31, "O2 moving avarage"));

        }

    }
}

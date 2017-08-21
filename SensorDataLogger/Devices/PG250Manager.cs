using SensorDataLogger.Interfaces;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorDataLogger.Devices
{
    
    public class PG250Manager
    {
        public DateTime dateTime;
        private SerialPort serialPort1;
        private PG250Model pg250Model;
        public List<PG250Param> parameterTable;
        public IPG250ManagerToPage pageInterface;

        public PG250Manager()
        {
            pg250Model = new PG250Model();
            serialPort1 = new SerialPort();
        }
        public class PG250Param
        {
            public string name { get; set; }
            public int id { get; set; }
            public PG250Param(int d, string n)
            {
                this.id = d;
                this.name = n;
            }
        }

        //Packer Functions
        public void SendC01Command(SerialPort sp)
        {
            Console.WriteLine("C01 Send");
            byte[] buf1 = { 67, 48, 49, 53, 67, 13, 10 };
            if (sp.IsOpen)
            {
                sp.Write("C015C\r\n");
            }
            else
            {
                MessageBox.Show("COM Port Açık değil !", "Hata");
            }
        }

        public void SendC23Command(SerialPort sp)
        {
            Console.WriteLine("C23 Send");
            byte[] buf2 = { 67, 50, 51, 52, 50, 3, 13, 10 };
            if (sp.IsOpen)
            {
                sp.Write("C2358\r\n");
            }
            else
            {
                MessageBox.Show("COM Port Açık değil !", "Hata");
            }
        }

        //Parser Functions
        public void ParseResponse(string Response)
        {
            string[] subStrings = Response.Split(Constants.PG250_SPLITTER);
            string responseCode = subStrings[0];
            /*Debug Printing */
            //Console.WriteLine(Response);
            foreach (string str in subStrings)
            {
                //Console.WriteLine(str);
            }
            if (responseCode.Equals("R01"))
            {
                ParseR01Response(subStrings);
            }
            else if (responseCode.Equals("R23"))
            {
                ParseR23Response(subStrings);
            }
            else
            {
                Console.WriteLine("Belirli olmayan bir response geldi");
            }
        }

        public void ParseR01Response(string[] InputBuffer)
        {
            //this.currentScreen = int.Parse(InputBuffer[1]);
            pg250Model.channelList.Clear();

            this.dateTime = DateTime.Now;
            for (int i = 0; i < 9; i++)
            {
                string str = InputBuffer[i + 2];
                //str = str.Replace('.', ',');
                //Console.WriteLine(str);
                PG250ChannelModel ch = new PG250ChannelModel(parameterTable[i].name);
                ch.RCode = str[0];
                ch.Range = double.Parse(str.Substring(1, 4));
                ch.CCode = str[5];
                if (ch.CCode != 'C')
                {
                    ch.value = double.Parse(str.Substring(6, 5));
                }
                /*Console.WriteLine("Channel Name : {0}", channelList.ElementAt(i).channelName);
                Console.WriteLine("RCode : {0}", channelList.ElementAt(i).RCode);
                Console.WriteLine("Range: {0} ", channelList.ElementAt(i).Range);
                Console.WriteLine("CCode: {0} ", channelList.ElementAt(i).CCode);
                Console.WriteLine("value: {0} ", channelList.ElementAt(i).value);*/
                pg250Model.channelList.Add(ch);
            }
            pageInterface.ReceiveR01DataFromManager(pg250Model.channelList);
        }
        public void ParseR23Response(string[] InputBuffer)
        {
            InputBuffer[3] = InputBuffer[3].Substring(0, 6);
            for (int i = 1; i < 4; i++)
            {
                //subStrings[i] = subStrings[i].Replace('.', ',');
                Console.WriteLine(InputBuffer[i]);

            }
            pg250Model.diagnosticsModel.DFLG = InputBuffer.Contains("1");
            pg250Model.diagnosticsModel.FLOW = double.Parse(InputBuffer[2]);
            pg250Model.diagnosticsModel.NDIR = double.Parse(InputBuffer[3].Substring(0, 6));
            Console.WriteLine("Drain Discharge : {0}, Sample Flow Rate : {1}, NDIR : {2}", 
                                    pg250Model.diagnosticsModel.DFLG, 
                                    pg250Model.diagnosticsModel.FLOW, 
                                    pg250Model.diagnosticsModel.NDIR);

            pageInterface.ReceiveR23DataFromManager(pg250Model.diagnosticsModel);
        }
        private void InitializeHashTables()
        {
            parameterTable = new List<PG250Param>();
            parameterTable.Add(new PG250Param(0,"NO"));
            parameterTable.Add(new PG250Param(1,"NOx"));
            parameterTable.Add(new PG250Param(2,"Correlated NO"));
            parameterTable.Add(new PG250Param(3,"Correlated NOx"));
            parameterTable.Add(new PG250Param(4,"CO"));
            parameterTable.Add(new PG250Param(5,"CO2"));
            parameterTable.Add(new PG250Param(6,"O2"));
            parameterTable.Add(new PG250Param(7,"SO2"));
            parameterTable.Add(new PG250Param(8,"Correlated SO2")); 
        }
    }

}

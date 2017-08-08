using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorDataLogger.Devices
{

    class PG250 : BaseSensor, ISensorInterface
    {
        public class PG250ChannelInfo
        {
            public string channelName { get; set; }
            public double value { get; set; }
            public char RCode { get; set; }
            public double Range { get; set; }
            public char CCode { get; set; }

            public PG250ChannelInfo(string chName)
            {
                this.value = -9999;
                this.CCode = 'x';
                this.RCode = 'x';
                this.Range = 0;
                this.channelName = chName;
            } 
        }

        public int currentScreen { get; set; }
        public List<PG250ChannelInfo> channelList;

        public double NDIR { get; set; }
        public bool DFLG { get; set; }
        public double FLOW { get; set; }

        private char splitterChar = ',';
        public string lastCommand { get; set; }

        public PG250()
        {
            channelList = new List<PG250ChannelInfo>();
            channelList.Add(new PG250ChannelInfo("NO"));
            channelList.Add(new PG250ChannelInfo("NOx"));
            channelList.Add(new PG250ChannelInfo("CorrNO"));
            channelList.Add(new PG250ChannelInfo("CorrNOx"));
            channelList.Add(new PG250ChannelInfo("CO"));
            channelList.Add(new PG250ChannelInfo("CO2"));
            channelList.Add(new PG250ChannelInfo("O2"));
            channelList.Add(new PG250ChannelInfo("SO2"));
            channelList.Add(new PG250ChannelInfo("CorrSO2"));
        }

        public void ReadChannels(SerialPort sp)
        {
            Console.WriteLine("C01 Send");
            byte[] buf1 = { 67, 48, 49, 53, 67, 13, 10 };
            if (sp.IsOpen)
            {
                sp.Write("C015C\r\n");
                this.lastCommand = "C01";
            }
            else
            {
                MessageBox.Show("COM Port Açık değil !", "Hata");
            }
        }

        public void ReadStatus(SerialPort sp)
        {
            Console.WriteLine("C23 Send");
            byte[] buf2 = { 67, 50, 51, 52, 50, 3, 13, 10 };
            if (sp.IsOpen)
            {
                sp.Write("C2358\r\n");
                this.lastCommand = "C23";
            }
            else
            {
                MessageBox.Show("COM Port Açık değil !", "Hata");
            }
        }

        public int ParseResponse(string Response)
        {
            string[] subStrings = Response.Split(splitterChar);
            /*Debug Printing */
            //Console.WriteLine(Response);
            foreach (string str in subStrings)
            {
                //Console.WriteLine(str);
            }
            switch (lastCommand)
            {
                case "C01":
                    if (subStrings[0].Equals("R01"))
                    {
                        this.currentScreen = int.Parse(subStrings[1]);
                        for (int i = 0; i<9 ;i++)
                        {
                            string str = subStrings[i+2];
                            //str = str.Replace('.', ',');
                            //Console.WriteLine(str);
                            channelList.ElementAt<PG250ChannelInfo>(i).RCode = str[0];
                            channelList.ElementAt<PG250ChannelInfo>(i).Range = double.Parse(str.Substring(1, 4));
                            channelList.ElementAt<PG250ChannelInfo>(i).CCode = str[5];
                            if(channelList.ElementAt<PG250ChannelInfo>(i).CCode != 'C')
                            {
                                channelList.ElementAt<PG250ChannelInfo>(i).value = double.Parse(str.Substring(6, 5));
                            }
                            Console.WriteLine("Channel Name : {0}", channelList.ElementAt<PG250ChannelInfo>(i).channelName);
                            Console.WriteLine("RCode : {0}", channelList.ElementAt<PG250ChannelInfo>(i).RCode);
                            Console.WriteLine("Range: {0} ", channelList.ElementAt<PG250ChannelInfo>(i).Range);
                            Console.WriteLine("CCode: {0} ", channelList.ElementAt<PG250ChannelInfo>(i).CCode);
                            Console.WriteLine("value: {0} ", channelList.ElementAt<PG250ChannelInfo>(i).value);
                            }
                    }
                    break;
                case "C23":
                    if (subStrings[0].Equals("R23"))
                    {
                        subStrings[3] = subStrings[3].Substring(0, 6);
                        for (int i = 1; i < 4;i++)
                        {
                            //subStrings[i] = subStrings[i].Replace('.', ',');
                            Console.WriteLine(subStrings[i]);
                            
                        }
                        this.DFLG = subStrings.Contains("1");
                        this.FLOW = double.Parse(subStrings[2]);
                        this.NDIR = double.Parse(subStrings[3].Substring(0, 6));
                        Console.WriteLine("Drain Discharge : {0}, Sample Flow Rate : {1}, NDIR : {2}", this.DFLG, this.FLOW, this.NDIR);
                        
                        
                    }
                    break;
                default:
                    return -1;
            }
            return 1;
        }

        public void ReadSensor()
        {
            throw new NotImplementedException();
        }
    }
}

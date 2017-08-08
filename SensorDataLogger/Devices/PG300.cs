using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SensorDataLogger.ConstsNTypes;

namespace SensorDataLogger.Devices
{
    class PG300 
    {
        private class ChannelInfo
        {
            string channelName { get; set; }
            float value { get; set; }
            int RCode { get; set; }
            float Range { get; set; }
            int CCode { get; set; }

            public ChannelInfo(string chName)
            {
                this.channelName = chName;
            }
        }



        private String brand = "Horiba";
        private String model = "PG300";
        public void Read()
        {
            
        }
    }
}

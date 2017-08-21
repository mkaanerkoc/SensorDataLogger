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
        
        public string lastCommand { get; set; }

        public PG250()
        {
            /*channelList = new List<PG250ChannelInfo>();
            channelList.Add(new PG250ChannelInfo("NO"));
            channelList.Add(new PG250ChannelInfo("NOx"));
            channelList.Add(new PG250ChannelInfo("CorrNO"));
            channelList.Add(new PG250ChannelInfo("CorrNOx"));
            channelList.Add(new PG250ChannelInfo("CO"));
            channelList.Add(new PG250ChannelInfo("CO2"));
            channelList.Add(new PG250ChannelInfo("O2"));
            channelList.Add(new PG250ChannelInfo("SO2"));
            channelList.Add(new PG250ChannelInfo("CorrSO2"));*/
        }

        public void ReadSensor()
        {
            throw new NotImplementedException();
        }
    }
}

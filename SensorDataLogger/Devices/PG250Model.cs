using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorDataLogger.Devices
{
    public class PG250Model
    {
        public List<PG250ChannelModel> channelList;
        public PG250DiagnosticsModel diagnosticsModel;
    }
    public class PG250ChannelModel
    {
        public string channelName { get; set; }
        public double value { get; set; }
        public char RCode { get; set; }
        public double Range { get; set; }
        public char CCode { get; set; }

        public PG250ChannelModel(string chName)
        {
            this.value = -9999;
            this.CCode = 'x';
            this.RCode = 'x';
            this.Range = 0;
            this.channelName = chName;
        }
    }

    public class PG250DiagnosticsModel
    {
        public double NDIR { get; set; }
        public bool DFLG { get; set; }
        public double FLOW { get; set; }
    }
}

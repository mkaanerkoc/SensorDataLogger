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

        public PG250Model()
        {
            channelList = new List<PG250ChannelModel>();
            diagnosticsModel = new PG250DiagnosticsModel();
        }
    }
    
    public class PG250ChannelModel
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public char RCode { get; set; }
        public double Range { get; set; }
        public char CCode { get; set; }

        public PG250ChannelModel(string chName)
        {

            this.Value = -9999;
            this.CCode = 'x';
            this.RCode = 'x';
            this.Range = 0;
            this.Name = chName;
        }
    }

    public class PG250DiagnosticsModel
    {
        public double NDIR { get; set; }
        public bool DFLG { get; set; }
        public double FLOW { get; set; }
    }
    public class PG250ExcelRowModel
    {
        public string date { get; set; }
        public string time { get; set; }
        public List<PG250ChannelModel> pg250Channels { get; set; }
        public PG250DiagnosticsModel pg250Diag { get; set; }

        public PG250ExcelRowModel()
        {
            pg250Channels = new List<PG250ChannelModel>();
        }
    }
}

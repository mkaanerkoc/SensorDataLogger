using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorDataLogger.Devices
{
    public class PG300Model
    {

        public List<PG300ChannelModel> channelList;
        public List<PG300DiagnosticsModel> diagnosticsList;

        private String brand = "Horiba";
        private String model = "PG300";

        public PG300Model()
        {
            channelList = new List<PG300ChannelModel>();
            diagnosticsList = new List<PG300DiagnosticsModel>();
        }

    }

    public class PG300ChannelModel
    {
        public string Name { get; set; }
        public int dataType { get; set; }
        public double Value { get; set; }
        public string Unit { get; set; }
        public int unitType { get; set; }
        public float Range { get; set; }
        public PG300ChannelModel()
        {

        }
    }
    public class PG300DiagnosticsModel
    {
        public PG300DiagnosticsModel()
        {

        }

    }
}

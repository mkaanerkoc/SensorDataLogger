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
        public PG300DiagnosticsModel diagnosticsModel;

        private String brand = "Horiba";
        private String model = "PG300";

        public PG300Model()
        {
            channelList = new List<PG300ChannelModel>();
            diagnosticsModel = new PG300DiagnosticsModel();
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
        public double NDIRCorrectionTemperature { get; set; }
        public double O2ControlTemperature { get; set; }
        public double CLAControlTemperature { get; set; }
        public double NDIRControlTemperature { get; set; }
        public double InternalTemperature { get; set; }
        public double ElectronicCoolerTemperature { get; set; }
        public double AtmosphericPressure { get; set; }
        public double FlowRate { get; set; }

        public PG300DiagnosticsModel()
        {
            
        }

    }
    public class PG300ExcelRowModel
    {
        public string date { get; set; }
        public string time { get; set; }
        public List<PG300ChannelModel> pg300Channels { get; set; }
        public PG300DiagnosticsModel pg300Diag { get; set; }

        public PG300ExcelRowModel()
        {
            pg300Channels = new List<PG300ChannelModel>();
        }
    }
}

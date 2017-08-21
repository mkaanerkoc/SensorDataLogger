using SensorDataLogger.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorDataLogger.Interfaces
{
    public interface IPG300ManagerToPage
    {
        void ReceiveR201DataFromManager(List<PG300ChannelModel> list);
        void ReceiveR202DataFromManager(List<PG300DiagnosticsModel> list);
    }
}

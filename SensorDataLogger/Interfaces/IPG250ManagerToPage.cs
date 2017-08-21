using SensorDataLogger.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorDataLogger.Interfaces
{
    public interface IPG250ManagerToPage
    {
        void ReceiveR01DataFromManager(List<PG250ChannelModel> list);
        void ReceiveR23DataFromManager(PG250DiagnosticsModel model);
    }
}

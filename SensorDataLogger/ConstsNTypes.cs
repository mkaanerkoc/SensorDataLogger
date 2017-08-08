using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorDataLogger
{
    public class ConstsNTypes
    {
        public enum FrameFormatTypes
        {
            ModbusRTU,
            ModbusTCP,
            ModbusASCII,
            CSV,
            CanBusA,
            CanbusB,
            CustomFrameFormat
        }

        public enum DeviceProtocolTypes
        {
            RS232,
            RS422,
            RS485,
            TCP,
            UDP,
            SPI,
            I2C
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorDataLogger.StructObjects
{
    public static class AppConstants
    {
        public static byte PG250_TYPE = 1;
        public static byte PG300_TYPE = 2;

        public static int PG300_UDP_PORT = 60300;

        public static char PG250_SPLITTER_CHAR = ',';
        public static char PG300_SPLITTER_CHAR = ',';


        public static byte MAXIMUM_BUFFER_SIZE = 10;
        public static byte INITIAL_LOG_ROW = 12;

        public static readonly ReadOnlyCollection<string> PG250_HEADERS = new ReadOnlyCollection<string>(
          new string[] {
                "Saat",
                "Tarih",
                "NO",
                "NOx",
                "Correlated NO",
                "Correlated NOx",
                "CO",
                "CO2",
                "O2",
                "SO2",
                "Correlated SO2"
          }
        );
        public static readonly ReadOnlyCollection<string> PG300_HEADERS = new ReadOnlyCollection<string>(
          new string[] {
                "Saat",
                "Tarih",
                "NO",
                "NOx",
                "Correlated NO",
                "Correlated NOx",
                "CO",
                "CO2",
                "O2",
                "SO2",
                "Correlated SO2",
                "CO2",
                "O2",
                "SO2",
                "Correlated SO2"
          }
        );
    }
}

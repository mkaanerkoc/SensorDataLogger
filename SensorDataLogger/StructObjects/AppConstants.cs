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
        public static byte PG250_TYPE = 0;
        public static byte PG300_TYPE = 1;

        public static int PG300_UDP_PORT = 60300;

        public static char PG250_SPLITTER_CHAR = ',';
        public static char PG300_SPLITTER_CHAR = ',';


        public static byte MAXIMUM_BUFFER_SIZE = 10;
        public static byte INITIAL_LOG_ROW = 11;

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
                "Correlated SO2",
                "Sample Flow Rate",
                "NDIR Temperature"
          }
        );
        public static readonly ReadOnlyCollection<string> PG300_HEADERS = new ReadOnlyCollection<string>(
          new string[] {
                "Saat",
                "Tarih",
                "NO", //channel no 1 
                "Converted NO", //channel no 2
                "NO integrated (moving average)", //channel no 3
                "Converted NO integrated (moving average)", //channel no 4
                "NOx", //channel no 9
                "Converted NOx",//channel no 10
                "NOx integration (moving average)",//channel no 11
                "Converted NOx accumulated (moving average)",//channel no 12
                "SO2", //channel no 13
                "Converted SO2", //channel no 14
                "SO2 accumulated (moving average)", //channel no 15
                "Converted SO2 accumulated (moving average)", //channel no 16
                "CO", //channel no 21
                "Converted CO", //channel no 22
                "CO accumulated (moving average)", //channel no 23
                "Converted CO accumulated (moving average)", //channel no 24
                "CO2", //channel no 25
                "CO2 accumulated (moving average)", //channel no 27
                "O2 concentration", //channel no 29
                "O2 accumulated (moving average)", //channel no 31
                "NDIR correction temperature",
                "O2 control temperature",
                "CLA control temperature",
                "NDIR control temperature",
                "Internal temperature",
                "Electronic cooler temperature",
                "Atmospheric pressure data(hPa)",
                "Flow rate data (L/min)"
            }
        );
        public static string ConfigurationFilePath = @"SensorConfiguration/AppParams.xml";
    }
}

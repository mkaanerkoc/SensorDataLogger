using SensorDataLogger.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorDataLogger.Screens
{

    public sealed partial class SensorReadingForm : Form
    {
        
        private PG250Page pg250Page;
        private PG300Page pg300Page;
       
        private string deviceName;

        public SensorReadingForm(string deviceName)
        {
            InitializeComponent();
            if (deviceName.Equals("PG250"))
            {
                pg250Page = new PG250Page();
                pg250Page.Show();
                //sensorContent.Controls.Add(pg250Page);
            }
            else if(deviceName.Equals("PG300"))
            {
                pg300Page = new PG300Page();
                pg300Page.Show();
            }
            /*pg250Page = new PG250Pageee();
            sensorContent.Controls.Add(pg250Page);*/

        }

       

        delegate void updatePG250ChannelTableDelegate(PG250 pg250);
        

        delegate void updatePG250StatusTableDelegate();
        
    }
}

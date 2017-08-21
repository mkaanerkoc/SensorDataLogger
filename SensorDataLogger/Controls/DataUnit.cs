using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorDataLogger.Controls
{
    public partial class DataUnit : UserControl
    {
        public int CodeType { get; set; }
        public string Label
        {
            get
            {
                return ContainerBox.Text;
            }
            set
            {
                ContainerBox.Text = value;
            }
        }
        public float Range
        {
            get
            {
                return Gauge.MaxValue;
            }
            set
            {
                Gauge.ScaleLinesMajorStepValue = value / 4;
                Gauge.MaxValue = value;
                
            }
        }
        public double Value
        {
            get
            {
                return Gauge.Value;
            }
            set
            {
                Gauge.Value = (float)value;
                ValueLabel.Text = value.ToString();
            }
        }
        public string Unit
        {
            get
            {
                return unitLabel.Text;
            }
            set
            {
                unitLabel.Text = value;
            }
        }

        public DataUnit()
        {
            InitializeComponent();
        }
    }
}

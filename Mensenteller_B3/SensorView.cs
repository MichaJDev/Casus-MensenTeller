using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mensenteller_B3.Sensors.DrukSensors;
using Mensenteller_B3.Sensors.EntreeSensors;

namespace Mensenteller_B3
{
    public partial class SensorView : BaseForm
    {
        EntreeSensor es;
        DrukSensor ds;

        public SensorView()
        {
            InitializeComponent();
        } 
        public SensorView(EntreeSensor s)
        {
            es = s;
            InitializeComponent();
        }
        public SensorView(DrukSensor s)
        {
            ds = s;
            InitializeComponent();
        }

        private void SensorView_Load(object sender, EventArgs e)
        {
            if (es != null)
            {
                SensorLabel.Text = es.Name;
            }
            else if ( ds != null)
            {
                SensorLabel.Text = ds.Name;
            }
        }

        private void SensorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

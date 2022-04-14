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
using MensenTeller_B3.Sensors;
using MensenTeller_B3.Zones;

namespace Mensenteller_B3
{
    public partial class SensorView : Form
    {
        private EntreeSensor Entreesensor;
        private DrukSensor Druksensor;


        EntreeSensorDAL EntreeDal = new EntreeSensorDAL();
        DruksensorDAL DrukDal = new DruksensorDAL();    

        public SensorView(Sensor s)
        {
            EntreeDal.ReadEntreeSensors();
            DrukDal.ReadDrukSensor();
            foreach(EntreeSensor e in EntreeDal.EntreeSensors)
            {
                if (e.SensorID == s.ID)
                {
                    Entreesensor = e ;
                    
                }
            }
            foreach (DrukSensor e in DrukDal.druksensorlist)
            {
                if (e.SensorId == s.ID)
                {
                    Druksensor = e;

                }
            }

            InitializeComponent();
        }

        private void SensorView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Sensor.Sensors' table. You can move, or remove it, as needed.
            this.sensorsTableAdapter.Fill(this.dataSet_Sensor.Sensors);

        }
    }
}

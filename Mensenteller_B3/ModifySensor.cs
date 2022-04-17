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
    public partial class ModifySensor : Form
    {
        EntreeSensorDAL entreeSenorDAL = new EntreeSensorDAL();
        DruksensorDAL drukSensorDAL = new DruksensorDAL();
        EntreeSensor entree = new EntreeSensor();
        DrukSensor druk = new DrukSensor();


        int sensorId;
        public ModifySensor(int _sensorId)
        {
            sensorId = _sensorId;

            InitializeComponent();
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            CreateSensor createSensor = new CreateSensor();
            createSensor.Show();
        private void ModifySensor_Load(object sender, EventArgs e)
        {


            foreach (EntreeSensor es in entreeSenorDAL.ReadEntreeSensors(sensorId))
            {
                if (es.SensorID == sensorId)
                {
                    entree = es;

                }
            }
            foreach (DrukSensor ds in drukSensorDAL.ReadDrukSensor(sensorId))
            {
                if (ds.SensorId == sensorId)
                {
                    druk = ds;

                }
            }

            if (entree != null)
            {
                InUseCheckBox.Hide();
                EntreeIdTextBox.Text = entree.SensorID.ToString();
                PeopleInTextBox.Text = entree.PeopleIn.ToString();
                PeopleOutTextBox.Text = entree.PeopleOut.ToString();
                if (entree.TimeStamp != null)
                {
                    DateTimeTextBox.Text = entree.TimeStamp;
                }
                else 
                {
                    DateTimeTextBox.Text = "No DATA FOUND!!!!!!!!!!!";
                }

            }
            else if (druk != null)
            {
                PeopleInTextBox.Hide();
                PeopleOutTextBox.Hide();
                EntreeIdTextBox.Text = druk.SensorId.ToString();
                InUseCheckBox.Checked = druk.InUse;
                DateTimeTextBox.Text = druk.TimeStamp.ToString();
            }

        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {
            if (entree != null)
            {
                EntreeSensor es = new EntreeSensor
                {
                    SensorID = Int32.Parse(EntreeIdTextBox.Text),
                    PeopleIn = Int32.Parse(PeopleInTextBox.Text),
                    PeopleOut = Int32.Parse(PeopleOutTextBox.Text),
                    TimeStamp = entree.TimeStamp
                };

                entreeSenorDAL.Update(es);

            }
            else if (druk != null)
            {
                DrukSensor ds = new DrukSensor
                {
                    SensorId = Int32.Parse(EntreeIdTextBox.Text),
                    InUse = InUseCheckBox.Checked,
                    TimeStamp = druk.TimeStamp

                };

                drukSensorDAL.EditDrukSensor(0, ds.SensorId, ds.InUse, ds.TimeStamp);
               
            }
        }
        
        private void ButtonDelete_Click(object sender, EventArgs e)
        {

        }
    }
}

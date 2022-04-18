using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mensenteller_B3.Sensors;
using Mensenteller_B3.Sensors.DrukSensors;
using Mensenteller_B3.Sensors.EntreeSensors;
using MensenTeller_B3.Sensors;

namespace Mensenteller_B3
{
    public partial class ModifySensor : BaseForm
    {
        EntreeSensorDAL entreeSensorDAL = new EntreeSensorDAL();
        DruksensorDAL drukSensorDAL = new DruksensorDAL();
        EntreeSensor entree = new EntreeSensor();
        DrukSensor druk = new DrukSensor();

        SensorDAL sensorDAL = new SensorDAL();

        int locatieId;
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


        private void ModifySensor_Load(object sender, EventArgs e)
        {



            foreach (EntreeSensor es in entreeSensorDAL.ReadEntreeSensors()) 
            {
                Sensor se = sensorDAL.GetSensor(sensorId);
                if (es.SensorID == sensorId)
                {

                    locatieId = se.LocatieID;
                    entree = entreeSensorDAL.ReadEntreeSensor(sensorId);

                    InUseCheckBox.Hide();
                    EntreeIdTextBox.Text = es.SensorID.ToString();
                    PeopleInTextBox.Text = es.PeopleIn.ToString();
                    PeopleOutTextBox.Text = es.PeopleOut.ToString();
                    if (es.TimeStamp != null)
                    {
                        DateTimeTextBox.Text = es.TimeStamp;
                    }
                    else
                    {
                        DateTimeTextBox.Text = "No DATA FOUND!!!!!!!!!!!";
                    }

                }
            }
            Sensor s = sensorDAL.GetSensor(sensorId);
            foreach (DrukSensor ds in drukSensorDAL.ReadDrukSensor())
            {
                if (ds.SensorId == sensorId)
                {
                    druk = drukSensorDAL.GetDrukSensor(sensorId);
                    locatieId = s.LocatieID;

                    PeopleInTextBox.Hide();
                    PeopleOutTextBox.Hide();
                    EntreeIdTextBox.Text = ds.SensorId.ToString();
                    InUseCheckBox.Checked = ds.InUse;
                    DateTimeTextBox.Text = ds.TimeStamp.ToString();

                }
            }


        }


        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Sensor s = sensorDAL.GetSensor(sensorId);
            if (entree != null)
            {

                CreateSensor createSensor = new CreateSensor(s.LocatieID);
                createSensor.ShowDialog();
                LoadContent();
            }
            else if (druk != null)
            {

                CreateSensor createSensor = new CreateSensor(s.LocatieID);
                createSensor.Show();
                LoadContent();
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

                entreeSensorDAL.Update(es);

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

        private void ButtonDone_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadContent()
        {

            foreach (EntreeSensor es in entreeSensorDAL.ReadEntreeSensors())
            {
                Sensor se = sensorDAL.GetSensor(sensorId);
                if (es.SensorID == sensorId)
                {

                    locatieId = se.LocatieID;
                    entree = entreeSensorDAL.ReadEntreeSensor(sensorId);

                    InUseCheckBox.Hide();
                    EntreeIdTextBox.Text = es.SensorID.ToString();
                    PeopleInTextBox.Text = es.PeopleIn.ToString();
                    PeopleOutTextBox.Text = es.PeopleOut.ToString();
                    if (es.TimeStamp != null)
                    {
                        DateTimeTextBox.Text = es.TimeStamp;
                    }
                    else
                    {
                        DateTimeTextBox.Text = "No DATA FOUND!!!!!!!!!!!";
                    }

                }
            }
            Sensor s = sensorDAL.GetSensor(sensorId);
            foreach (DrukSensor ds in drukSensorDAL.ReadDrukSensor())
            {
                if (ds.SensorId == sensorId)
                {
                    druk = drukSensorDAL.GetDrukSensor(sensorId);
                    locatieId = s.LocatieID;

                    PeopleInTextBox.Hide();
                    PeopleOutTextBox.Hide();
                    EntreeIdTextBox.Text = ds.SensorId.ToString();
                    InUseCheckBox.Checked = ds.InUse;
                    DateTimeTextBox.Text = ds.TimeStamp.ToString();

                }
            }

        }
    }

}

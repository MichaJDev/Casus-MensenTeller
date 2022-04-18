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
using MensenTeller_B3.Simualtion_DAL;

namespace Mensenteller_B3
{

    

    
    public partial class CreateSensor : BaseForm
    {
        SensorDAL dalsensor = new SensorDAL();
        EntreeSensorDAL entreeSensorDAL = new EntreeSensorDAL();
        DruksensorDAL drukSensorDAL = new DruksensorDAL();

        int LocatieId;
        int selectedIndex;
        int selectedValue;
        public CreateSensor()
        {
            InitializeComponent();
        }

        public CreateSensor(int _locatieId)
        {
            LocatieId = _locatieId;
            InitializeComponent();
        }
        /*
         * * Creat SensorsButton takes selected value from ComboBox that is loaded with al pre saved sensors from the first run of simData. 
         * This way you can link Sensors with the Data that will be fed to the database from SensorData and adds the new sensors relevant to the sensorId in the Sensors table for 
         * complete connection from our application to the simulator data.
         */
       
        private void CreateSensorbutton_Click(object sender, EventArgs e)
        {
            string name = EditNaamsensortextbox.Text;
            Sensor s = new Sensor(selectedValue, name, LocatieId);
            dalsensor.Create(s);
            MessageBox.Show($"" +
                $"| {s.ID} | {s.Name} | {s.LocatieID} |\nHas been saved!");
            this.sensorsTableAdapter.Fill(this.dataSet_Sensors123.Sensors);
        }
        /*
         * Edit Sensors takes selected value from ComboBox that is loaded with al pre saved sensors from the first run of simData. 
         * This way you can link Sensors with the Data that will be fed to the database from SensorData
         * And makes it able to be edited in our database for further transparency
         */
        private void EditSensorbutton_Click(object sender, EventArgs e)
        {
            string name = EditNaamsensortextbox.Text;
            Sensor s = new Sensor(selectedValue, name, LocatieId);
            dalsensor.Update(s);
            MessageBox.Show("| {s.ID} | {s.Name} | {s.LocatieID} |\nHas been Updated");
            this.sensorsTableAdapter.Fill(this.dataSet_Sensors123.Sensors);

        }
        //Closes the form
        private void ButtonDone_Click(object sender, EventArgs e)
        {
            Close();


        }
        //See if checkbox has changed so we switch Entree and Druksensor creation
        private void CheckBoxEntree_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxEntree.Checked)
            {
                CheckBoxDruk.Checked = false;
                
                // List Dal maken van entree en druk
                foreach(EntreeSensor es in entreeSensorDAL.ReadEntreeSensors())
                {
                    ComboBox.Items.Add(es.SensorID.ToString());
                }
            }
        }
        //See if checkbox has changed so we switch Entree and Druksensor creation
        private void CheckBoxDruk_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxDruk.Checked)
            {
                CheckBoxEntree.Checked = false;
                drukSensorDAL.ReadDrukSensor();
                foreach (DrukSensor ds in drukSensorDAL.druksensorlist)
                {
                    ComboBox.Items.Add(ds.SensorId.ToString());
                }
            }
        }
        //Loads the complete sensor data table so we can read which already have been created or need to be edited
        private void CreateSensor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Sensors123.Sensors' table. You can move, or remove it, as needed.
            this.sensorsTableAdapter.Fill(this.dataSet_Sensors123.Sensors);

        }
        //To retrieve the selected index and Value selected from the combobox
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = ComboBox.SelectedIndex;
            selectedValue = (int)ComboBox.SelectedValue;
        }
    }
}

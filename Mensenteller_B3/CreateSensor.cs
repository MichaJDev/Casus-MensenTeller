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
        public CreateSensor()
        {
            InitializeComponent();
        }

        public CreateSensor(int _locatieId)
        {
            LocatieId = _locatieId;
            InitializeComponent();
        }
        private void CreateSensorbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void EditSensorbutton_Click(object sender, EventArgs e)
        {
            /*
            string Name = EditNaamsensortextbox.Text;
            //int id = int.Parse();//comboboxselectedshithiering
            //Sensor sensor= new Sensor(id, Name);
            //dalsensor.Update(sensor);


            MessageBox.Show("Updated");
            */
            
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            Close();
        }

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

        private void CreateSensor_Load(object sender, EventArgs e)
        {

        }
    }
}

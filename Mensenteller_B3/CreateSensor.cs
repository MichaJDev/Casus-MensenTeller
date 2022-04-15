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
using MensenTeller_B3.Sensors;
using MensenTeller_B3.Simualtion_DAL;

namespace Mensenteller_B3
{

    

    
    public partial class CreateSensor : Form
    {
        SensorDAL dalsensor = new SensorDAL();
        public CreateSensor()
        {
            InitializeComponent();
        }

        private void CreateSensorbutton_Click(object sender, EventArgs e)
        {
            if (CreatSensorNatextbox.Text != "")
            {
                string Name = CreatSensorNatextbox.Text;
                Sensor sensor = new Sensor(0, Name);
                dalsensor.Create(sensor);

                CreatSensorNatextbox.Text = "";
                MessageBox.Show("Saved");
                // TODO: This line of code loads data into the 'dataSet_Zones.Zones' table. You can move, or remove it, as needed.
                //this.locatiesTableAdapter.Fill(this.dataSet_Locaties.Locaties);
               
            }
        }

        private void EditSensorbutton_Click(object sender, EventArgs e)
        {
            string Name = EditNaamsensortextbox.Text;
            int id = int.Parse(SensorIdtextbox.Text);
            Sensor sensor= new Sensor(id, Name);
           dalsensor.Update(sensor);


            MessageBox.Show("Updated");
            
        }
    }
}

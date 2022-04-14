using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< Updated upstream
=======
using MensenTeller_B3.Sensors;
>>>>>>> Stashed changes

namespace Mensenteller_B3
{
    public partial class CreateSensor : Form
    {
        public CreateSensor()
        {
            InitializeComponent();
        }
<<<<<<< Updated upstream
=======

        private void CreateSensorbutton_Click(object sender, EventArgs e)
        {
            if (CreateSensortextbox.Text != "")
            {

                // DAL Sensor nodig...
                string Name = CreateSensortextbox.Text;
                Sensor sensor = new Sensor(0, Name);
               // dal.CreateS(sensor);

                //CreateLocatietextbox.Text = "";
                //MessageBox.Show("Saved");
                // TODO: This line of code loads data into the 'dataSet_Zones.Zones' table. You can move, or remove it, as needed.
                //this.locatiesTableAdapter.Fill(this.dataSet_Locaties.Locaties);
               // this.locatiesTableAdapter1.Fill(this.dataSet_Locaties1.Locaties);
            }
        }
>>>>>>> Stashed changes
    }
}

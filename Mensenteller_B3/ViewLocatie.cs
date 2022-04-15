using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mensenteller_B3.Locaties;
using Mensenteller_B3.Sensors;
using Mensenteller_B3.Sensors.DrukSensors;
using Mensenteller_B3.Sensors.EntreeSensors;
using MensenTeller_B3.Sensors;

namespace Mensenteller_B3
{
    public partial class ViewLocatie : Form
    {
        private Locatie locatie;

        SensorDAL sensorDal = new SensorDAL();
        EntreeSensorDAL eSensorDal = new EntreeSensorDAL();
        DruksensorDAL dSensorDal = new DruksensorDAL();
        LocatieDAL locatiedal = new LocatieDAL();
        public ViewLocatie(Locatie l)
        {
            locatie = l;
            InitializeComponent();
        }

        private void ViewLocatie_Load(object sender, EventArgs e)
        {
            List<EntreeSensor> eSensorList = new List<EntreeSensor>();
            List<DrukSensor> dSensorList = new List<DrukSensor>();
            foreach (Sensor s in sensorDal.ReadSensors(locatie.ID))
            {
                eSensorList = eSensorDal.ReadEntreeSensors().Where(x => x.SensorID == s.ID).ToList();
            }
            DvgEntreeSensors.DataSource = eSensorList;
            foreach (Sensor s in sensorDal.Sensors)
            {
                dSensorList = dSensorDal.ReadDrukSensor().Where(x => x.SensorId == s.ID).ToList();
            }
            DvgDrukSensors.DataSource = dSensorList;

        }

        private void DgvviewLocatie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewLocatieButton_Click(object sender, EventArgs e)
        {
            string id = DvgEntreeSensors.CurrentRow.Cells[0].Value.ToString();

            int pid = int.Parse(id);
            locatiedal.ReadLocatie();
            Locatie l = locatiedal.Locaties.Where(X => X.ID == pid).First();
            //ToDO              opnieuw toevoegen!!!
            //this.locatiesTableAdapter.Fill(this.dataSet_LocatiesView.Locaties);
            LocatieView form = new LocatieView(l);
            form.Show();

        }
    }
}

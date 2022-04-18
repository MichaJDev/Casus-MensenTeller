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

namespace Mensenteller_B3
{
    public partial class ModifyLocation : BaseForm
    {
        int LocatieId;
        int zoneId;
        SensorDAL sensordal = new SensorDAL();
        public ModifyLocation(int _locatieId, int _zoneId)
        {
            LocatieId = _locatieId;
            zoneId = _zoneId;
            InitializeComponent();
        }
        //Open CreateWindow for creating a new location 
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            
            CreateSensor createSensor = new CreateSensor(LocatieId);
            createSensor.ShowDialog();
            DataGridViewSensors.DataSource = sensordal.ReadSensors(LocatieId);
        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {

            string StringSensorId = DataGridViewSensors.CurrentRow.Cells[0].Value.ToString();
            int SensorId = int.Parse(StringSensorId);

            ModifySensor modifySensor = new ModifySensor(SensorId);
            modifySensor.ShowDialog();
            DataGridViewSensors.DataSource = sensordal.ReadSensors(LocatieId);
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModifyLocation_Load(object sender, EventArgs e)
        {
            //.Text = "Bedrijf: " + BedrijfNaam + "Bedrijf Id: " + BedrijfId + "Zone: " + ZoneNaam + " Zone Id: " + ZoneId;
            DataGridViewSensors.DataSource = sensordal.ReadSensors(LocatieId);
            
        }
    }
}

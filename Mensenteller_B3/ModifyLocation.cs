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
    public partial class ModifyLocation : Form
    {
        int zoneId ;
        SensorDAL sensordal = new SensorDAL();
        public ModifyLocation(int _zoneId )
        {
            zoneId = _zoneId;
            InitializeComponent();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            
            CreateLocatie createLocatie = new CreateLocatie();
            createLocatie.Show();
        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {
            ModifySensor modifySensor = new ModifySensor(zoneId);
            modifySensor.Show();
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModifyLocation_Load(object sender, EventArgs e)
        {
            //.Text = "Bedrijf: " + BedrijfNaam + "Bedrijf Id: " + BedrijfId + "Zone: " + ZoneNaam + " Zone Id: " + ZoneId;
            DataGridViewSensors.DataSource = sensordal.ReadSensors(zoneId);
            
        }
    }
}

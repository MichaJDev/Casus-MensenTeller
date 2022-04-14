using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MensenTeller_B3.Zones;

namespace Mensenteller_B3
{
    public partial class CreateZones : Form
    {
        DALZone dal = new DALZone();
        public CreateZones()
        {
            InitializeComponent();
            //dal.ReadZone();
        }
        

        private void CreateZones_Load(object sender, EventArgs e)
        {

            this.zonesTableAdapter.Fill(this.dataSet_Zones.Zones);
            
        }

        private void CreateZonebutton_Click(object sender, EventArgs e)
        {
            if (CreateZonetextbox.Text != "")
            {
                string Name = CreateZonetextbox.Text;
                Zone zone = new Zone(0, Name);
                dal.CreateZone(zone);

                CreateZonetextbox.Text = "";
                MessageBox.Show("Saved");
                // TODO: This line of code loads data into the 'dataSet_Zones.Zones' table. You can move, or remove it, as needed.
                this.zonesTableAdapter.Fill(this.dataSet_Zones.Zones);
            }
        }

        private void EditZonebutton_Click(object sender, EventArgs e)
        {
            string Name = ZoneNameEdit.Text;
            int id = int.Parse(IdZonetextbox.Text);
            dal.EditZone(id, Name);
            this.zonesTableAdapter.Fill(this.dataSet_Zones.Zones);
            MessageBox.Show("Updated");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

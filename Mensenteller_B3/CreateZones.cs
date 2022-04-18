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
    public partial class CreateZones : BaseForm
    {

        DALZone dal = new DALZone();
        public CreateZones()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CreateZonebutton_Click(object sender, EventArgs e)
        {
            if (CreateZoneNatextbox.Text != "")
            {
                string Name = CreateZoneNatextbox.Text;
              
                Zone zone= new Zone(0, Name);
                dal.CreateZone(zone);

                CreateZoneNatextbox.Text = "";
                MessageBox.Show("Saved");
                
            }
        }

        private void EditZonebutton_Click(object sender, EventArgs e)
        {
            string Name = ZoneNaamEdittextbox.Text;
            int id = int.Parse(ZoneEditIdtextbox.Text);
            dal.EditZone(id, Name);
            MessageBox.Show("Updated");
        }

        private void CreateZones_Load(object sender, EventArgs e)
        {

        }

        private void ButtondDone_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

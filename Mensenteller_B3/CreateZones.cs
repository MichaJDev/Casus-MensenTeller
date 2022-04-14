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
        int BedrijfId { get; set; }
        string BedrijfNaam { get; set; }
        public CreateZones(int id, string name)
        {
            this.BedrijfId = id;
            this.BedrijfNaam = name;
            InitializeComponent();
            dal.ReadZone();
            dataGridView1.DataSource = dal.ZoneList.Where(x => x.BedrijvenId == id).ToList();
        }

        public CreateZones()
        {
            InitializeComponent();
        }
        

        private void CreateZones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mensentellerDataSet8.Zones' table. You can move, or remove it, as needed.
            
            dal.ReadZone();
            dataGridView1.DataSource = dal.ZoneList.Where(x => x.BedrijvenId == BedrijfId).ToList();

        }

        private void CreateZonebutton_Click(object sender, EventArgs e)
        {
            if (CreateZonetextbox.Text != "")
            {
                string Name = CreateZonetextbox.Text;
                Zone zone = new Zone(Name, BedrijfId);
                dal.CreateZone(zone);

                CreateZonetextbox.Text = "";
                MessageBox.Show("Saved");
                //this.zonesTableAdapter2.Fill(this.mensentellerDataSet8.Zones);
            }
        }

        private void EditZonebutton_Click(object sender, EventArgs e)
        {
            string Name = ZoneNameEdit.Text;
            int id = int.Parse(IdZonetextbox.Text);
            dal.EditZone(id, Name);
            //this.zonesTableAdapter2.Fill(this.mensentellerDataSet8.Zones);
            MessageBox.Show("Updated");
        }

        private void ButtondDone_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

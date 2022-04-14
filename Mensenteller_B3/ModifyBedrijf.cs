using MensenTeller_B3.Zones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mensenteller_B3
{
    public partial class ModifyBedrijf : Form
    {
        DALZone dal = new DALZone();
        public int Id { get; set; }
        public ModifyBedrijf(int id)
        {
            Id = id;
            InitializeComponent();
        }

        public ModifyBedrijf()
        {
            InitializeComponent();
        }

        private void ModifyBedrijf_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mensentellerDataSet5.Zones' table. You can move, or remove it, as needed.
            this.zonesTableAdapter1.Fill(this.mensentellerDataSet5.Zones);
            // TODO: This line of code loads data into the 'mensentellerDataSet3.Zones' table. You can move, or remove it, as needed.
            this.zonesTableAdapter.Fill(this.mensentellerDataSet3.Zones);

        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            CreateZones createZones = new CreateZones();
            createZones.Show();
        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {
            ModifyZones modifyZones = new ModifyZones();
            modifyZones.Show();
        }

        private void DataGridViewZones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            string id = DataGridViewZones.CurrentRow.Cells[0].Value.ToString();
            int pid = int.Parse(id);
            dal.DeleteZone(pid);
            this.zonesTableAdapter1.Fill(this.mensentellerDataSet5.Zones);

        }
    }
}

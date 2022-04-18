using Mensenteller_B3.Bedrijven;
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
    public partial class ModifyBedrijf : BaseForm
    {
        DALZone zoneDAL = new DALZone();
        public int BedrijfId { get; set; }
        public string BedrijfNaam { get; set; }

        public ModifyBedrijf(int id, string name)
        {
            BedrijfId = id;
            BedrijfNaam = name;
            InitializeComponent();
            TextBoxAdress.Text = "Bedrijf: " + BedrijfNaam + " ID = " + BedrijfId;
        }

        public ModifyBedrijf(int id)
        {
            BedrijfId = id;
            InitializeComponent();
        }

        public ModifyBedrijf()
        {
            InitializeComponent();
        }

        private void ModifyBedrijf_Load(object sender, EventArgs e)
        {
            zoneDAL.ReadZoneByBedrijfId(BedrijfId);
            DataGridViewZones.DataSource = zoneDAL.ZoneList;

        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {

            CreateZones createZones = new CreateZones(BedrijfId);

            createZones.Show();

        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {
            string stringzoneId = DataGridViewZones.CurrentRow.Cells[0].Value.ToString();
            string zoneNaam = DataGridViewZones.CurrentRow.Cells[1].Value.ToString();
            string stringbedrijfId = DataGridViewZones.CurrentRow.Cells[2].Value.ToString();
            int zoneId = int.Parse(stringzoneId);
            int bedrijfId = int.Parse(stringbedrijfId);

            zoneDAL.ReadZoneByBedrijfId(bedrijfId);
            Zone zone = zoneDAL.ReadZone(bedrijfId);
            ModifyZones modifyZones = new ModifyZones(BedrijfNaam, zone.BedrijvenId, zone.Name, zoneId);
            modifyZones.Show();
        }

        private void DataGridViewZones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            Close();
            CreateModify createModify = new CreateModify();
            createModify.Show();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            string id = DataGridViewZones.CurrentRow.Cells[0].Value.ToString();
            int pid = int.Parse(id);
            zoneDAL.DeleteZone(pid);
            //this.zonesTableAdapter1.Fill(this.mensentellerDataSet5.Zones);

        }

        private void TextBoxAdress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

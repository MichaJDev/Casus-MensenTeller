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
using MensenTeller_B3.Zones;

namespace Mensenteller_B3
{
    public partial class ModifyZones : BaseForm
    {
        public string BedrijfNaam { get; set; }
        public int BedrijfId { get; set; }
        public string ZoneNaam { get; set; }
        public int ZoneId { get; set; }
        
        
        LocatieDAL dal = new LocatieDAL();
        
        public ModifyZones()
        {
            InitializeComponent();
        }
        public ModifyZones(string bedrijfNaam, int bedrijfId, string zoneNaam, int zoneId)
        {
            this.BedrijfNaam = bedrijfNaam;
            this.BedrijfId = bedrijfId;
            this.ZoneNaam = zoneNaam;
            this.ZoneId = zoneId;
            
            InitializeComponent();
        }

        private void ModifyZones_Load(object sender, EventArgs e)
        {
            TextBoxAdress.Text = "Bedrijf: " + BedrijfNaam + "Bedrijf Id: " + BedrijfId + "Zone: " + ZoneNaam + " Zone Id: " + ZoneId;
            
            DataGridViewZones.DataSource = dal.ReadLocatieById(ZoneId) ;

        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {

            
            CreateLocatie createLocatie = new CreateLocatie(ZoneId);
            createLocatie.ShowDialog();
            DataGridViewZones.DataSource = dal.ReadLocatieById(ZoneId);
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            Close();            
        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {
            string stringlocationId = DataGridViewZones.CurrentRow.Cells[0].Value.ToString();
            int id = int.Parse(stringlocationId);
            ModifyLocation modifyLocation = new ModifyLocation(id, ZoneId);
            modifyLocation.ShowDialog();
            DataGridViewZones.DataSource = dal.ReadLocatieById(ZoneId);
        }

        private void TextBoxAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanelModifyBedrijf_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
    public partial class ModifyZones : Form
    {
        public string BedijfNaam { get; set; }
        public int BedrijfId { get; set; }
        public string ZoneNaam { get; set; }
        public int ZoneId { get; set; }
        public ModifyZones()
        {
            InitializeComponent();
        }
        public ModifyZones(string bedrijfNaam, int bedrijfId, string zoneNaam, int zoneId)
        {
            this.BedijfNaam = bedrijfNaam;
            this.BedrijfId = bedrijfId;
            this.ZoneNaam = zoneNaam;
            this.ZoneId = zoneId;
            TextBoxAdress.Text = "Berijf: " + bedrijfNaam + "Bedrijf Id: " + bedrijfId + "Zone: " + zoneNaam + " Zone Id: " + zoneId;
            InitializeComponent();
        }

        private void ModifyZones_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            CreateLocatie createLocatie = new CreateLocatie();
            createLocatie.Show();
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            Close();            
        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {
            ModifyLocation modifyLocation = new ModifyLocation();
            modifyLocation.Show();
        }

        private void TextBoxAdress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class ViewZone : Form
    {
        private Zone zone;
        
        DALZone dalzone = new DALZone();
        LocatieDAL locatiedal = new LocatieDAL();
        public ViewZone(Zone z)
        {
            zone = z;
            InitializeComponent();
        }

        private void ViewZone_Load(object sender, EventArgs e)
        {
            // label toevoegen hier!!
            locatiedal.ReadLocatie();
            DgvZoneview.DataSource = locatiedal.Locaties.Where(x => x.ZoneId == zone.ID).ToList();
        }

        private void ViewZonebutton_Click(object sender, EventArgs e)
        {
            string id = DgvZoneview.CurrentRow.Cells[0].Value.ToString();
            int pid = int.Parse(id);
            dalzone.ReadZone();
            Zone z = dalzone.ZoneList.Where(X => X.ID == pid).First();
            //ToDo voegg deze opnieuw Toe!
            //this.zonesTableAdapter.Fill(this.dataSet_Zones1.Zones);
            ViewZone form = new ViewZone(z);
            form.Show();
        }
    }
}

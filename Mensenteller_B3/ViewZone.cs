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
    public partial class ViewZone : BaseForm
    {
        private Zone zone;
        
        
        LocatieDAL locatiedal = new LocatieDAL();
        public ViewZone(Zone z)
        {
            zone = z;
            InitializeComponent();
        }

        private void ViewZone_Load(object sender, EventArgs e)
        {
            // label toevoegen hier!!
           
            DgvZoneview.DataSource = locatiedal.ReadLocatie(zone.ID);
        }

        private void ViewZonebutton_Click(object sender, EventArgs e)
        {
            string id = DgvZoneview.CurrentRow.Cells[0].Value.ToString();
            int pid = int.Parse(id);
            Locatie l = new Locatie(pid);
            ViewLocatie form = new ViewLocatie(l);
            form.ShowDialog();
            DgvZoneview.DataSource = locatiedal.ReadLocatie(zone.ID);
        }
    }
}

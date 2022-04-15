using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mensenteller_B3.Bedrijven;
using MensenTeller_B3.Zones;

namespace Mensenteller_B3
{
    
    public partial class ViewBedrijf : Form
    {
        DALZone zonedal = new DALZone();
        private Bedrijf bedrijf;

        public ViewBedrijf(Bedrijf b)
        {
            bedrijf = b;
            InitializeComponent();
        }

        private void ViewBedrijf_Load(object sender, EventArgs e)
        {
            //LBLname.Text = bedrijf.Name;
            zonedal.ReadZone(bedrijf.Id);
            DgvBedrijfview.DataSource = zonedal.ZoneList;
        }

        private void BedrijfView_Click(object sender, EventArgs e)
        {
            string id = DgvBedrijfview.CurrentRow.Cells[0].Value.ToString();
            int pid = int.Parse(id);
            Zone z = new Zone(pid);
            ViewZone form = new ViewZone(z);
            form.Show();
            
        }

        private void DgvBedrijfview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

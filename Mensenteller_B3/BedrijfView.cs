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
    public partial class BedrijfViewButton : Form
    {
        DALZone zonedal = new DALZone();

        private Bedrijf bedrijf;
        int rowID = 0;
        int rowIndexInt = 0;

       

        public BedrijfViewButton(Bedrijf b)
        {
            bedrijf = b;
            InitializeComponent();
        }

        private void BedrijvViewbutton_Click(object sender, EventArgs e)
        {
            string id = DgvBedrijfview.CurrentRow.Cells[0].Value.ToString();
            int pid = int.Parse(id);
           
        }

        private void BedrijfViewButton_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Bedrijven1.Bedrijven' table. You can move, or remove it, as needed.
           
            LBLname.Text = bedrijf.Name;
            zonedal.ReadZone();
            DgvBedrijfview.DataSource = zonedal.ZoneList.Where(x => x.BedrijvenId == bedrijf.Id).ToList();
        }

        private void DgvBedrijfview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

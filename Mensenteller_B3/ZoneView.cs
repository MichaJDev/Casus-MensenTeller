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
    public partial class ZoneView : Form
    {
        private Zone zone;
        int rowID = 0;
        int rowIndexInt = 0;
        DALZone dalzone = new DALZone();
        LocatieDAL locatiedal = new LocatieDAL();

        //LocatieDAL locatiedal = new LocatieDAL();
        public ZoneView(Zone z)
        {
            zone = z;
            InitializeComponent();
        }

        private void ZoneViewButton_Click(object sender, EventArgs e)
        {
            string id = DgvZoneview.CurrentRow.Cells[0].Value.ToString();
            int pid = int.Parse(id);
            dalzone.ReadZone();
            Zone z = dalzone.ZoneList.Where(X => X.ID == pid).First();
            this.zonesTableAdapter.Fill(this.dataSet_Zones1.Zones);
            ZoneView form = new ZoneView(z);
            form.Show();
        }

        private void DgvZoneview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewCell cell = (DataGridViewCell)DgvZoneview.Rows[e.RowIndex].Cells[e.ColumnIndex];
                rowID = (int)cell.Value;
                rowIndexInt = e.RowIndex;




                // DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                //rowID= Int32.Parse(row.Cells[0].Value.ToString());
            }
        }

        private void ZoneView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Zones1.Zones' table. You can move, or remove it, as needed.
            this.zonesTableAdapter.Fill(this.dataSet_Zones1.Zones);
            // label toevoegen hier!!
            locatiedal.ReadLocatie();
            DgvZoneview.DataSource = locatiedal.locaties.Where(x => x.ZoneId == zone.ID).ToList();

        }
    }
}

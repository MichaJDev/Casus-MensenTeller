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
    public partial class LocatieView : Form
    {
        private Locatie locatie;


        LocatieDAL locatiedal = new LocatieDAL();
        
        private int rowID = 0;
        int rowIndexInt = 0;
        public LocatieView(Locatie l)
        {
            locatie = l;
            InitializeComponent();
        }

        private void LocatieView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_LocatiesView.Locaties' table. You can move, or remove it, as needed.
            this.locatiesTableAdapter.Fill(this.dataSet_LocatiesView.Locaties);
            locatiedal.ReadLocatie();
            DgvViewLocatie.DataSource = locatiedal.Locaties.Where(x => x.ZoneId == locatie.ID).ToList();
        }

        private void ViewLocatiebutton_Click(object sender, EventArgs e)
        {

            string id = DgvViewLocatie.CurrentRow.Cells[0].Value.ToString();

            int pid = int.Parse(id);
            locatiedal.ReadLocatie();
            Locatie l = locatiedal.Locaties.Where(X => X.ID == pid).First();
            this.locatiesTableAdapter.Fill(this.dataSet_LocatiesView.Locaties);
            LocatieView form = new LocatieView(l);
            form.Show();



            // DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            //rowID= Int32.Parse(row.Cells[0].Value.ToString());
        }

        private void DgvViewLocatie_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewCell cell = (DataGridViewCell)DgvViewLocatie.Rows[e.RowIndex].Cells[e.ColumnIndex];
                rowID = (int)cell.Value;
                rowIndexInt = e.RowIndex;
            }



        }
    }
}

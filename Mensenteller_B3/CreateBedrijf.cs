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
using System.Data.SqlClient;

namespace Mensenteller_B3
{
    public partial class CreateBedrijf : Form
    {
        BedrijfDAL dal = new BedrijfDAL();
        private int rowID = 0;
        int rowIndexInt = 0;




        public CreateBedrijf()
        {
            InitializeComponent();
            dal.ReadBedrijf();
        }

        private void CreateBedrijf_Load(object sender, EventArgs e)
        {

            dal.ReadBedrijf();
            // TODO: This line of code loads data into the 'mensentellerDataSet.Bedrijven' table. You can move, or remove it, as needed.
            this.bedrijvenTableAdapter.Fill(this.mensentellerDataSet.Bedrijven);

        }

        private void CreateBedrijfbutton_Click(object sender, EventArgs e)
        {
            if (CreateBedrijftextbox.Text != "")
            {
                string Name = CreateBedrijftextbox.Text;
                Bedrijf bedrijf = new Bedrijf(0, Name);
                dal.CreateBedrijf(bedrijf);

                //foreach (Bedrijf bedrijf1 in dal.bedrijven)
                //{
                //    CreateBedrijftextbox.ResetText();
                //}
                CreateBedrijftextbox.Text = "";

                MessageBox.Show("Saved");

            }

        }

        private void BedrijfDeleteButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show(rowID.ToString());
            dataGridView1.Rows.RemoveAt(rowIndexInt);
            dal.DeleteBedrijf(rowID);


        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewCell cell = (DataGridViewCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                rowID = (int)cell.Value;
                rowIndexInt = e.RowIndex;




                // DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                //rowID= Int32.Parse(row.Cells[0].Value.ToString());

            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {


        }

        private void EditBedrijfbutton_Click(object sender, EventArgs e)
        {
            //        int id = 0;

            //        foreach (Bedrijf bedrijf in dal.bedrijven)
            //        {
            //            //indien deze geslect is kan de functie uitgevoerd worden dit geld ook voor alle andere functies, eerst hoort deze ingedrukt te zijn door de gebruiker vervolgens kan er een aanpassing gemaakt worden
            //            if (selectedName == locatie.Straat)
            //            {
            //                id = locatie.Id;
            //            }
            //        }
            //}
        }
    }
}

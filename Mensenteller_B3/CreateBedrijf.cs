using Mensenteller_B3.Bedrijven;
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
    public partial class CreateBedrijf : BaseForm
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
            // TODO: This line of code loads data into the 'dataSet_CreateBedrijven.Bedrijven' table. You can move, or remove it, as needed.
            this.bedrijvenTableAdapter.Fill(this.dataSet_CreateBedrijven.Bedrijven);

        }

        private void CreateBedrijfbutton_Click(object sender, EventArgs e)
        {
            if (CreateBedrijftextbox.Text != "")
            {
                string Name = CreateBedrijftextbox.Text;
                Bedrijf bedrijf = new Bedrijf(0, Name);
                dal.CreateBedrijf(bedrijf);

              
                CreateBedrijftextbox.Clear();
                MessageBox.Show("Saved");
                this.bedrijvenTableAdapter.Fill(this.dataSet_CreateBedrijven.Bedrijven);
            }
        }
        
        private void DgvBedrijven_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void EditBedrijfbutton_Click(object sender, EventArgs e)
        {
            string Name = EditBedrijftextbox.Text;
            int id = int.Parse(EdittextoxId.Text);
            dal.EditBedrijf(id, Name);
            this.bedrijvenTableAdapter.Fill(this.dataSet_CreateBedrijven.Bedrijven);
            MessageBox.Show("Updated");
        }

        private void ButtondDone_Click(object sender, EventArgs e)
        {
            Close();
            CreateModify createModify = new CreateModify();
            createModify.Show();
        }
    }
}

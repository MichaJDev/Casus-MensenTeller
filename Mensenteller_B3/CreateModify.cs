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
    public partial class CreateModify : Form
    {
        BedrijfDAL dal = new BedrijfDAL();
        private int rowID = 0;
        int rowIndexInt = 0;
        public CreateModify()
        {
            InitializeComponent();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Close();
            CreateBedrijf createBedrijf = new CreateBedrijf();
            createBedrijf.Show();
            
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {  
            int pid = DGVCreateModify.CurrentCell.RowIndex;
            int id = pid + 1;
            Close();
            MessageBox.Show("Bedrijf ID = " + id.ToString());
            ModifyBedrijf modifyBedrijf = new ModifyBedrijf(id);
            modifyBedrijf.Show();
        }

        private void CreateModify_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mensentellerDataSet4.Bedrijven' table. You can move, or remove it, as needed.
            this.bedrijvenTableAdapter1.Fill(this.mensentellerDataSet4.Bedrijven);
            // TODO: This line of code loads data into the 'mensentellerDataSet1.Bedrijven' table. You can move, or remove it, as needed.
            this.bedrijvenTableAdapter.Fill(this.mensentellerDataSet1.Bedrijven);

        }

        private void DGVCreateModify_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            string id = DGVCreateModify.CurrentRow.Cells[0].Value.ToString();
            int pid = int.Parse(id);
            dal.DeleteBedrijf(pid);
            this.bedrijvenTableAdapter.Fill(this.mensentellerDataSet1.Bedrijven);
        }
    }
}

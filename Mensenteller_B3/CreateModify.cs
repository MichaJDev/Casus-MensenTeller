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
    public partial class CreateModify : BaseForm
    {
        BedrijfDAL dal = new BedrijfDAL();
        
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
            string id = DGVCreateModify.CurrentRow.Cells[0].Value.ToString();
            string name = DGVCreateModify.CurrentRow.Cells[1].Value.ToString();
            int pid = int.Parse(id);
            Close();
            MessageBox.Show("Bedrijf ID = " + pid.ToString());
            ModifyBedrijf modifyBedrijf = new ModifyBedrijf(pid, name);
            modifyBedrijf.Show();
        }

        private void CreateModify_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mensentellerDataSet6.Bedrijven' table. You can move, or remove it, as needed.
            this.bedrijvenTableAdapter2.Fill(this.mensentellerDataSet6.Bedrijven);

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
            this.bedrijvenTableAdapter2.Fill(this.mensentellerDataSet6.Bedrijven);
        }
    }
}

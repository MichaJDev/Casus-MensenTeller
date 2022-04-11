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

namespace Mensenteller_B3
{
    public partial class CreateBedrijf : Form
    {
        BedrijfDAL dal = new BedrijfDAL();
        //string selectedName = "";
        public CreateBedrijf()
        {
            InitializeComponent();
        }

        private void CreateBedrijf_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mensentellerDataSet.Bedrijven' table. You can move, or remove it, as needed.
            this.bedrijvenTableAdapter.Fill(this.mensentellerDataSet.Bedrijven);

        }

        private void CreateBedrijfbutton_Click(object sender, EventArgs e)
        {
            if(CreateBedrijftextbox.Text != "")
            {
                string Name = CreateBedrijftextbox.Text;
                Bedrijf bedrijf = new Bedrijf(0, Name);
                dal.CreateBedrijf(bedrijf);
            }
        }
    }
}

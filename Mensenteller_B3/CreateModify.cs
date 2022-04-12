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
        public CreateModify()
        {
            InitializeComponent();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            CreateBedrijf createBedrijf = new CreateBedrijf();
            createBedrijf.Show();
            
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

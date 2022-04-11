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
    public partial class Main : Form
        
    {
        BedrijfDAL dal = new BedrijfDAL();
        public Main()
            
        {
            InitializeComponent();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dal.ReadBedrijf();
            if (dal.bedrijven == null)
            {
                CreateBedrijf form = new CreateBedrijf();
                form.Show()
            }
            else
            {

            }
        }
    }
}

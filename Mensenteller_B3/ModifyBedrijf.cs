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
    public partial class ModifyBedrijf : Form
    {
        public int Id { get; set; }
        public ModifyBedrijf(int id)
        {
            Id = id;
            InitializeComponent();
        }

        private void ModifyBedrijf_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mensentellerDataSet3.Zones' table. You can move, or remove it, as needed.
            this.zonesTableAdapter.Fill(this.mensentellerDataSet3.Zones);

        }
    }
}

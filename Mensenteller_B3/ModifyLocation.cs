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
    public partial class ModifyLocation : Form
    {
        int zoneId = _zoneId
        public ModifyLocation(int _zoneId )
        {
            InitializeComponent();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            
            CreateLocatie createLocatie = new CreateLocatie();
            createLocatie.Show();
        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {
            ModifySensor modifySensor = new ModifySensor();
            modifySensor.Show();
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

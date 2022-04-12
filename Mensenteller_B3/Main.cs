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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ButtonCreateModify_Click(object sender, EventArgs e)
        {           
            CreateModify createModify = new CreateModify();
            createModify.Show();            
        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}

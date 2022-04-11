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
         Bedrijf_DAL dal= new Bedrijf_DAL();
        public Main()
        {
            InitializeComponent();
        }

<<<<<<< Updated upstream
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
=======
        private void Main_Load(object sender, EventArgs e)
        {
            dal.ReadBedrijf();
            if (dal.Bedrijven  ==  null)
            {
                Createbedrijf_zone form = new Createbedrijf_zone();
                form.Show();
            }
            
            else
            {

            }
        }
       
       
>>>>>>> Stashed changes
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mensenteller_B3.Locaties;

namespace Mensenteller_B3
{
    public partial class CreateLocatie : Form
    {

        LocatieDAL dal = new LocatieDAL();
        Locatie l;
        public CreateLocatie(Locatie _l)
        {
            l = _l;
            InitializeComponent();
        }

        private void CreateLocatie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Locaties1.Locaties' table. You can move, or remove it, as needed.
            this.locatiesTableAdapter1.Fill(this.dataSet_Locaties1.Locaties);
            // TODO: This line of code loads data into the 'dataSet_Locaties.Locaties' table. You can move, or remove it, as needed.
            //this.locatiesTableAdapter.Fill(this.dataSet_Locaties.Locaties);

        }

        private void CreateLocatiebutton_Click(object sender, EventArgs e)
        {
            if (CreateLocatietextbox.Text != "")
            {
                string Name = CreateLocatietextbox.Text;
                Locatie locatie = new Locatie(0, Name);
                dal.CreateLocatie(locatie);

                CreateLocatietextbox.Text = "";
                MessageBox.Show("Saved");
                // TODO: This line of code loads data into the 'dataSet_Zones.Zones' table. You can move, or remove it, as needed.
                //this.locatiesTableAdapter.Fill(this.dataSet_Locaties.Locaties);
                this.locatiesTableAdapter1.Fill(this.dataSet_Locaties1.Locaties);
            }
        }

        private void EditLocatiebutton_Click(object sender, EventArgs e)
        {
            string Name = EditLocatietextbox.Text;
            int id = int.Parse(EditIdLocatietextbox.Text);
            dal.EditLocatie(id, Name);
          
            
            MessageBox.Show("Updated");
            this.locatiesTableAdapter1.Fill(this.dataSet_Locaties1.Locaties);
        }
    }
}

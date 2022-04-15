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
    public partial class ViewLocatie : Form
    {
        private Locatie locatie;


        LocatieDAL locatiedal = new LocatieDAL();
        public ViewLocatie(Locatie l)
        {
            locatie = l;
            InitializeComponent();
        }

        private void ViewLocatie_Load(object sender, EventArgs e)
        {
            locatiedal.ReadLocatie();
            DgvviewLocatie.DataSource = locatiedal.Locaties.Where(x => x.ZoneId == locatie.ID).ToList();
        }

        private void DgvviewLocatie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewLocatieButton_Click(object sender, EventArgs e)
        {
            string id = DgvviewLocatie.CurrentRow.Cells[0].Value.ToString();

            int pid = int.Parse(id);
            locatiedal.ReadLocatie();
            Locatie l = locatiedal.Locaties.Where(X => X.ID == pid).First();
            //ToDO              opnieuw toevoegen!!!
            //this.locatiesTableAdapter.Fill(this.dataSet_LocatiesView.Locaties);
            LocatieView form = new LocatieView(l);
            form.Show();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mensenteller_B3.Sensors.DrukSensors;
using Mensenteller_B3.Sensors.EntreeSensors;
using MensenTeller_B3.Simualtion_DAL;

namespace Mensenteller_B3
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();//iyyuf
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
            /*DAL dal = new DAL();
            DruksensorDAL dsDal = new DruksensorDAL();
            foreach (DrukSensor ds in dal.ReadDrukSimulator())
            {
                dsDal.CreateDruksensor(ds);
            }
            //Dit is voor ALLE EntreeSensors van de gehele dag opteslaan
            EntreeSensorDAL esDal = new EntreeSensorDAL();

            foreach (EntreeSensor ds in dal.ReadEntreeSensors())
                esDal.Create(ds);*/
        }

        private void TableLayoutPanelDecoCounter_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

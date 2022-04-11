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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }
<<<<<<< Updated upstream
=======

        private void View_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sensorDataDataSet.SensorReading' table. You can move, or remove it, as needed.
            this.sensorReadingTableAdapter.Fill(this.sensorDataDataSet.SensorReading);
            // TODO: This line of code loads data into the 'mensentellerDataSet_bedrijven.Bedrijven' table. You can move, or remove it, as needed.
            this.bedrijvenTableAdapter.Fill(this.mensentellerDataSet_bedrijven.Bedrijven);

        }
>>>>>>> Stashed changes
    }
}

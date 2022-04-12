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
        // per Kleur aparte panel!!!
        private void Canvas_paint(object sender, PaintEventArgs e)
        {
            Graphics gObject = panel1.CreateGraphics();

            Brush red = new SolidBrush(Color.Red);
           

            //gObject.DrawLine(redpen, 10, 10, 400, 376);
            gObject.FillRectangle(red, 10, 10, 100, 50);

            

            Brush yellow = new SolidBrush(Color.Yellow);
           

            //gObject.DrawLine(redpen, 10, 10, 400, 376);
            gObject.FillRectangle(yellow, 110, 60, 100, 50);

            Brush green = new SolidBrush(Color.Green);


            //gObject.DrawLine(redpen, 10, 10, 400, 376);
            gObject.FillRectangle(green, 120, 200, 100, 50);

        }
    }
}

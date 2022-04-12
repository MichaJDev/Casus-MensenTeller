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
          
        }


        //Indien je de status wilt zien van de aantal mensen die in de basic fit zijn kan dit aangegeven worden door op de status knop te drukken
        

        //ToDO X VERANDEREN NAAR AVERAGEPEOPLEIN met meerder else statement
        private void StatusMensenButton_Click(object sender, EventArgs e)
        {
            int x = 40;

            if (x < 30)
            {

                Graphics gObject = panel1.CreateGraphics();

                Brush red = new SolidBrush(Color.Green);


                gObject.FillRectangle(red, 10, 10, 100, 50);
            }


            else if (x > 30 && x < 60)
            {

                Graphics gObject = panel1.CreateGraphics();

                Brush yellow = new SolidBrush(Color.Yellow);


                gObject.FillRectangle(yellow, 10, 10, 100, 50);
            }
            else
            {
                
                Graphics gObject = panel1.CreateGraphics();

                Brush red = new SolidBrush(Color.Red);


                gObject.FillRectangle(red, 10, 10, 100, 50);
            }

            


        }
    }

}

﻿using System;
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

        private void View_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sensorDataDataSet1.PressureSensors' table. You can move, or remove it, as needed.
            this.pressureSensorsTableAdapter.Fill(this.sensorDataDataSet1.PressureSensors);
            // TODO: This line of code loads data into the 'sensorDataDataSet.SensorReading' table. You can move, or remove it, as needed.
            this.sensorReadingTableAdapter.Fill(this.sensorDataDataSet.SensorReading);

        }

      

        private void DgvSensorRead_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int sum = e;
            //double avg = e;
            //int datacount = DgvSensorRead.Rows.Count;   
            //for (int i = 0; i <= DgvSensorRead.Rows.Count-1; i++)
            //    sum = sum + int.Parse(DgvSensorRead.Rows[i].Cells[2].Value.ToString());
            //avg = (double)sum / datacount;
            //Averagetextbox.Text = avg.ToString("00.000");
        }
    }

}

using Mensenteller_B3.Sensors.DrukSensors;
using MensenTeller_B3.Simualtion_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MensenTeller_B3.Sensors;
using Mensenteller_B3.Sensors.EntreeSensors;

namespace Mensenteller_B3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());

            DAL dal = new DAL();
            DruksensorDAL dsDal = new DruksensorDAL();
            foreach (DrukSensor ds in dal.DrukSensors)
            {
               dsDal.CreateDruksensor(ds);
            }
            //Dit is voor ALLE EntreeSensors van de gehele dag opteslaan
            EntreeSensorDAL esDal = new EntreeSensorDAL();

            foreach (EntreeSensor ds in dal.EntreeSensors)
                esDal.Create(ds);
        }
    }
}
    


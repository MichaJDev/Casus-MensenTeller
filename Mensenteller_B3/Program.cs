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

            
        }
    }
}
    


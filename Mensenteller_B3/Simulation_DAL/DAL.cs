using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mensenteller_B3.Locaties;
using Mensenteller_B3.Sensors.DrukSensors;
using Mensenteller_B3.Sensors.EntreeSensors;
using MensenTeller_B3.Sensors;

namespace MensenTeller_B3.Simualtion_DAL
{
    class DAL
    {
        public List<DrukSensor> DrukSensorsSim { get; set; }
        public List<EntreeSensor> EntreeSensorsSim { get; set; }
        private string source = ".";
        private string catalog = "SensorData";

        const int MAXRANDOM = 8; // maximum number of people to add or delete per datageneration
        const int INTERVALMINUTES = 5; // interval in minutes to generate data for

        private string GetConnectionString()
        {
            return $"Data Source=" + source + ";Initial Catalog=" + catalog + ";Integrated Security=True";
        }

        //Haal op vanuit SensorData Db maken nog
        public void ReadDrukSimulator()
        {
            //TODO Table PressureSensors
        }

        public void ReadEntreeSensors()
        {
            //TODO Table SensorReading
        }
    }
}

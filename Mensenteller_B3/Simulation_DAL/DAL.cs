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
        public List<DrukSensor> DrukSensors { get; set; }
        public List<EntreeSensor> EntreeSensors { get; set; }
        private string source = ".";
        private string catalog = "SensorData";

        const int MAXRANDOM = 8; // maximum number of people to add or delete per datageneration
        const int INTERVALMINUTES = 5; // interval in minutes to generate data for

        public DAL()
        {
            ReadDrukSimulator();
            ReadEntreeSensors();
        }
        private string GetConnectionString()
        {
            return $"Data Source=" + source + ";Initial Catalog=" + catalog + ";Integrated Security=True";
        }

        //Haal op vanuit SensorData Db maken nog
        private void ReadDrukSimulator()
        {
            using(SqlConnection cnn = new SqlConnection(GetConnectionString()))
            {
                string sql = "SELECT * FROM PressureSensors";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DrukSensors.Add(new DrukSensor(reader.GetInt32(0), reader.GetInt32(1), reader.GetBoolean(2),reader.GetString(3)));
                    }
                }
            }
        }

        private void ReadEntreeSensors()
        {
            using (SqlConnection cnn = new SqlConnection(GetConnectionString()))
            {
                string sql = "SELECT * FROM SensorReading";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        EntreeSensors.Add(new EntreeSensor(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3),reader.GetString(4)));
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mensenteller_B3.Sensors.DrukSensors;
using Mensenteller_B3.Sensors.EntreeSensors;
using MensenTeller_B3.Sensors;

namespace MensenTeller_B3.Simualtion_DAL
{
    class DAL
    {
        
        private readonly string source = ".";
        private readonly string catalog = "SensorData";

        public DAL()
        {
 
        }
        private string GetConnectionString()
        {
            return $"Data Source=" + source + ";Initial Catalog=" + catalog + ";Integrated Security=True";
        }

        //Haal op vanuit SensorData Db maken nog
        public List<DrukSensor> ReadDrukSimulator()
        {

            List<DrukSensor> lds = new List<DrukSensor>();


            using (SqlConnection cnn = new SqlConnection(GetConnectionString()))
            {
                string sql = "SELECT * FROM PressureSensors";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))//hhh
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DrukSensor ds = new DrukSensor
                        {
                            EntryId = reader.GetInt32(0),
                            SensorId = reader.GetInt32(1),
                            InUse = reader.GetBoolean(2),
                            TimeStamp = reader.GetString(3)
                        };
                        lds.Add(ds);
                    }
                }
                return lds;
            }
        }

        public List<EntreeSensor> ReadEntreeSensors()
        {
            List<EntreeSensor> les = new List<EntreeSensor>();
            using (SqlConnection cnn = new SqlConnection(GetConnectionString()))
            {
                string sql = "SELECT * FROM SensorReading";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        EntreeSensor es = new EntreeSensor
                        {
                            EntryID = reader.GetInt32(0),
                            SensorID = reader.GetInt32(1),
                            PeopleIn = reader.GetInt32(2),
                            PeopleOut = reader.GetInt32(3),
                            TimeStamp = reader.GetString(4)
                        };
                        les.Add(es);
                    }
                }
                return les;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mensenteller_B3.Locaties;
using MensenTeller_B3.Sensors;

namespace MensenTeller_B3.Simualtion_DAL
{


    class DAL
    {
        private string source = ".";
        private string catalog = "SensorData";

        const int MAXRANDOM = 8; // maximum number of people to add or delete per datageneration
        const int INTERVALMINUTES = 5; // interval in minutes to generate data for

        private string GetConnectionString()
        {
            return $"Data Source=" + source + ";Initial Catalog=" + catalog + ";Integrated Security=True";
        }

        private void StoreData(Sensor _sensor)
        {
            // show feedback
            Console.WriteLine($"Sensor {_sensor.ID}, PeopleIn {_sensor.PeopleIn.ToString().PadLeft(5, '0')}, PeopleOut {_sensor.PeopleOut.ToString().PadLeft(5, '0')}, Timestamp {_sensor.ResetTimeStamp}, ");

            // actually save the record
            try
            {
                SqlConnection cnn = new SqlConnection
                {
                    ConnectionString = GetConnectionString()
                };
                cnn.Open();
                string sql = "INSERT INTO SensorReading (ID, People_in, People_out, TimeStamp) VALUES (@ID, @People_in, @People_out, @TimeStamp)";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@ID", _sensor.ID);
                    cmd.Parameters.AddWithValue("@People_in", _sensor.PeopleIn);
                    cmd.Parameters.AddWithValue("@People_out", _sensor.PeopleOut);
                    cmd.Parameters.AddWithValue("@TimeStamp", _sensor.ResetTimeStamp);
                    cmd.ExecuteNonQuery();
                }
                cnn.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

using Mensenteller_B3.Locaties;
using MensenTeller_B3.Sensors;
using MensenTeller_B3.Zones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensenteller_B3.Sensors
{
    public class SensorDAL
    {
        // Connectionstring die de connectie maakt naar de database
        private readonly string connectionString = "Data Source=.;Initial Catalog=Mensenteller;Integrated Security=True";

        // Properties lijst van Sensoren van gehele bedrijf
        public List<Sensor> Sensors { get; set; }
       
        public void Create(Locatie l, Sensor s)
        {
            using(SqlConnection cnn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Sensors (Name, LocatieId) VALUES (@name, @locatieId)";
                using(SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@name", s.Name);
                    cmd.Parameters.AddWithValue("@locatieId", l.ID);
                    cnn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }catch(Exception ex)
                    {
                        throw;
                    }
                }
                cnn.Close();
                ReadSensors();
            }
        }

        public void Update(Sensor s)
        {
            using(SqlConnection cnn = new SqlConnection())
            {
                string sql = "UPDATE Sensors SET Name = @Name, LocatieId = @LocatieID WHERE Id = @id ";
                using(SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@Name", s.Name);
                    cmd.Parameters.AddWithValue("@LocatieId", s.LocatieID);
                    cnn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }catch(Exception ex)
                    {
                        throw;
                    }
                }
            }
        }

        public void Delete(Sensor s)
        {
            using(SqlConnection cnn = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM Sensors WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@Id", s.ID);
                    cnn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }catch(Exception ex)
                    {
                        throw;
                    }
                }
            }
        }
       
        public void ReadSensors()
        {
            using(SqlConnection cnn = new SqlConnection(connectionString))
            {
                string sql = "SELECT Id, Name, LocatieId FROM Sensors ORDER BY Id";
                using(SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Sensors.Add(new Sensor(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));
                    }
                }
            }
        }
    }
}

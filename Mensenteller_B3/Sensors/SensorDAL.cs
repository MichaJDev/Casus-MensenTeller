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
       
        public void Create(Sensor s)
        {
            using(SqlConnection cnn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Sensors (Id,Name, LocatieId) VALUES (@Id,@name, @locatieId)";
                using(SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@name", s.Name);
                    cmd.Parameters.AddWithValue("@locatieId", s.LocatieID);
                    cmd.Parameters.AddWithValue("@Id", s.ID);
                    cnn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }catch(Exception ex)
                    {
                        Console.Write(ex.ToString());
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
                        Console.Write(ex.ToString());
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
                        Console.Write(ex.ToString());
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
                        Sensor s = new Sensor
                        {
                            ID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            LocatieID = reader.GetInt32(2)
                        };
                        Sensors.Add(s);
                    }
                }
            }
        }

        public List<Sensor> ReadSensors(int id)
        {
            using(SqlConnection cnn = new SqlConnection(connectionString))
            {
                string sql = "SELECT Id, Name, LocatieId FROM Sensors WHERE LocatieId = @id";
                using(SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    List<Sensor> sl = new List<Sensor>();
                    cnn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Sensor s = new Sensor
                        {
                            ID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            LocatieID = reader.GetInt32(2)
                        };
                        sl.Add(s);
                    }
                    return sl;
                }
            }
        }
        public Sensor GetSensor(int id)
        {
            Sensor s = new Sensor();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                string sql = "SELECT Id, Name, LocatieId FROM Sensors WHERE Id = @id";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    List<Sensor> sl = new List<Sensor>();
                    cnn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {


                        s.ID = reader.GetInt32(0);
                        s.Name = reader.GetString(1);
                        s.LocatieID = reader.GetInt32(2);
                        
                       
                    }
                    return s;
                }
            }
        }
    }
}

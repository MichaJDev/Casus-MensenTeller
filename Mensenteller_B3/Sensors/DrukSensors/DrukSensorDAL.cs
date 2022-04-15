using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensenteller_B3.Sensors.DrukSensors
{
    public class DruksensorDAL
    {
        public string connectionString = "";
        public List<DrukSensor> druksensorlist = new List<DrukSensor>();
        public void CreateDruksensor(DrukSensor druksensor)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO DrukSensors (InUse, Timestamp, SensorID) VALUES (@inuse, @timestamp, @sensorid)";
                    //TODO: omzetten naar sensor DAL
                    command.Parameters.AddWithValue("@sensorid", druksensor.SensorId);
                    command.Parameters.AddWithValue("@inuse", druksensor.InUse);
                    command.Parameters.AddWithValue("@timestamp", druksensor.TimeStamp);
                    try
                    {
                        command.ExecuteNonQuery();
                    }catch(SqlException e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    

                    command.CommandText = "SELECT CAST(@@Identity AS INT);";
                    int id = 0;
                    try
                    {
                        id = (int)command.ExecuteScalar();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    ReadDrukSensor();
                }
            }
        }

        public void ReadDrukSensor()
        {
            druksensorlist.Clear();

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "SELECT entryid, sensorid, inuse, timestamp FORM PRESSURESENSORS ORDER BY Id";
                    SqlDataReader datareader = command.ExecuteReader();

                    while (datareader.Read())
                    {
                        druksensorlist.Add(new DrukSensor(Int32.Parse(datareader[0].ToString()),
                                                              Int32.Parse(datareader[1].ToString()),
                                                              datareader.GetBoolean(2),
                                                              datareader[3].ToString()
                                                              ));
                    }
                }
            }
        }

        public void ReadDrukSensor(int id)
        {
            druksensorlist.Clear();

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "SELECT entryid, sensorid, inuse, timestamp FORM PRESSURESENSORS WHERE SensorId = @Id";
                    command.Parameters.AddWithValue("@Id", id);
                    SqlDataReader datareader = command.ExecuteReader();

                    while (datareader.Read())
                    {
                        druksensorlist.Add(new DrukSensor(Int32.Parse(datareader[0].ToString()),
                                                              Int32.Parse(datareader[1].ToString()),
                                                              datareader.GetBoolean(2),
                                                              datareader[3].ToString()
                                                              ));
                    }
                }
            }
        }

        public void DeleteDrukSensor(int entryid)
        {
            druksensorlist.Clear();

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "DELETE PRESSURESENSORS FROM DRUKSENSOR WHERE Id = @Id;";
                    command.Parameters.AddWithValue("@Id", entryid);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditDrukSensor(int entryid, int sensorid, bool inuse, string timestamp)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "UPDATE pressuresensors SET entryid = @entryid WHERE Id = @id";
                    command.Parameters.AddWithValue("@Id", entryid);
                    command.Parameters.AddWithValue("sensorid", sensorid);
                    command.Parameters.AddWithValue("inuse", inuse);
                    command.Parameters.AddWithValue("timestamp", timestamp);
                    command.ExecuteNonQuery();
                }
            }
            ReadDrukSensor();
        }
    }
}
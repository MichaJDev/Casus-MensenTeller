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
        public string connectionString = "Data Source=.;Initial Catalog=Mensenteller;Integrated Security=True";
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
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.ToString());
                    }



                }
            }
        }

        public List<DrukSensor> ReadDrukSensor()
        {
            List<DrukSensor> dl = new List<DrukSensor>();

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "SELECT * FROM DrukSensors ORDER BY SensorId";
                    SqlDataReader datareader = command.ExecuteReader();

                    while (datareader.Read())
                    {
                        DrukSensor d = new DrukSensor
                        {
                            ID = datareader.GetInt32(0),
                            InUse = datareader.GetBoolean(1),
                            TimeStamp = datareader.GetString(2),
                            SensorId = datareader.GetInt32(3)
                        };

                        dl.Add(d);
                    }
                }
                return dl;
            }
        }
        //Int32.Parse(datareader[0].ToString()),
        //                                                      Int32.Parse(datareader[1].ToString()),
        //                                                      datareader.GetBoolean(2),
        //                                                      datareader[3].ToString()

        public List<DrukSensor> ReadDrukSensor(int id)
        {
            List<DrukSensor> ds = new List<DrukSensor>();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "SELECT * FROM DrukSensors WHERE SensorId = @Id";
                    command.Parameters.AddWithValue("@Id", id);
                    SqlDataReader datareader = command.ExecuteReader();

                    while (datareader.Read())
                    {
                        DrukSensor d = new DrukSensor
                        {
                            ID = datareader.GetInt32(0),
                            InUse = datareader.GetBoolean(2),
                            TimeStamp = datareader.GetString(3),
                            SensorId = datareader.GetInt32(4)
                        };

                        ds.Add(d);
                    }
                }
                return ds;
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
                    command.CommandText = "DELETE FROM DrukSensors WHERE Id = @Id;";
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
                    command.CommandText = "UPDATE DrukSensors SET entryid = @entryid, sensorid = @sensorid, inuse = @inuse, timestamp = @timestamp WHERE Id = @id";
                    command.Parameters.AddWithValue("@Id", entryid);
                    command.Parameters.AddWithValue("@sensorid", sensorid);
                    command.Parameters.AddWithValue("@inuse", inuse);
                    command.Parameters.AddWithValue("@timestamp", timestamp);
                    command.ExecuteNonQuery();
                }
            }
            ReadDrukSensor();
        }





        public DrukSensor GetDrukSensor(int id)
        {
            DrukSensor d = new DrukSensor();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "SELECT * FROM DrukSensors WHERE SensorId = @Id";
                    command.Parameters.AddWithValue("@Id", id);
                    SqlDataReader datareader = command.ExecuteReader();

                    while (datareader.Read())
                    {


                        d.ID = datareader.GetInt32(0);
                        d.InUse = datareader.GetBoolean(2);
                        d.TimeStamp = datareader.GetString(3);
                        d.SensorId = datareader.GetInt32(4);




                    }
                }
                return d;
            }
        }
    }
}
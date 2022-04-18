using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensenteller_B3.Sensors.EntreeSensors
{
    public class EntreeSensorDAL
    {
        private readonly string conString = "Data Source=.;Initial Catalog=Mensenteller;Integrated Security=True";
        public List<EntreeSensor> EntreeSensors { get; set; }
        public List<EntreeSensor> ReadEntreeSensors()
        {
            List<EntreeSensor> el = new List<EntreeSensor>();
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                string sql = "SELECT * FROM EntreeSensor ORDER BY SensorId";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {

                    cnn.Open();



                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        EntreeSensor es = new EntreeSensor
                        {
                            EntryID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            PeopleIn = reader.GetInt32(2),
                            PeopleOut = reader.GetInt32(3),
                            TimeStamp = reader.GetString(4),
                            SensorID = reader.GetInt32(5)
                        };
                        el.Add(es);
                    }



                    return el;
                }
            }
        }
        public List<EntreeSensor> ReadEntreeSensors(int id)
        {
            List<EntreeSensor> os = new List<EntreeSensor>();

            using (SqlConnection cnn = new SqlConnection(conString))
            {
                string sql = "SELECT * FROM EntreeSensor WHERE SensorId = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    if (EntreeSensors != null)
                        EntreeSensors.Clear();

                    cnn.Open();



                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        EntreeSensor es = new EntreeSensor
                        {
                            EntryID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            PeopleIn = reader.GetInt32(2),
                            PeopleOut = reader.GetInt32(3),
                            TimeStamp = reader.GetString(4),
                            SensorID = reader.GetInt32(5)
                        };
                        os.Add(es);
                    }



                    return os;
                }
            }
        }
        public void Update(EntreeSensor sensor)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                string sql = "UPDATE EntreeSensor SET PeopleIn = @PeopleIn, PeopleOut = @PeopleOut,TimeStamp = @TimeStamp WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cnn.Open();
                    try
                    {
                        cmd.Parameters.AddWithValue("@Id", sensor.SensorID);
                        cmd.Parameters.AddWithValue("@Peoplein", sensor.PeopleIn);
                        cmd.Parameters.AddWithValue("@PeopleOut", sensor.PeopleOut);
                        cmd.Parameters.AddWithValue("@TimeStamp", sensor.TimeStamp);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine($"EntreeSensor with ID: {sensor.SensorID} On : {sensor.TimeStamp} Succesfully Updated\n");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Unable to update EntreeSensor with ID: {sensor.SensorID} On : {sensor.TimeStamp}\nCheck stacktrace below:\n");
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }

        public void Delete(EntreeSensor sensor)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                string sql = "DELETE FROM EntreeSensor WHERE Id = @ID";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@ID", sensor.SensorID);
                    cnn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine($"EntreeSensor with ID: {sensor.SensorID} On : {sensor.TimeStamp} Succesfully deleted\n");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Unable to delete EntreeSensor with ID: {sensor.SensorID} On : {sensor.TimeStamp}\nCheck stacktrace below:\n");
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }

        public void Create(EntreeSensor sensor)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                string sql = "INSERT INTO EntreeSensor (Name, PeopleIn, PeopleOut, Timestamp) VALUES(@Name, @PeopleIn, @PeopleOut, @TimeStamp)";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@Name", $"Sensor{sensor.EntryID}");
                    cmd.Parameters.AddWithValue("@PeopleIn", sensor.PeopleIn);
                    cmd.Parameters.AddWithValue("@PeopleOut", sensor.PeopleOut);
                    cmd.Parameters.AddWithValue("@TimeStamp", sensor.TimeStamp);
                    cnn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine($"EntreeSensor with ID: {sensor.SensorID} On : {sensor.TimeStamp} Succesfully created\n");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Unable to Create EntreeSensor with Name: {sensor.Name} On : {sensor.TimeStamp} \nCheck stacktrace below:\n");
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }
        public EntreeSensor ReadEntreeSensor(int id)
        {
            EntreeSensor e = new EntreeSensor();

            using (SqlConnection cnn = new SqlConnection(conString))
            {
                string sql = "SELECT * FROM EntreeSensor WHERE SensorId = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    if (EntreeSensors != null)
                        EntreeSensors.Clear();

                    cnn.Open();



                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        e.EntryID = reader.GetInt32(0);
                        e.Name = reader.GetString(1);
                        e.PeopleIn = reader.GetInt32(2);
                        e.PeopleOut = reader.GetInt32(3);
                        e.TimeStamp = reader.GetString(4);
                        e.SensorID = reader.GetInt32(5);


                    }





                    return e;
                }
            }
        }
    }
}
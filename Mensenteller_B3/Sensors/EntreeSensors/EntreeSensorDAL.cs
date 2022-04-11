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
        private readonly string conString = "";
        public List<EntreeSensor> EntreeSensors { get; set; }
        public void ReadEntreeSensors()
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                string sql = "SELECT * FROM EntreeSensors";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    EntreeSensors.Clear();
                    cnn.Open();
                    try
                    {

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            EntreeSensors.Add(new EntreeSensor(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4)));
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Unable to read from EntreeSensors table, are you connected?");
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }

        public void Update(EntreeSensor sensor)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                string sql = "UPDATE EntreeSensors SET Name = @Name, people_In = @PeopleIn, people_Out = @PeopleOut,TimeStamp = @TimeStamp WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cnn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine($"EntreeSensor with ID: {sensor.ID} On : {sensor.TimeStamp} Succesfully Updated\n");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Unable to update EntreeSensor with ID: {sensor.ID} On : {sensor.TimeStamp}\nCheck stacktrace below:\n");
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }

        public void Delete(EntreeSensor sensor)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                string sql = "DELETE FROM EntreeSensors WHERE Id = @ID";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@ID", sensor.ID);
                    cnn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine($"EntreeSensor with ID: {sensor.ID} On : {sensor.TimeStamp} Succesfully deleted\n");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Unable to delete EntreeSensor with ID: {sensor.ID} On : {sensor.TimeStamp}\nCheck stacktrace below:\n");
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }

        public void Create(EntreeSensor sensor)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                string sql = "INSERT INTO EntreeSensors (name, people_in, people_out,timestamp) VALUES(@Name, @PeopleIn, @PeopleOut, @TimeStamp)";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@Name", sensor.Name);
                    cmd.Parameters.AddWithValue("@PeopleIn", sensor.PeopleIn);
                    cmd.Parameters.AddWithValue("@PeopleOut", sensor.PeopleOut);
                    cmd.Parameters.AddWithValue("@TimeStamp", sensor.TimeStamp);
                    cnn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine($"EntreeSensor with ID: {sensor.ID} On : {sensor.TimeStamp} Succesfully created\n");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Unable to Create EntreeSensor with Name: {sensor.Name} On : {sensor.TimeStamp} \nCheck stacktrace below:\n");
                        Console.WriteLine(ex.ToString());
                    }
                }
            }

        }
    }
}

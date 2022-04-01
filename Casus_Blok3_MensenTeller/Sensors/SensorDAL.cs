using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_Blok3_MensenTeller.Sensors
{
    public class SensorDAL
    {
        readonly string connectionString = "";
        public List<Sensor> sensorList = new List<Sensor>();
        public SensorDAL()
        {

        }
        public void CreateSensor(Sensor sensor)
        {
            try
            {
                sensorList.Clear();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO Sensor (name) VALUES (@name)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", sensor.Name);
                        command.ExecuteNonQuery();

                        command.CommandText = "SELECT CAST(@@Identity AS INT)";
                        int id = (int)command.ExecuteScalar();
                        sensor.ID = id;
                        Console.WriteLine(id);
                        ReadSensor();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public void ReadSensor()
        {
            try
            {
                sensorList.Clear();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        connection.ConnectionString = connectionString;
                        connection.Open();
                        command.Connection = connection;
                        command.CommandText = "SELECT id, name FROM Sensor ORDER BY id";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                sensorList.Add(new Sensor(int.Parse(reader[0].ToString()), reader[1].ToString()));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public void UpdateSensor(Sensor sensor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "UPDATE Sensor SET name = @name WHERE id = @id";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", sensor.ID);
                        command.Parameters.AddWithValue("@name", sensor.Name);
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public void DeleteSensorById(int id)
        {
            try
            {
                sensorList.Clear();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "DELETE FROM Sensor WHERE id = @id";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
                ReadSensor();
            }
            catch (SqlException ex) { throw ex; }
        }
        public void DeleteSensorByName(string name)
        {
            try
            {
                sensorList.Clear();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "DELETE FROM Sensor WHERE name = @name";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.ExecuteNonQuery();
                    }
                }
                ReadSensor();
            }
            catch (SqlException ex) { throw ex; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_Blok3_MensenTeller.Toestellen
{

    class ToestelDAL
    {
        readonly string connectionString = "";
        public List<Toestel> toestelList = new List<Toestel>();
        public ToestelDAL()
        {

        }
        public void CreateToestel(Toestel toestel)
        {
            try
            {
                toestelList.Clear();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "INSERT INTO Toestel (name) VALUES (@name)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", toestel.Name);
                        command.ExecuteNonQuery();

                        command.CommandText = "SELECT CAST(@@Identity AS INT)";
                        int id = (int)command.ExecuteScalar();
                        toestel.ID = id;
                        Console.WriteLine(id);
                        ReadToestel();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public void ReadToestel()
        {
            try
            {
                toestelList.Clear();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        connection.ConnectionString = connectionString;
                        connection.Open();
                        command.Connection = connection;
                        command.CommandText = "SELECT id, name FROM Toestel ORDER BY id";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                toestelList.Add(new Toestel(int.Parse(reader[0].ToString()), reader[1].ToString()));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public void UpdateToestel(Toestel toestel)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "UPDATE Toestel SET name = @name WHERE id = @id";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", toestel.ID);
                        command.Parameters.AddWithValue("@name", toestel.Name);
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public void DeleteToestelById(int id)
        {
            try
            {
                toestelList.Clear();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "DELETE FROM Toestel WHERE id = @id";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
                ReadToestel();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
                Debug.Write(ex.Message + "\n" + ex.StackTrace);
            }
        }
        public void DeleteToestelByName(string name)
        {
            try
            {
                toestelList.Clear();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "DELETE FROM Toestel WHERE name = @name";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.ExecuteNonQuery();
                    }
                }
                ReadToestel();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
                Debug.Write(ex.Message + "\n" + ex.StackTrace);
            }
        }
    }
}


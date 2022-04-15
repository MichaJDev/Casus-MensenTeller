using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MensenTeller_B3.Zones;

namespace Mensenteller_B3.Locaties
{

    public class LocatieDAL
    {
        private readonly string conString = "Data Source=.;Initial Catalog=Mensenteller;Integrated Security=True";

        public List<Locatie> Locaties { get; set; }

        public void CreateLocatie(Locatie locatie)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string query = "INSERT INTO Locaties (Name, Zoneid) VALUES (@name, @ZoneId)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", locatie.Name);
                cmd.Parameters.AddWithValue("@ZoneId", locatie.ZoneId);
                /*
                  cmd.Parameters.AddWithValue("@Description", l.Description);
                  cmd.Parameters.AddWithValue("@Xco", l.Xco);
                  cmd.Parameters.AddWithValue("@Yco", l.Yco);
                  */
                con.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT CAST(@@Identity AS INT;";
                int id = 0;
                try
                {
                    id = (int)cmd.ExecuteScalar();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }
        }
        public Locatie Get(int id)
        {
            Locatie l = new Locatie();
            using (SqlConnection con = new SqlConnection(conString))
            {
                string query = "SELECT * FROM Locaties WHERE sensorId = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    return new Locatie(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                }
            }
            return l;
        }
        /*
        public void Update(Locatie l)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string query = "UPDATE Locaties SET Name = @name, Description = @description, Xco = @xco, Yco = @yco WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", l.Name);
                
                cmd.Parameters.AddWithValue("@description", l.Description);
                cmd.Parameters.AddWithValue("@xco", l.Xco);
                cmd.Parameters.AddWithValue("@yco", l.Yco);
                cmd.Parameters.AddWithValue("@id", l.ID);
                
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
                    Debug.Write(ex.Message + "\n" + ex.StackTrace);
                }
            }
*/

        public void EditLocatie(int id, string name)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = conString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "UPDATE Locaties SET name = @name WHERE Id = @id";
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("name", name);
                    command.ExecuteNonQuery();
                }
            }

        }


        public void Delete(Locatie l)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string query = "DELETE FROM Locaties WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", l.ID);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
                    Debug.Write(ex.Message + "\n" + ex.StackTrace);
                }
            }
        }
        public void ReadLocatie()
        {
            Locaties.Clear();

            using (SqlConnection cnn = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = conString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "SELECT Id, Name, ZoneId FROM Locaties ORDER BY id";
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Locatie l = new Locatie();
                        l.ID = dataReader.GetInt32(0);
                        l.Name = dataReader.GetString(1);
                        l.ZoneId = dataReader.GetInt32(2);
                        Locaties.Add(l);

                    }
                }
            }
            
        }
        public void ReadLocatie(int id)
        {
            Locaties.Clear();

            using (SqlConnection cnn = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = conString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "SELECT Id, Name, ZoneId FROM Locaties WHERE ZoneId = @Id";
                    command.Parameters.AddWithValue("@Id", id);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Locatie l = new Locatie();
                        l.ID = dataReader.GetInt32(0);
                        l.Name = dataReader.GetString(1);
                        l.ZoneId = dataReader.GetInt32(2);
                        Locaties.Add(l);

                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_Blok3_MensenTeller.Locaties
{
    
    public class LocatieDAL
    {
        private string conString = "";

        public void Create(Locatie l)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string query = "INSERT INTO Locaties (Name,Description,Xco,Yco) VALUES (@name, @description,@xco,@yco)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@adres", l.Name);
                cmd.Parameters.AddWithValue("@nummer", l.Description);
                cmd.Parameters.AddWithValue("@toevoeging", l.Xco);
                cmd.Parameters.AddWithValue("@plaats", l.Yco);
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
    }
}

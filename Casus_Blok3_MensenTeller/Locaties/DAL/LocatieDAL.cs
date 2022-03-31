using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_Blok3_MensenTeller.Locaties.DAL
{
    public class LocatieDAL
    {
        private string conString = "";

        public void Create(Locatie l)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string query = "INSERT INTO Locaties (Adres,Nummer,Toevoeging,Plaats,Postcode) VALUES (@adres, @nummer,@toevoeging,@plaats,@postcode)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@adres", l.Adres);
                cmd.Parameters.AddWithValue("@nummer", l.Nummer);
                cmd.Parameters.AddWithValue("@toevoeging", l.Toevoeging);
                cmd.Parameters.AddWithValue("@plaats", l.Plaats);
                cmd.Parameters.AddWithValue("@postcode", l.PostCode);
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
                string query = "SELECT * FROM Locaties WHERE vestigingId = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    return new Locatie(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                }
            }
            return l;
        }
        public void Update(Locatie l)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string query = "UPDATE Locaties SET Adres = @adres, Nummer = @nummer, Toevoeging = @toevoeging, Plaats = @plaats, Postcode = @postcode WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@adres", l.Adres);
                cmd.Parameters.AddWithValue("@nummer", l.Nummer);
                cmd.Parameters.AddWithValue("@toevoeging", l.Toevoeging);
                cmd.Parameters.AddWithValue("@plaats", l.Plaats);
                cmd.Parameters.AddWithValue("@postcode", l.PostCode);
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

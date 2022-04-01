using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_Blok3_MensenTeller.Ruimtes
{
    public class DALRuimte
    {
        public string connectionString = "";
        public List<Ruimte> RuimteList { get; set;}

        public void CreateRuimte (Ruimte ruimte)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO ruimte (name, zone) VALUES (@name, @zone)";
                    command.Parameters.AddWithValue("@name", ruimte.Name);
                    command.Parameters.AddWithValue("@zone", ruimte.Zones);
                    command.ExecuteNonQuery();

                    command.CommandText = "SELECT CAST(@@Identity AS INT;";
                    int id = 0;
                    try
                    {
                        id = (int)command.ExecuteScalar();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    ReadRuimte();
                }
            }
        }

        public void ReadRuimte()
        {
            RuimteList.Clear();

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "SELECT Id, name, zone FORM Ruimte ORDER BY Id";
                    SqlDataReader datareader = command.ExecuteReader();

                    while (datareader.Read())
                    {
                        RuimteList.Add(new Ruimte(Int32.Parse(datareader[0].ToString()),
                                                              datareader[1].ToString()
                                                              ));
                    }
                }
            }
        }

        public void DeleteRuimte(int id)
        {
            RuimteList.Clear();

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "DELETE ruimte FROM Ruimte WHERE Id = @Id;";
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditRuimte(int id, string name)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "UPDATE Ruimte SET name = @name WHERE Id = @id";
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("name", name);
                    command.ExecuteNonQuery();
                }
            }
            ReadRuimte();
        }

    }
}

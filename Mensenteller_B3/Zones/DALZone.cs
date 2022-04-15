
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mensenteller_B3.Bedrijven;
using MensenTeller_B3.Sensors;

namespace MensenTeller_B3.Zones
{
    public class DALZone
    {
        public string connectionString = "Data Source=.;Initial Catalog=Mensenteller;Integrated Security=True";
        public List<Sensor> sensors { get; set; }
        public List<Zone> ZoneList { get; set; } = new List<Zone>();

        public void CreateZone(Zone zone)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO zones (name, BedrijvenId) VALUES (@name, @bedrijvenId)";
                    command.Parameters.AddWithValue("@name", zone.Name);
                    command.Parameters.AddWithValue("@bedrijvenId", zone.BedrijvenId);
                    command.ExecuteNonQuery();

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
                    ReadZone();
                }
            }
       }



        public void ReadZone()
        {
            if (ZoneList != null)
            {
               ZoneList.Clear();
            }
          

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "SELECT Id, Name, BedrijvenId FROM Zones ORDER BY Id";
                    SqlDataReader datareader = command.ExecuteReader();

                    while (datareader.Read())
                    {
                        Zone z = new Zone
                        {
                            ID = datareader.GetInt32(0),
                            Name = datareader.GetString(1),
                            BedrijvenId = datareader.GetInt32(2)
                        };
                        ZoneList.Add(z);
                    }
                }
            }
        }
        //ReadZone Maken SELECT Id,Name FROM Zones WHERE bedrijf id =@id ofzoiets.
        public void ReadZone(int id)
        {
            if (ZoneList != null)
            {
                ZoneList.Clear();
            }


            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "SELECT Id, Name, BedrijvenId FROM Zones WHERE BedrijvenId = @Id";
                    command.Parameters.AddWithValue("@Id", id);
                    SqlDataReader datareader = command.ExecuteReader();

                    while (datareader.Read())
                    {
                        Zone z = new Zone
                        {
                            ID = datareader.GetInt32(0),
                            Name = datareader.GetString(1),
                            BedrijvenId = datareader.GetInt32(2)
                        };
                        ZoneList.Add(z);
                    }
                }
            }
        }
        public void DeleteZone(int id)
        {
            ZoneList.Clear();

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "DELETE FROM zones WHERE Id = @Id;";
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditZone(int id, string name)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "UPDATE Zones SET name = @name WHERE Id = @id";
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("name", name);
                    command.ExecuteNonQuery();
                }
            }

        }

    }
}

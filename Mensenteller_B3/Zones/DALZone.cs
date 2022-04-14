﻿
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
        public string connectionString = "";
        public List<Sensor> sensors { get; set; }
        public List<Zone> ZoneList { get; set; }

        public void CreateZone(Bedrijf bedrijf, Zone zone)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO zone (name, BedrijvenId) VALUES (@name, @bedrijvenId)";
                    command.Parameters.AddWithValue("@name", zone.Name);
                    //TODO: omzetten naar sensor DAL
                    
                    command.Parameters.AddWithValue("@bedrijvenId", bedrijf.Id);
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
            ZoneList.Clear();

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "SELECT Id, Name, BedrijvenId FROM Zone ORDER BY Id";
                    SqlDataReader datareader = command.ExecuteReader();

                    while (datareader.Read())
                    {
                        ZoneList.Add(new Zone(Int32.Parse(datareader[0].ToString()),
                                                              datareader[1].ToString()
                                                              ));
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
                    command.CommandText = "DELETE zone FROM zone WHERE Id = @Id;";
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
                    command.CommandText = "UPDATE Zone SET name = @name WHERE Id = @id";
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("name", name);
                    command.ExecuteNonQuery();
                }
            }
            ReadZone();
        }

    }
}


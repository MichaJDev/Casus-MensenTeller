using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Casus_Blok3_MensenTeller.Vestigingen
{
    class Vestiging_DAL
    {

        // Connectionstring die de connectie maakt naar de database
        private string connectionString = "";

        // List van de clasS
        public List<Vestiging> vestigingen = new List<Vestiging>();





        //---------------------------------------------------LOCATION--------------------------------------------------------

        //----------location form3

        //---------------------------------------------------CREATE---------------------------------------------------------
        public void CreateVestiging(Vestiging vestiging)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())

                {
                    command.Connection = connection;
                    //In locatie database wordt in straat,postcode,nummer de waardes ingevuld die ingevuld zijn als value's door de gebruiker
                    command.CommandText = "INSERT INTO Vestiging (Name) VALUES (@Name);";
                    command.Parameters.AddWithValue("@Name", vestiging.Name);
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
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
                    command.CommandText = "SELECT * FROM Vestiging WHERE ID = @id";
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        vestiging.Name = reader[1].ToString();
                    }


                    Console.WriteLine(vestiging.Name);
                    ReadVestiging();
                }
            }
        }

        //---------------------------------READ--------------------------------------------
        public void ReadVestiging()
        {
            vestigingen.Clear();

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "SELECT Id, Name FROM Vestiging ORDER BY id";
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        vestigingen.Add(new Vestiging(int.Parse(dataReader[0].ToString())
                         , dataReader[1].ToString()));

                    }

                }
            }
        }

        //-----------------------------------------DELETE----------------------------------------
        public void DeleteVestigingId(int id)
        {


            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "DELETE Vestiging FROM vestiging WHERE id = @id;";
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
            ReadVestiging();


        }

        //-------------------------------------------EDIT-----------------------------------------
        public void EditVestigingByid(int id, string name)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "UPDATE Vestiging SET name = @name WHERE  id = @id ";
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", name);
                    command.ExecuteNonQuery();

                }

            }
            ReadVestiging();
        }

    }
}




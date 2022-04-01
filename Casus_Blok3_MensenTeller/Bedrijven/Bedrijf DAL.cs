using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Casus_Blok3_MensenTeller
{
    class Bedrijf_DAL
    {

        // Connectionstring die de connectie maakt naar de database
        private string connectionString = "";

        // List van de classes
        public List<Bedrijf> bedrijf = new List<Bedrijf>();
        



        //locatie functies : Create, Delete, edit , read

        //---------------------------------------------------LOCATION--------------------------------------------------------

        //----------location form3

        //---------------------------------------------------CREATE---------------------------------------------------------
        public void CreateBedrijf(Bedrijf bedrijf)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())

                {
                    command.Connection = connection;
                    //In locatie database wordt in straat,postcode,nummer de waardes ingevuld die ingevuld zijn als value's door de gebruiker
                    command.CommandText = "INSERT INTO Bedrijf (Name) VALUES (@Name);";
                    command.Parameters.AddWithValue("@Name", bedrijf.Name);
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
                    command.CommandText = "SELECT * FROM Locatie WHERE ID = @id";
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        bedrijf.Name = reader[1].ToString();
                    }


                    Console.WriteLine(bedrijf.Name);
                    ReadBedrijf();
                }
            }
        }

        //---------------------------------READ--------------------------------------------
        public void ReadBedrijf()
        {
            bedrijf.Clear();

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "SELECT Id, Name FROM Bedrijf ORDER BY id";
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        bedrijf.Add(new Bedrijf(Int32.Parse(dataReader[0].ToString())
                         , dataReader[1].ToString(),
                         dataReader[2].ToString()));
                 
 






                    }


                }
            }
        }

        //-----------------------------------------DELETE----------------------------------------
        public void DeleteBedrijfId(int id)
        {


            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "DELETE Bedrijf FROM bedrijf WHERE id = @id;";
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
            ReadBedrijf();


        }

        //-------------------------------------------EDIT-----------------------------------------
        public void EditBedrijfByid(int id, string name)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    command.Connection = cnn;
                    command.CommandText = "UPDATE Bedrijf SET name = @name WHERE  id = @id ";
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", name);
                    command.ExecuteNonQuery();

                }

            }
            ReadBedrijf();
        }

    }
}

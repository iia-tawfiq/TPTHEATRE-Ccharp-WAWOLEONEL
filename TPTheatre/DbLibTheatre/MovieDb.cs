using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLibTheatre
{
    public class MovieDb
    {
        public static Movie Find(int Id)
        {
            MySqlConnection connection = new MySqlConnection(Db.ConnectionString);
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = $@"
            SELECT Id, Title, Duration FROM movie WHERE Id =@Id;";
            command.Parameters.AddWithValue("@Id", Id);
            MySqlDataReader reader = command.ExecuteReader();
            Movie mo = null;
            while (reader.Read())
            {
                mo = new Movie();
                mo.id = reader.GetInt32("Id");
                mo.title = reader.GetString("nom");
                mo.duration = reader.GetInt32("prenom");

            }



            connection.Close();
            return mo;
        }
        public static List<Movie> All()
        {
            MySqlConnection connection = new MySqlConnection(Db.ConnectionString);

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = $@"
            SELECT Id, Title, Duration FROM movie  ORDER BY Id   ; ";


            MySqlDataReader reader = command.ExecuteReader();
            List<Movie> movies = new List<Movie>();
            while (reader.Read())
            {
                Movie mo = new Movie();
                mo.id = reader.GetInt32("id");
                mo.title = reader.GetString("title");
                mo.duration = reader.GetInt32("duration");

                movies.Add(mo);
            }



            connection.Close();
            return movies;
        }
    }
}

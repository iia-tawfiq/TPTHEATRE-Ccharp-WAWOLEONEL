using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DbLibTheatre
{
    public class EditionDb
    {
        public static Edition Find(int Id)
        {
            MySqlConnection connection = new MySqlConnection(Db.ConnectionString);
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = $@"
            SELECT Id, `year` FROM edition WHERE Id =@Id;";
            command.Parameters.AddWithValue("@Id", Id);
            MySqlDataReader reader = command.ExecuteReader();
            Edition e = null;
            while (reader.Read())
            {
                e = new Edition();
                e.Id = reader.GetInt32("Id");
                e.annee = reader.GetString("annee");
                
            }



            connection.Close();
            return e;
        }
    }
}

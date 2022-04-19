using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLibTheatre
{
    public class MemberDb
    {
        public static Member Find(int Id)
        {
            MySqlConnection connection = new MySqlConnection(Db.ConnectionString);
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = $@"
            SELECT Id, Lastname, Firstname FROM `member` WHERE Id =@Id;";
            command.Parameters.AddWithValue("@Id", Id);
            MySqlDataReader reader = command.ExecuteReader();
            Member m = null;
            while (reader.Read())
            {
                m = new Member();
                m.id = reader.GetInt32("Id");
                m.nom = reader.GetString("nom");
                m.prenom = reader.GetString("prenom");

            }



            connection.Close();
            return m;
        }

        public static List<Member> All()
        {
            MySqlConnection connection = new MySqlConnection(Db.ConnectionString);

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = $@"
            SELECT Id, Lastname, Firstname FROM `member`  ORDER BY Id   ;";


            MySqlDataReader reader = command.ExecuteReader();
            List<Member> members = new List<Member>();
            while (reader.Read())
            {
                Member m = new Member();
                m.id = reader.GetInt32("Id");
                m.nom = reader.GetString("nom");
                m.prenom = reader.GetString("prenom");

                members.Add(m);
            }



            connection.Close();
            return members;
        }
    }
}

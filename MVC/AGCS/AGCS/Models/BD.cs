using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace AGCS.Models
{
    public class BD
    {
       //public static string connectionString = "Server=127.0.0.1;User=root;Database=pruebaclientes"; //Anush
        public static string connectionString = "Server=localhost;User=root;Database=pruebaclientes"; //Ort
        public static List<Client> ListOfClients = new List<Client>();
        public static Client OneClient;



        //Funciones para la bd
        public static MySqlConnection Connect()
        {
             MySqlConnection Connection = new MySqlConnection(connectionString);
            Connection.Open();
             return Connection;
        }

        public static void Disconect(MySqlConnection Connection)
        {
            Connection.Close();
        }

        //Bring objects 
            //Bring Clients
        public static void BringOneClient(int id)
        {
            ListOfClients.Clear();   
            MySqlConnection Connection = Connect();            
            MySqlCommand CommandConnection = Connection.CreateCommand();
            CommandConnection.CommandType = System.Data.CommandType.StoredProcedure;
            CommandConnection.CommandText = "sp_BringOneClient";
            CommandConnection.Parameters.AddWithValue("id", id);
            MySqlDataReader ConnectionReader = CommandConnection.ExecuteReader();
            if (ConnectionReader.Read())
            {
                OneClient = new Client(
                   Convert.ToInt32(ConnectionReader["idclients"]),
                   ConnectionReader["Name"].ToString(),
                   ConnectionReader["Surname"].ToString(),
                   Convert.ToInt32(ConnectionReader["Dni"]),
                   ConnectionReader["Email"].ToString(),
                   Convert.ToInt32(ConnectionReader["Telephone"]),
                   Convert.ToInt32(ConnectionReader["Cellphone"]),
                   ConnectionReader["Town"].ToString(),
                   ConnectionReader["address"].ToString(),
                   ConnectionReader["Province"].ToString(),
                   ConnectionReader["Leter"].ToString(),
                   Convert.ToInt32(ConnectionReader["Number"]),
                   Convert.ToInt32(ConnectionReader["Floor"]));
            }
                
            Disconect(Connection);
        }
        public static void BringClients()
        {
            ListOfClients.Clear();
            MySqlConnection Connection = Connect();
            MySqlCommand CommandConnection = Connection.CreateCommand();
            CommandConnection.CommandType = System.Data.CommandType.StoredProcedure;
            CommandConnection.CommandText = "sp_BringClients";
            MySqlDataReader ConnectionReader = CommandConnection.ExecuteReader();
            while (ConnectionReader.Read())
            {
                Client OneClient = new Client(
                    Convert.ToInt32(ConnectionReader["idclients"]),
                    ConnectionReader["Name"].ToString(),
                    ConnectionReader["Surname"].ToString(),
                    Convert.ToInt32(ConnectionReader["Dni"]),
                    ConnectionReader["Email"].ToString(),
                    Convert.ToInt32(ConnectionReader["Cellphone"]));
                ListOfClients.Add(OneClient);
            }
            Disconect(Connection);
        }
    }
}

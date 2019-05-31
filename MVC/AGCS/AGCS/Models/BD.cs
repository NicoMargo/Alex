﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace AGCS.Models
{
    public class BD
    {
       //public static string connectionString = "Server=127.0.0.1;User=root;Database=pruebaclientes"; //Anush
        public static string connectionString = "Server=localhost;User=root;Database=bd_agcs"; //Ort
        public static List<Client> ListOfClients = new List<Client>();
        public static Client OneClient;
        public static int idBusiness = 1;

        private static string CheckNullString(MySqlDataReader ConnectionReader, string parameter) {
            string result = "";
            try { result = ConnectionReader[parameter].ToString(); } catch {}
            return result;

        }
        private static int CheckNullInt(MySqlDataReader ConnectionReader, string parameter) {
            int result = 0;
            try { result = Convert.ToInt32(ConnectionReader["parameter"]); } catch { }
            return result;
        }
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
     
        public static void GetClients(int idBusiness)
        {
            ListOfClients.Clear();
            MySqlConnection Connection = Connect();
            MySqlCommand CommandConnection = Connection.CreateCommand();
            CommandConnection.CommandType = System.Data.CommandType.StoredProcedure;
            CommandConnection.CommandText = "spGetClients";
            CommandConnection.Parameters.AddWithValue("@idBusiness", idBusiness);
            MySqlDataReader ConnectionReader = CommandConnection.ExecuteReader();
            while (ConnectionReader.Read())
            {
                int id;
                string name;
                string surname;
                int dni;
                string eMail;
                int telephone;
                try
                {
                    id = Convert.ToInt32(ConnectionReader["idClients"]);
                    name = CheckNullString(ConnectionReader,"Name"); 
                    surname = CheckNullString(ConnectionReader,"Surname");
                    dni = CheckNullInt(ConnectionReader,"DNI_CUIT"); 
                    eMail = CheckNullString(ConnectionReader,"eMail");
                    telephone = CheckNullInt(ConnectionReader,"Telephone");
                    Client client = new Client(id, name, surname, dni, eMail, telephone);
                    ListOfClients.Add(client);
                }
                catch { }
            }
            Disconect(Connection);
        }

        public static void GetOneClient(int idClient, int idBusiness)
        {
            Client client;
            MySqlConnection Connection = Connect();
            MySqlCommand CommandConnection = Connection.CreateCommand();
            CommandConnection.CommandType = System.Data.CommandType.StoredProcedure;
            CommandConnection.CommandText = "spGetOneClient";
            CommandConnection.Parameters.AddWithValue("@id", idClient);
            CommandConnection.Parameters.AddWithValue("@idBusiness", idBusiness);
            MySqlDataReader ConnectionReader = CommandConnection.ExecuteReader();
            if (ConnectionReader.Read())
            {
                string name, surname, email;
                int id, dni, telephone;
                try { } catch { }
                /*Addres info ...*/
                id = Convert.ToInt32(ConnectionReader["idClients"]);
                name = CheckNullString(ConnectionReader, "Name");
                surname = CheckNullString(ConnectionReader, "Surname");
                dni = CheckNullInt(ConnectionReader, "DNI_CUIT");
                email = CheckNullString(ConnectionReader, "eMail");
                telephone = CheckNullInt(ConnectionReader, "Telephone");
                client = new Client(id, name, surname, dni, email, telephone);
                ListOfClients.Add(client);
            }
            else { client = null; }
            Disconect(Connection);
            OneClient =  client;
        }

        public static void InsertClient(Client client)
        {
            MySqlConnection Connection = Connect();
            MySqlCommand CommandConnection = Connection.CreateCommand();
            CommandConnection.CommandType = System.Data.CommandType.StoredProcedure;
            CommandConnection.CommandText = "spInsertClient";
            CommandConnection.Parameters.AddWithValue("@idBusiness", idBusiness);
            CommandConnection.Parameters.AddWithValue("@Name", client.Name);
            CommandConnection.Parameters.AddWithValue("@Surname", client.Surname);
            CommandConnection.Parameters.AddWithValue("@DNI_CUIT", client.Dni);
            CommandConnection.Parameters.AddWithValue("@eMail", client.Email);
            CommandConnection.Parameters.AddWithValue("@Telephone", client.Telephone);
            CommandConnection.Parameters.AddWithValue("@Address", "Calle 66306613333");
            CommandConnection.Parameters.AddWithValue("@Locality", "");
            CommandConnection.Parameters.AddWithValue("@idProvince", 0);
            CommandConnection.Parameters.AddWithValue("@idDelivery", 0);
            CommandConnection.Parameters.AddWithValue("@Comments", "");

            CommandConnection.ExecuteNonQuery();
            Disconect(Connection);

        }
        public static void UpdateClient(Client client)
        {
            MySqlConnection Connection = Connect();
            MySqlCommand CommandConnection = Connection.CreateCommand();
            CommandConnection.CommandType = System.Data.CommandType.StoredProcedure;
            CommandConnection.CommandText = "spUpdateClient";
            CommandConnection.Parameters.AddWithValue("@id", client.Id);
            CommandConnection.Parameters.AddWithValue("@idBusiness", idBusiness);
            CommandConnection.Parameters.AddWithValue("@Name", client.Name);
            CommandConnection.Parameters.AddWithValue("@Surname", client.Surname);
            CommandConnection.Parameters.AddWithValue("@DNI_CUIT", client.Dni);
            CommandConnection.Parameters.AddWithValue("@eMail", client.Email);
            CommandConnection.Parameters.AddWithValue("@Telephone", client.Telephone);
            /*
            CommandConnection.Parameters.AddWithValue("@Locality", "");
            CommandConnection.Parameters.AddWithValue("@idProvince", 0);
            CommandConnection.Parameters.AddWithValue("@idDelivery", 0);
            CommandConnection.Parameters.AddWithValue("@Comments", "");
            */
            CommandConnection.ExecuteNonQuery();
            Disconect(Connection);

        }

        public static void DeleteClient(int id)
        {
            MySqlConnection Connection = Connect();
            MySqlCommand CommandConnection = Connection.CreateCommand();
            CommandConnection.CommandType = System.Data.CommandType.StoredProcedure;
            CommandConnection.CommandText = "spDeleteClient";
            CommandConnection.Parameters.AddWithValue("@id", id);
            CommandConnection.Parameters.AddWithValue("@idBusiness", idBusiness);
            CommandConnection.ExecuteNonQuery();
            Disconect(Connection);
        }
    }
}

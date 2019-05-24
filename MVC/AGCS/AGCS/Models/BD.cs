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
        public static string connectionString = "Server=localhost;User=root;Database=bd_agcs;Uid=Jonyloco;Pwd=agcs;"; //Ort
        public static List<Client> ListOfClients = new List<Client>();
        public static int idBusiness = 1;


        //Funciones para la bd
        public static MySqlConnection Conect()
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
        public static void BringClients()
        {
            ListOfClients.Clear();
            MySqlConnection Connection = Conect();
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
                    Convert.ToInt32(ConnectionReader["Telephone"]),
                    Convert.ToInt32(ConnectionReader["Cellphone"]),
                    ConnectionReader["Town"].ToString(),
                    ConnectionReader["address"].ToString(),
                    ConnectionReader["Province"].ToString(),
                    ConnectionReader["Leter"].ToString(),
                    Convert.ToInt32(ConnectionReader["Number"]),
                    Convert.ToInt32(ConnectionReader["Floor"]));
                ListOfClients.Add(OneClient);
            }
            Disconect(Connection);
        }

        public static void GetClients(int idBusiness)
        {
            ListOfClients.Clear();
            MySqlConnection Connection = Conect();
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
                    try { name = ConnectionReader["Name"].ToString(); } catch (Exception e) { name = ""; }
                    try { surname = ConnectionReader["Surname"].ToString(); } catch (Exception e) { surname = ""; }
                    try { dni = Convert.ToInt32(ConnectionReader["DNI_CUIT"]); } catch (Exception e) { dni = -1; }
                    try { eMail = ConnectionReader["eMail"].ToString(); } catch (Exception e) { eMail = ""; }
                    try { telephone = Convert.ToInt32(ConnectionReader["Telephone"]); } catch (Exception e) { telephone = -1; }
                    Client client = new Client(id, name, surname, dni, eMail, telephone);
                    ListOfClients.Add(client);
                }
                catch (Exception e){ }
            }
            Disconect(Connection);
        }

        public static Client GetOneClient(int idClient,int idBusiness)
        {
            Client client;
            MySqlConnection Connection = Conect();
            MySqlCommand CommandConnection = Connection.CreateCommand();
            CommandConnection.CommandType = System.Data.CommandType.StoredProcedure;
            CommandConnection.CommandText = "spGetClients";
            CommandConnection.Parameters.AddWithValue("@idBusiness", idBusiness);
            MySqlDataReader ConnectionReader = CommandConnection.ExecuteReader();
            if (ConnectionReader.Read())
            {
                client = new Client(
                Convert.ToInt32(ConnectionReader["idClients"]),
                ConnectionReader["Name"].ToString(),
                ConnectionReader["Surname"].ToString(),
                Convert.ToInt32(ConnectionReader["DNI_CUIT"]),
                ConnectionReader["eMail"].ToString(),
                Convert.ToInt32(ConnectionReader["Telephone"]));
                    /*Addres info ...*/
            }
            else { client = null; }
            Disconect(Connection);
            return client;
        }

        public static void InsertClient(Client client)
        {
            MySqlConnection Connection = Conect();
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
            MySqlConnection Connection = Conect();
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
            MySqlConnection Connection = Conect();
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
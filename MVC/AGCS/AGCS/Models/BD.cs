using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace AGCS.Models
{
    public class BD
    {
        public static string connectionString = "Server=127.0.0.1;User=root;Database=pruebaclientes"; //Ort
      //public static string connectionString = @"Server=DESKTOP-5P28OS5;Database=QEQA03;Trusted_Connection=True;"; //Anush
      //public static string connectionString = @"Server=DESKTOP-P6PCH8N\SQLEXPRESS;Database=QEQA03;Trusted_Connection=True;"; //Chino




        //Funciones para la bd=====================================================================================
        public static MySqlConnection Conectar()
        {
             MySqlConnection conexion = new MySqlConnection(connectionString);
             conexion.Open();
             return conexion;
        }

        public static void Desconectar(MySqlConnection conexion)
        {
            conexion.Close();
        }
      

    }
}

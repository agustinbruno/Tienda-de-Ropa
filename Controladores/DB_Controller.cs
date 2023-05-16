﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Ropa.Controladores
{
    public static class DB_Controller
    {
        private static string connectionString = "";
        public static SqlConnection connection;

        public static void initialize()
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-F0RDMJD\\SQLEXPRESS";
            builder.InitialCatalog = "local";
            builder.IntegratedSecurity = true;

            connectionString = builder.ToString();
            connection = new SqlConnection(connectionString);



            /* Coneccion MySQLWorkbench
            string connectionString2 = "server=localhost;user=root;database=tienda_de_ropa;password=admin";
            MySqlConnection connection2 = new MySqlConnection(connectionString2);
            */


            Trace.WriteLine("Conexion a la DB: " + connection);
        }

        public static bool validateConnection()
        {
            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                return false;
            }
        }

    }
}

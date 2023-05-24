using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Tienda_de_Ropa.Modelos;

namespace Tienda_de_Ropa.Controladores
{
    internal class Usuario_Controller
    {
        public static bool validarUsuario(string usuario, string contraseña){

            string query = "SELECT COUNT(*) FROM empleado WHERE usuario = @usuario AND contraseña = @contraseña";
            SqlCommand cmd = new SqlCommand (query,DB_Controller.connection);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);
            try
            {

                DB_Controller.connection.Open();
                int count = (int)cmd.ExecuteScalar();
                DB_Controller.connection.Close();

                if (count > 0) {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static Empleado obtenerEmpleado(string usuario)
        {
            string query = "SELECT COUNT(*) FROM empleado WHERE usuario = @usuario";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            try
            {
                Empleado emp = null;
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    emp = new Empleado(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
                }

                reader.Close();
                DB_Controller.connection.Close();

                return emp;
            }
            catch (Exception ex)
            {
                DB_Controller.connection.Close();
                throw new Exception(ex.Message);
            }          
        }

        
    }
}

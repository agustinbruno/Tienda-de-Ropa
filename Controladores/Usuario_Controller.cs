using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        
    }
}

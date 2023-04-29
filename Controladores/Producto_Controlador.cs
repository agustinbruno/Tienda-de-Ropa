using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_de_Ropa.Modelos;

namespace Tienda_de_Ropa.Controladores
{
    public class Producto_Controlador
    {
        static string ruta = "../../Resources/productos.txt";

        public static bool crearProducto(Producto producto)
        {
            string query = "insert into dbo.producto values" +
                "(@id, " +
                "@nombre, " +
                "@descripcion, " +
                "@precio, " +
                "@activo " +
                ");";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", producto.Id);
            cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion);
            cmd.Parameters.AddWithValue("@precio", producto.Precio);
            cmd.Parameters.AddWithValue("@activo", producto.Activo);

            /*Este try catch, me genera excepciones que no entiendo
 
            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
            */


            try
            {
                string linea = producto.Id + ";" + producto.Nombre + ";" + producto.Descripcion + ";" + producto.Precio + ";" + producto.Activo;
                StreamWriter archivo = new StreamWriter(ruta, true);
                archivo.WriteLine(linea);
                archivo.Close();

                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Ocurrio un error al intentar escribir el producto: " + ex.Message);
                return false;
            }
        }
    }
}

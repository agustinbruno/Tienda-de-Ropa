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
                "@precio " + 
                ");";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", producto.Id);
            cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion);
            cmd.Parameters.AddWithValue("@precio", producto.Precio);
 
            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            


            try
            {
                string linea = producto.Id + ";" + producto.Nombre + ";" + producto.Descripcion + ";" + producto.Precio;
                using (StreamWriter archivo = new StreamWriter(ruta, true))
                {
                    archivo.WriteLine(linea);
                }
                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Ocurrio un error al intentar escribir el producto: " + ex.Message);
                return false;
            }
        }


        public static bool modificarProducto(Producto producto)
        {
            string query = "insert into dbo.producto values" +
                "(@id, " +
                "@nombre, " +
                "@descripcion, " +
                "@precio " +
                ");";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", producto.Id);
            cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion);
            cmd.Parameters.AddWithValue("@precio", producto.Precio);

            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



            try
            {
                string linea = producto.Id + ";" + producto.Nombre + ";" + producto.Descripcion + ";" + producto.Precio;
                using (StreamWriter archivo = new StreamWriter(ruta, true))
                {
                    archivo.WriteLine(linea);
                }
                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Ocurrio un error al intentar modificar el producto: " + ex.Message);
                return false;
            }
        }

        public static void cambiarEstadoProducto(int id)
        {
            string query = "update dbo.producto set activo = 0 where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

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
        }

        public static Producto obtenerProducto(int id)
        {
            Producto producto = new Producto();
            string query = "select * from dbo.producto WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("id", id);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Trace.WriteLine("Prod encontrado, nombre: " + reader.GetString(0));
                    producto = new Producto(reader.GetInt32(0),reader.GetString(1),reader.GetString(2),reader.GetDecimal(3));
                }
                reader.Close();
                DB_Controller.connection.Close();
                return producto;
            }
            catch(Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
        }

        public static List<Producto> obtenerTodos()
        {
            List<Producto> list = new List<Producto>();
            string query = "select * from dbo.producto";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Producto(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3)));
                    Trace.WriteLine("Prod encontrado, nombre: " + reader.GetString(1));
                }
                reader.Close();
                DB_Controller.connection.Close();
            }
            catch(Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
            return list;
        }


    }
}

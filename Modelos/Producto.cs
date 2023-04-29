using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Ropa.Modelos
{
    public class Producto
    {
        public int Id { get; set; }

        public String Nombre { get; set; }

        public String Descripcion { get; set; }

        public double Precio { get; set; }

        public bool Activo { get; set; }

        public Producto(int id, string nombre, string descripcion, double precio) {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Activo = true;
        }

        public Producto() { }





    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_de_Ropa.Modelos.Enums;

namespace Tienda_de_Ropa.Modelos
{
    public class Empleado
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Usuario { get; set; }

        public string Contraseña { get; set; }

        public Rol Rol { get; set; }

        public Empleado(int id, string nombre, string contraseña, int rol)
        {
            Id = id;
            Nombre = nombre;
            Contraseña = contraseña;
            Rol = (Rol)rol;
        }

    }
}

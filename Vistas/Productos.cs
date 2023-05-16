using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda_de_Ropa.Controladores;
using Tienda_de_Ropa.Modelos;

namespace Tienda_de_Ropa.Vistas
{
    public partial class Productos : Form
    {
        List<Producto> productos;
        public Productos()
        {
            InitializeComponent();
            mostrarProductos();
        }

        private void mostrarProductos()
        {
            productos = Producto_Controlador.obtenerTodos();
            tablaProductos.Rows.Clear();
            foreach(Producto prod in productos)
            {
                int rowIndex = tablaProductos.Rows.Add();

                tablaProductos.Rows[rowIndex].Height = 150;

                tablaProductos.Rows[rowIndex].Cells[0].Value = prod.Id.ToString();
                tablaProductos.Rows[rowIndex].Cells[1].Value = prod.Nombre.ToString();
                tablaProductos.Rows[rowIndex].Cells[2].Value = prod.Descripcion.ToString();
                tablaProductos.Rows[rowIndex].Cells[3].Value = prod.Precio.ToString();
            }

        }
    }
}

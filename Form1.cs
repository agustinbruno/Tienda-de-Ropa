using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda_de_Ropa.Controladores;
using Tienda_de_Ropa.Modelos;

namespace Tienda_de_Ropa
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

         
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto(int.Parse(txt_id.Text),txt_nombre.Text, txt_descripcion.Text, double.Parse(txt_precio.Text));

            if (Producto_Controlador.crearProducto(producto))
            {
                Trace.WriteLine("Producto creado con exito");
            }
            else
            {
                Trace.WriteLine("Fallo la creacion del producto");
            }
        }
    }
}

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
using Tienda_de_Ropa.Vistas;

namespace Tienda_de_Ropa
{
    public partial class AgregarProductos : Form
    {
        
        public AgregarProductos()
        {
            InitializeComponent();
            error_id.Hide();
            error_nombre.Hide();
            error_descripcion.Hide();
            error_precio.Hide();


        }


        private bool validarInputs(out string errorMsg)
        {
            errorMsg = string.Empty;

            if (string.IsNullOrEmpty(txt_nombre.Text))
            {
                errorMsg = "Debe indicar el nombre del producto" + Environment.NewLine;
                error_nombre.Text = "Debe indicar el nombre del producto";
                error_nombre.Show();
            }
            if (string.IsNullOrEmpty(txt_id.Text))
            {
                errorMsg = "Debe indicar el id del producto" + Environment.NewLine;
                error_id.Text = "Debe indicar el id del producto";
                error_id.Show();
            }
            if (string.IsNullOrEmpty(txt_descripcion.Text))
            {
                errorMsg = "Debe indicar la descripcion del producto" + Environment.NewLine;
                error_descripcion.Text = "Debe indicar la descripcion del producto";
                error_descripcion.Show();
            }
            if (string.IsNullOrEmpty(txt_precio.Text))
            {
                errorMsg = "Debe indicar el precio del producto" + Environment.NewLine;
                error_precio.Text = "Debe indicar el precio del producto";
                error_precio.Show();
            }
            return errorMsg == string.Empty;

        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            bool inputsValidos = validarInputs(out string errorMsg);

            Trace.WriteLine("inputs validados con resultado: " + inputsValidos);

            
                if (inputsValidos)
                {
                    Producto producto = new Producto(int.Parse(txt_id.Text), txt_nombre.Text, txt_descripcion.Text, decimal.Parse(txt_precio.Text));
                    Producto_Controlador.crearProducto(producto);
                    MessageBox.Show("Producto creado con exito");
                    AgregarProductos agregarProductos = new AgregarProductos();
                    this.Hide();
                    agregarProductos.Close();
            }
                else
                {
                    Trace.WriteLine("Fallo la creacion del producto");
                }
            }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        private void btn_atras_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            this.Hide();
            index.Show();
        }

       
    }

      
    }


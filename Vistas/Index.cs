using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_de_Ropa.Vistas
{
    public partial class Index : Form
    {
        public Index(int rol)
        {
            InitializeComponent();
            if(rol == 1)
            {
                button_Productos.Hide();
            }
           
        }    
        private void btn_producto_Click(object sender, EventArgs e)
        {
            AgregarProductos form1 = new AgregarProductos();
            this.Hide();
            form1.ShowDialog();
        }
        private void abrirFormInPanel(object formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0) 
                this.panelContenedor.Controls.RemoveAt(0);          
                Form fh = formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(fh);
                this.panelContenedor.Tag = fh;
                fh.Show();
            
        }

        private void button_Estadisticas_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Estadisticas());
        }

        private void button_Usuarios_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Usuarios());
        }

        private void button_Productos_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Productos());
        }

        private void pictureBox_Burguer_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
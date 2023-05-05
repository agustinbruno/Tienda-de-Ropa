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

namespace Tienda_de_Ropa.Vistas
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            lbl_error_login.Hide();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_usuario.Clear();
            txt_contraseña.Clear();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (validarInputsLogin())
            {
                Trace.WriteLine("Contraseña correcta");
                Index index = new Index();
                this.Hide();
                index.Show();
            }
            else
            {
                txt_usuario.Clear();
                txt_contraseña.Clear();    
            }
            
        }

        private bool validarInputsLogin()
        {

            if (string.IsNullOrEmpty(txt_usuario.Text) || string.IsNullOrEmpty(txt_contraseña.Text))
            {

                lbl_error_login.Text = "Alguno de los campos esta vacio";
                lbl_error_login.Show();
                return false;
            }
            else if (Usuario_Controller.validarUsuario(txt_usuario.Text, txt_contraseña.Text))
            {              
                return true;
            }
            else
            {
                lbl_error_login.Text = "Usuario y/o contraseña incorrecto";
                lbl_error_login.Show();
                return false;
            }

           
        }

    }
}

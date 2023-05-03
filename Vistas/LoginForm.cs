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
using Tienda_de_Ropa.Resources;
using Tienda_de_Ropa.Vistas;

namespace Tienda_de_Ropa.Vistas
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            lbl_error_usuario.Hide();
            lbl_error_contraseña.Hide();
            lbl_error_usuario_contraseña.Hide();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_usuario.Clear();
            txt_contraseña.Clear();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (validarInputsLogin(out string errorMsj))
            {

                if (Usuario_Controller.validarUsuario(txt_usuario.Text,txt_contraseña.Text))
                {
                    Trace.WriteLine("Contraseña correcta");
                    Index index = new Index();
                    this.Hide();
                    index.Show();
                }
                else
                {
                    Trace.WriteLine("Contraseña incorrectaaa");
                    lbl_error_usuario_contraseña.Show();
                }
             
            }
            
        }
           
        private bool validarInputsLogin(out string errorMsj)
        {
            errorMsj = string.Empty;
            if(string.IsNullOrEmpty(txt_usuario.Text) )
            {

            }
            if(string.IsNullOrEmpty(txt_contraseña.Text))
            {

            }

            return errorMsj == String.Empty;
        }

    }
}

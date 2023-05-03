namespace Tienda_de_Ropa.Vistas
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.lbl_titulo_login = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_error_usuario = new System.Windows.Forms.Label();
            this.lbl_error_contraseña = new System.Windows.Forms.Label();
            this.lbl_error_usuario_contraseña = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(232, 289);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Ingresar";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(232, 109);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(189, 20);
            this.txt_usuario.TabIndex = 1;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(116, 116);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_usuario.TabIndex = 2;
            this.lbl_usuario.Text = "Usuario";
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(232, 200);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(187, 20);
            this.txt_contraseña.TabIndex = 3;
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Location = new System.Drawing.Point(116, 203);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(61, 13);
            this.lbl_contraseña.TabIndex = 4;
            this.lbl_contraseña.Text = "Contraseña";
            // 
            // lbl_titulo_login
            // 
            this.lbl_titulo_login.AutoSize = true;
            this.lbl_titulo_login.Location = new System.Drawing.Point(229, 25);
            this.lbl_titulo_login.Name = "lbl_titulo_login";
            this.lbl_titulo_login.Size = new System.Drawing.Size(213, 13);
            this.lbl_titulo_login.TabIndex = 5;
            this.lbl_titulo_login.Text = "Ingrese su nombre de Usuario y Contraseña";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(352, 290);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(89, 21);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_error_usuario
            // 
            this.lbl_error_usuario.AutoSize = true;
            this.lbl_error_usuario.Location = new System.Drawing.Point(463, 104);
            this.lbl_error_usuario.Name = "lbl_error_usuario";
            this.lbl_error_usuario.Size = new System.Drawing.Size(120, 13);
            this.lbl_error_usuario.TabIndex = 7;
            this.lbl_error_usuario.Text = "Error al Ingresar Usuario";
            // 
            // lbl_error_contraseña
            // 
            this.lbl_error_contraseña.AutoSize = true;
            this.lbl_error_contraseña.Location = new System.Drawing.Point(463, 203);
            this.lbl_error_contraseña.Name = "lbl_error_contraseña";
            this.lbl_error_contraseña.Size = new System.Drawing.Size(138, 13);
            this.lbl_error_contraseña.TabIndex = 8;
            this.lbl_error_contraseña.Text = "Error al Ingresar Contraseña";
            // 
            // lbl_error_usuario_contraseña
            // 
            this.lbl_error_usuario_contraseña.AutoSize = true;
            this.lbl_error_usuario_contraseña.Location = new System.Drawing.Point(285, 252);
            this.lbl_error_usuario_contraseña.Name = "lbl_error_usuario_contraseña";
            this.lbl_error_usuario_contraseña.Size = new System.Drawing.Size(156, 13);
            this.lbl_error_usuario_contraseña.TabIndex = 9;
            this.lbl_error_usuario_contraseña.Text = "Error en el usuario y contraseña";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_error_usuario_contraseña);
            this.Controls.Add(this.lbl_error_contraseña);
            this.Controls.Add(this.lbl_error_usuario);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lbl_titulo_login);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_login);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.Label lbl_titulo_login;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_error_usuario;
        private System.Windows.Forms.Label lbl_error_contraseña;
        private System.Windows.Forms.Label lbl_error_usuario_contraseña;
    }
}
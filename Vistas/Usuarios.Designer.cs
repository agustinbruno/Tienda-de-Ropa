namespace Tienda_de_Ropa.Vistas
{
    partial class Usuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.tablaUsuarios = new System.Windows.Forms.DataGridView();
            this.Foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_agregar_usuario = new System.Windows.Forms.Button();
            this.txt_modificar_usuario = new System.Windows.Forms.Button();
            this.txt_eliminar_usuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios";
            // 
            // tablaUsuarios
            // 
            this.tablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Foto,
            this.Id,
            this.Nombre,
            this.Apellido,
            this.Rol});
            this.tablaUsuarios.Location = new System.Drawing.Point(39, 176);
            this.tablaUsuarios.Name = "tablaUsuarios";
            this.tablaUsuarios.Size = new System.Drawing.Size(827, 488);
            this.tablaUsuarios.TabIndex = 1;
            this.tablaUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Foto
            // 
            this.Foto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            this.Foto.Width = 384;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID Usuario";
            this.Id.Name = "Id";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            // 
            // txt_agregar_usuario
            // 
            this.txt_agregar_usuario.Font = new System.Drawing.Font("Roboto Condensed", 12.75F);
            this.txt_agregar_usuario.Location = new System.Drawing.Point(941, 269);
            this.txt_agregar_usuario.Name = "txt_agregar_usuario";
            this.txt_agregar_usuario.Size = new System.Drawing.Size(138, 53);
            this.txt_agregar_usuario.TabIndex = 2;
            this.txt_agregar_usuario.Text = "Agregar Usuario";
            this.txt_agregar_usuario.UseVisualStyleBackColor = true;
            // 
            // txt_modificar_usuario
            // 
            this.txt_modificar_usuario.Font = new System.Drawing.Font("Roboto Condensed", 12.75F);
            this.txt_modificar_usuario.Location = new System.Drawing.Point(941, 382);
            this.txt_modificar_usuario.Name = "txt_modificar_usuario";
            this.txt_modificar_usuario.Size = new System.Drawing.Size(138, 53);
            this.txt_modificar_usuario.TabIndex = 3;
            this.txt_modificar_usuario.Text = "Modificar Usuario";
            this.txt_modificar_usuario.UseVisualStyleBackColor = true;
            // 
            // txt_eliminar_usuario
            // 
            this.txt_eliminar_usuario.Font = new System.Drawing.Font("Roboto Condensed", 12.75F);
            this.txt_eliminar_usuario.Location = new System.Drawing.Point(941, 495);
            this.txt_eliminar_usuario.Name = "txt_eliminar_usuario";
            this.txt_eliminar_usuario.Size = new System.Drawing.Size(138, 53);
            this.txt_eliminar_usuario.TabIndex = 4;
            this.txt_eliminar_usuario.Text = "Eliminar Usuario";
            this.txt_eliminar_usuario.UseVisualStyleBackColor = true;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1153, 703);
            this.Controls.Add(this.txt_eliminar_usuario);
            this.Controls.Add(this.txt_modificar_usuario);
            this.Controls.Add(this.txt_agregar_usuario);
            this.Controls.Add(this.tablaUsuarios);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.Button txt_agregar_usuario;
        private System.Windows.Forms.Button txt_modificar_usuario;
        private System.Windows.Forms.Button txt_eliminar_usuario;
    }
}
﻿namespace Tienda_de_Ropa
{
    partial class AgregarProductos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.titulo_abm = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_crear = new System.Windows.Forms.Button();
            this.precio = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.error_id = new System.Windows.Forms.Label();
            this.error_nombre = new System.Windows.Forms.Label();
            this.error_descripcion = new System.Windows.Forms.Label();
            this.error_precio = new System.Windows.Forms.Label();
            this.btn_atras = new System.Windows.Forms.Button();
            this.imagen = new System.Windows.Forms.Label();
            this.cargarImagen = new System.Windows.Forms.TextBox();
            this.error_imagen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titulo_abm
            // 
            this.titulo_abm.AutoSize = true;
            this.titulo_abm.Font = new System.Drawing.Font("Roboto Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_abm.Location = new System.Drawing.Point(282, 9);
            this.titulo_abm.Name = "titulo_abm";
            this.titulo_abm.Size = new System.Drawing.Size(263, 42);
            this.titulo_abm.TabIndex = 0;
            this.titulo_abm.Text = "Alta de Productos";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Roboto Condensed", 12.75F);
            this.nombre.Location = new System.Drawing.Point(50, 125);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(63, 20);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "Nombre";
            // 
            // descripcion
            // 
            this.descripcion.AutoSize = true;
            this.descripcion.Font = new System.Drawing.Font("Roboto Condensed", 12.75F);
            this.descripcion.Location = new System.Drawing.Point(50, 173);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(89, 20);
            this.descripcion.TabIndex = 2;
            this.descripcion.Text = "Descripcion";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Roboto Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(50, 85);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(23, 20);
            this.id.TabIndex = 3;
            this.id.Text = "ID";
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(195, 125);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(169, 20);
            this.txt_nombre.TabIndex = 4;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(195, 172);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(169, 20);
            this.txt_descripcion.TabIndex = 5;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(195, 85);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(169, 20);
            this.txt_id.TabIndex = 6;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // btn_crear
            // 
            this.btn_crear.Font = new System.Drawing.Font("Roboto Condensed", 12.75F);
            this.btn_crear.Location = new System.Drawing.Point(114, 360);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(187, 53);
            this.btn_crear.TabIndex = 7;
            this.btn_crear.Text = "Crear Producto";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Font = new System.Drawing.Font("Roboto Condensed", 12.75F);
            this.precio.Location = new System.Drawing.Point(50, 221);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(52, 20);
            this.precio.TabIndex = 8;
            this.precio.Text = "Precio";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(195, 219);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(169, 20);
            this.txt_precio.TabIndex = 9;
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // error_id
            // 
            this.error_id.AutoSize = true;
            this.error_id.BackColor = System.Drawing.Color.Transparent;
            this.error_id.Font = new System.Drawing.Font("Roboto Condensed", 12.75F);
            this.error_id.ForeColor = System.Drawing.Color.Red;
            this.error_id.Location = new System.Drawing.Point(402, 85);
            this.error_id.Name = "error_id";
            this.error_id.Size = new System.Drawing.Size(150, 20);
            this.error_id.TabIndex = 10;
            this.error_id.Text = "*Error en el campo Id";
            // 
            // error_nombre
            // 
            this.error_nombre.AutoSize = true;
            this.error_nombre.Font = new System.Drawing.Font("Roboto Condensed", 12.75F);
            this.error_nombre.ForeColor = System.Drawing.Color.Red;
            this.error_nombre.Location = new System.Drawing.Point(402, 125);
            this.error_nombre.Name = "error_nombre";
            this.error_nombre.Size = new System.Drawing.Size(192, 20);
            this.error_nombre.TabIndex = 11;
            this.error_nombre.Text = "*Error en el campo Nombre";
            // 
            // error_descripcion
            // 
            this.error_descripcion.AutoSize = true;
            this.error_descripcion.Font = new System.Drawing.Font("Roboto Condensed", 12.75F);
            this.error_descripcion.ForeColor = System.Drawing.Color.Red;
            this.error_descripcion.Location = new System.Drawing.Point(402, 173);
            this.error_descripcion.Name = "error_descripcion";
            this.error_descripcion.Size = new System.Drawing.Size(218, 20);
            this.error_descripcion.TabIndex = 12;
            this.error_descripcion.Text = "*Error en el campo Descripcion";
            // 
            // error_precio
            // 
            this.error_precio.AutoSize = true;
            this.error_precio.Font = new System.Drawing.Font("Roboto Condensed", 12.75F);
            this.error_precio.ForeColor = System.Drawing.Color.Red;
            this.error_precio.Location = new System.Drawing.Point(402, 219);
            this.error_precio.Name = "error_precio";
            this.error_precio.Size = new System.Drawing.Size(181, 20);
            this.error_precio.TabIndex = 13;
            this.error_precio.Text = "*Error en el campo Precio";
            // 
            // btn_atras
            // 
            this.btn_atras.Font = new System.Drawing.Font("Roboto Condensed", 12.75F);
            this.btn_atras.Location = new System.Drawing.Point(512, 360);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(187, 53);
            this.btn_atras.TabIndex = 14;
            this.btn_atras.Text = "Atras";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // imagen
            // 
            this.imagen.AutoSize = true;
            this.imagen.Font = new System.Drawing.Font("Roboto Condensed", 12.75F);
            this.imagen.Location = new System.Drawing.Point(50, 267);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(58, 20);
            this.imagen.TabIndex = 15;
            this.imagen.Text = "Imagen";
            // 
            // cargarImagen
            // 
            this.cargarImagen.Location = new System.Drawing.Point(195, 267);
            this.cargarImagen.Name = "cargarImagen";
            this.cargarImagen.Size = new System.Drawing.Size(90, 20);
            this.cargarImagen.TabIndex = 16;
            // 
            // error_imagen
            // 
            this.error_imagen.AutoSize = true;
            this.error_imagen.Font = new System.Drawing.Font("Roboto Condensed", 12.75F);
            this.error_imagen.ForeColor = System.Drawing.Color.Red;
            this.error_imagen.Location = new System.Drawing.Point(402, 267);
            this.error_imagen.Name = "error_imagen";
            this.error_imagen.Size = new System.Drawing.Size(179, 20);
            this.error_imagen.TabIndex = 17;
            this.error_imagen.Text = "*Error al cargar la Imagen";
            // 
            // AgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.error_imagen);
            this.Controls.Add(this.cargarImagen);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.error_precio);
            this.Controls.Add(this.error_descripcion);
            this.Controls.Add(this.error_nombre);
            this.Controls.Add(this.error_id);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.id);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.titulo_abm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AgregarProductos";
            this.Text = "Agregar Productos";
            this.Load += new System.EventHandler(this.AgregarProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo_abm;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label error_id;
        private System.Windows.Forms.Label error_nombre;
        private System.Windows.Forms.Label error_descripcion;
        private System.Windows.Forms.Label error_precio;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Label imagen;
        private System.Windows.Forms.TextBox cargarImagen;
        private System.Windows.Forms.Label error_imagen;
    }
}


namespace Tienda_de_Ropa.Vistas
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.btn_producto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Estadisticas = new System.Windows.Forms.Button();
            this.button_Usuarios = new System.Windows.Forms.Button();
            this.button_Productos = new System.Windows.Forms.Button();
            this.pictureBox_Burguer = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Burguer)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_producto
            // 
            this.btn_producto.Location = new System.Drawing.Point(516, 218);
            this.btn_producto.Name = "btn_producto";
            this.btn_producto.Size = new System.Drawing.Size(180, 61);
            this.btn_producto.TabIndex = 0;
            this.btn_producto.Text = "Agregar Producto";
            this.btn_producto.UseVisualStyleBackColor = true;
            this.btn_producto.Click += new System.EventHandler(this.btn_producto_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button_Estadisticas);
            this.panel1.Controls.Add(this.button_Usuarios);
            this.panel1.Controls.Add(this.button_Productos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 628);
            this.panel1.TabIndex = 1;
            // 
            // button_Estadisticas
            // 
            this.button_Estadisticas.FlatAppearance.BorderSize = 0;
            this.button_Estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Estadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button_Estadisticas.Image = ((System.Drawing.Image)(resources.GetObject("button_Estadisticas.Image")));
            this.button_Estadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Estadisticas.Location = new System.Drawing.Point(3, 242);
            this.button_Estadisticas.Name = "button_Estadisticas";
            this.button_Estadisticas.Size = new System.Drawing.Size(180, 37);
            this.button_Estadisticas.TabIndex = 2;
            this.button_Estadisticas.Text = "      Estadisticas";
            this.button_Estadisticas.UseVisualStyleBackColor = true;
            this.button_Estadisticas.Click += new System.EventHandler(this.button_Estadisticas_Click);
            // 
            // button_Usuarios
            // 
            this.button_Usuarios.FlatAppearance.BorderSize = 0;
            this.button_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button_Usuarios.Image = ((System.Drawing.Image)(resources.GetObject("button_Usuarios.Image")));
            this.button_Usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Usuarios.Location = new System.Drawing.Point(0, 184);
            this.button_Usuarios.Name = "button_Usuarios";
            this.button_Usuarios.Size = new System.Drawing.Size(180, 37);
            this.button_Usuarios.TabIndex = 1;
            this.button_Usuarios.Text = "      Usuarios";
            this.button_Usuarios.UseVisualStyleBackColor = true;
            this.button_Usuarios.Click += new System.EventHandler(this.button_Usuarios_Click);
            // 
            // button_Productos
            // 
            this.button_Productos.FlatAppearance.BorderSize = 0;
            this.button_Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button_Productos.Image = ((System.Drawing.Image)(resources.GetObject("button_Productos.Image")));
            this.button_Productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Productos.Location = new System.Drawing.Point(0, 110);
            this.button_Productos.Name = "button_Productos";
            this.button_Productos.Size = new System.Drawing.Size(180, 37);
            this.button_Productos.TabIndex = 0;
            this.button_Productos.Text = "      Productos";
            this.button_Productos.UseVisualStyleBackColor = true;
            this.button_Productos.Click += new System.EventHandler(this.button_Productos_Click_1);
            // 
            // pictureBox_Burguer
            // 
            this.pictureBox_Burguer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Burguer.Image")));
            this.pictureBox_Burguer.Location = new System.Drawing.Point(186, 0);
            this.pictureBox_Burguer.Name = "pictureBox_Burguer";
            this.pictureBox_Burguer.Size = new System.Drawing.Size(44, 27);
            this.pictureBox_Burguer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Burguer.TabIndex = 2;
            this.pictureBox_Burguer.TabStop = false;
            this.pictureBox_Burguer.Click += new System.EventHandler(this.pictureBox_Burguer_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(180, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1000, 628);
            this.panelContenedor.TabIndex = 3;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1180, 628);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.pictureBox_Burguer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_producto);
            this.Name = "Index";
            this.Text = "Index";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Burguer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_producto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Productos;
        private System.Windows.Forms.Button button_Estadisticas;
        private System.Windows.Forms.Button button_Usuarios;
        private System.Windows.Forms.PictureBox pictureBox_Burguer;
        private System.Windows.Forms.Panel panelContenedor;
    }
}
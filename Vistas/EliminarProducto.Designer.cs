namespace Tienda_de_Ropa.Vistas
{
    partial class EliminarProducto
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
            this.lbl_baja_de_productos = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_motivo = new System.Windows.Forms.TextBox();
            this.lbl_motivo = new System.Windows.Forms.Label();
            this.error_id = new System.Windows.Forms.Label();
            this.error_nombre = new System.Windows.Forms.Label();
            this.error_motivo = new System.Windows.Forms.Label();
            this.btn_eliminar_producto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_baja_de_productos
            // 
            this.lbl_baja_de_productos.AutoSize = true;
            this.lbl_baja_de_productos.Location = new System.Drawing.Point(93, 40);
            this.lbl_baja_de_productos.Name = "lbl_baja_de_productos";
            this.lbl_baja_de_productos.Size = new System.Drawing.Size(94, 13);
            this.lbl_baja_de_productos.TabIndex = 0;
            this.lbl_baja_de_productos.Text = "Baja de Productos";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(120, 98);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(149, 20);
            this.txt_id.TabIndex = 1;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(37, 101);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(16, 13);
            this.lbl_id.TabIndex = 2;
            this.lbl_id.Text = "Id";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(122, 163);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(146, 20);
            this.txt_nombre.TabIndex = 3;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(38, 168);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 4;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_motivo
            // 
            this.txt_motivo.Location = new System.Drawing.Point(242, 251);
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.Size = new System.Drawing.Size(141, 20);
            this.txt_motivo.TabIndex = 5;
            // 
            // lbl_motivo
            // 
            this.lbl_motivo.AutoSize = true;
            this.lbl_motivo.Location = new System.Drawing.Point(37, 254);
            this.lbl_motivo.Name = "lbl_motivo";
            this.lbl_motivo.Size = new System.Drawing.Size(174, 13);
            this.lbl_motivo.TabIndex = 6;
            this.lbl_motivo.Text = "Indicar Motivo de Baja de Producto";
            // 
            // error_id
            // 
            this.error_id.AutoSize = true;
            this.error_id.ForeColor = System.Drawing.Color.Red;
            this.error_id.Location = new System.Drawing.Point(302, 99);
            this.error_id.Name = "error_id";
            this.error_id.Size = new System.Drawing.Size(41, 13);
            this.error_id.TabIndex = 7;
            this.error_id.Text = "Error Id";
            // 
            // error_nombre
            // 
            this.error_nombre.AutoSize = true;
            this.error_nombre.ForeColor = System.Drawing.Color.Red;
            this.error_nombre.Location = new System.Drawing.Point(299, 164);
            this.error_nombre.Name = "error_nombre";
            this.error_nombre.Size = new System.Drawing.Size(69, 13);
            this.error_nombre.TabIndex = 8;
            this.error_nombre.Text = "Error Nombre";
            // 
            // error_motivo
            // 
            this.error_motivo.AutoSize = true;
            this.error_motivo.ForeColor = System.Drawing.Color.Red;
            this.error_motivo.Location = new System.Drawing.Point(417, 252);
            this.error_motivo.Name = "error_motivo";
            this.error_motivo.Size = new System.Drawing.Size(103, 13);
            this.error_motivo.TabIndex = 9;
            this.error_motivo.Text = "Error Motivo de Baja";
            // 
            // btn_eliminar_producto
            // 
            this.btn_eliminar_producto.Location = new System.Drawing.Point(242, 340);
            this.btn_eliminar_producto.Name = "btn_eliminar_producto";
            this.btn_eliminar_producto.Size = new System.Drawing.Size(167, 41);
            this.btn_eliminar_producto.TabIndex = 10;
            this.btn_eliminar_producto.Text = "Eliminar Producto";
            this.btn_eliminar_producto.UseVisualStyleBackColor = true;
            this.btn_eliminar_producto.Click += new System.EventHandler(this.btn_eliminar_producto_Click);
            // 
            // EliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_eliminar_producto);
            this.Controls.Add(this.error_motivo);
            this.Controls.Add(this.error_nombre);
            this.Controls.Add(this.error_id);
            this.Controls.Add(this.lbl_motivo);
            this.Controls.Add(this.txt_motivo);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_baja_de_productos);
            this.Name = "EliminarProducto";
            this.Text = "EliminarProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_baja_de_productos;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_motivo;
        private System.Windows.Forms.Label lbl_motivo;
        private System.Windows.Forms.Label error_id;
        private System.Windows.Forms.Label error_nombre;
        private System.Windows.Forms.Label error_motivo;
        private System.Windows.Forms.Button btn_eliminar_producto;
    }
}
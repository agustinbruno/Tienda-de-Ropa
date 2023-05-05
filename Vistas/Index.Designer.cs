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
            this.btn_producto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_producto
            // 
            this.btn_producto.Location = new System.Drawing.Point(230, 48);
            this.btn_producto.Name = "btn_producto";
            this.btn_producto.Size = new System.Drawing.Size(180, 61);
            this.btn_producto.TabIndex = 0;
            this.btn_producto.Text = "Agregar Producto";
            this.btn_producto.UseVisualStyleBackColor = true;
            this.btn_producto.Click += new System.EventHandler(this.btn_producto_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_producto);
            this.Name = "Index";
            this.Text = "Index";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_producto;
    }
}
namespace Login
{
    partial class InicioForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.inventario_gbox = new System.Windows.Forms.GroupBox();
            this.inventario_dv = new System.Windows.Forms.DataGridView();
            this.ID_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Talla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto_txt = new System.Windows.Forms.TextBox();
            this.nombreProducto_lbl = new System.Windows.Forms.Label();
            this.buscar_btn = new System.Windows.Forms.Button();
            this.modificar_btn = new System.Windows.Forms.Button();
            this.añadir_btn = new System.Windows.Forms.Button();
            this.eliminar_btn = new System.Windows.Forms.Button();
            this.tallaS_cb = new System.Windows.Forms.CheckBox();
            this.talla_lbl = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.ventas_gbox = new System.Windows.Forms.GroupBox();
            this.ventas_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.inventario_gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventario_dv)).BeginInit();
            this.ventas_gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventario_gbox
            // 
            this.inventario_gbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventario_gbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(90)))), ((int)(((byte)(96)))));
            this.inventario_gbox.Controls.Add(this.inventario_dv);
            this.inventario_gbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventario_gbox.ForeColor = System.Drawing.SystemColors.Control;
            this.inventario_gbox.Location = new System.Drawing.Point(504, 10);
            this.inventario_gbox.Name = "inventario_gbox";
            this.inventario_gbox.Size = new System.Drawing.Size(748, 656);
            this.inventario_gbox.TabIndex = 0;
            this.inventario_gbox.TabStop = false;
            this.inventario_gbox.Text = "Inventario";
            // 
            // inventario_dv
            // 
            this.inventario_dv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventario_dv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(90)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventario_dv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.inventario_dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventario_dv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_producto,
            this.Nombre_Producto,
            this.Marca,
            this.Categoria,
            this.Stock,
            this.Talla,
            this.Precio_Venta});
            this.inventario_dv.Location = new System.Drawing.Point(6, 28);
            this.inventario_dv.Name = "inventario_dv";
            this.inventario_dv.Size = new System.Drawing.Size(736, 622);
            this.inventario_dv.TabIndex = 0;
            // 
            // ID_producto
            // 
            this.ID_producto.HeaderText = "ID PRODUCTO";
            this.ID_producto.Name = "ID_producto";
            // 
            // Nombre_Producto
            // 
            this.Nombre_Producto.HeaderText = "Nombre Producto";
            this.Nombre_Producto.Name = "Nombre_Producto";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock Disponible";
            this.Stock.Name = "Stock";
            // 
            // Talla
            // 
            this.Talla.HeaderText = "Talla";
            this.Talla.Name = "Talla";
            // 
            // Precio_Venta
            // 
            this.Precio_Venta.HeaderText = "Precio";
            this.Precio_Venta.Name = "Precio_Venta";
            // 
            // nombreProducto_txt
            // 
            this.nombreProducto_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(90)))), ((int)(((byte)(96)))));
            this.nombreProducto_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreProducto_txt.ForeColor = System.Drawing.SystemColors.Control;
            this.nombreProducto_txt.Location = new System.Drawing.Point(16, 60);
            this.nombreProducto_txt.Name = "nombreProducto_txt";
            this.nombreProducto_txt.Size = new System.Drawing.Size(438, 29);
            this.nombreProducto_txt.TabIndex = 1;
            // 
            // nombreProducto_lbl
            // 
            this.nombreProducto_lbl.AutoSize = true;
            this.nombreProducto_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(90)))), ((int)(((byte)(96)))));
            this.nombreProducto_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreProducto_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.nombreProducto_lbl.Location = new System.Drawing.Point(12, 25);
            this.nombreProducto_lbl.Name = "nombreProducto_lbl";
            this.nombreProducto_lbl.Size = new System.Drawing.Size(175, 21);
            this.nombreProducto_lbl.TabIndex = 2;
            this.nombreProducto_lbl.Text = "Nombre del producto";
            // 
            // buscar_btn
            // 
            this.buscar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(90)))), ((int)(((byte)(96)))));
            this.buscar_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.buscar_btn.Location = new System.Drawing.Point(382, 101);
            this.buscar_btn.Name = "buscar_btn";
            this.buscar_btn.Size = new System.Drawing.Size(72, 46);
            this.buscar_btn.TabIndex = 2;
            this.buscar_btn.Text = "Buscar";
            this.buscar_btn.UseVisualStyleBackColor = false;
            // 
            // modificar_btn
            // 
            this.modificar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(90)))), ((int)(((byte)(96)))));
            this.modificar_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.modificar_btn.Location = new System.Drawing.Point(99, 169);
            this.modificar_btn.Name = "modificar_btn";
            this.modificar_btn.Size = new System.Drawing.Size(95, 46);
            this.modificar_btn.TabIndex = 8;
            this.modificar_btn.Text = "Modificar";
            this.modificar_btn.UseVisualStyleBackColor = false;
            this.modificar_btn.Click += new System.EventHandler(this.modificar_btn_Click);
            // 
            // añadir_btn
            // 
            this.añadir_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(90)))), ((int)(((byte)(96)))));
            this.añadir_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.añadir_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.añadir_btn.Location = new System.Drawing.Point(16, 169);
            this.añadir_btn.Name = "añadir_btn";
            this.añadir_btn.Size = new System.Drawing.Size(77, 46);
            this.añadir_btn.TabIndex = 7;
            this.añadir_btn.Text = "Añadir";
            this.añadir_btn.UseVisualStyleBackColor = false;
            this.añadir_btn.Click += new System.EventHandler(this.añadir_btn_Click);
            // 
            // eliminar_btn
            // 
            this.eliminar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(90)))), ((int)(((byte)(96)))));
            this.eliminar_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.eliminar_btn.Location = new System.Drawing.Point(200, 169);
            this.eliminar_btn.Name = "eliminar_btn";
            this.eliminar_btn.Size = new System.Drawing.Size(84, 46);
            this.eliminar_btn.TabIndex = 9;
            this.eliminar_btn.Text = "Eliminar";
            this.eliminar_btn.UseVisualStyleBackColor = false;
            // 
            // tallaS_cb
            // 
            this.tallaS_cb.AutoSize = true;
            this.tallaS_cb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tallaS_cb.ForeColor = System.Drawing.SystemColors.Control;
            this.tallaS_cb.Location = new System.Drawing.Point(16, 134);
            this.tallaS_cb.Name = "tallaS_cb";
            this.tallaS_cb.Size = new System.Drawing.Size(38, 25);
            this.tallaS_cb.TabIndex = 10;
            this.tallaS_cb.Text = "S";
            this.tallaS_cb.UseVisualStyleBackColor = true;
            // 
            // talla_lbl
            // 
            this.talla_lbl.AutoSize = true;
            this.talla_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(90)))), ((int)(((byte)(96)))));
            this.talla_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.talla_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.talla_lbl.Location = new System.Drawing.Point(12, 101);
            this.talla_lbl.Name = "talla_lbl";
            this.talla_lbl.Size = new System.Drawing.Size(50, 21);
            this.talla_lbl.TabIndex = 11;
            this.talla_lbl.Text = "Talla:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(60, 134);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(44, 25);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "M";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox2.Location = new System.Drawing.Point(110, 134);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(37, 25);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "L";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox3.Location = new System.Drawing.Point(153, 134);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(47, 25);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "XL";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // ventas_gbox
            // 
            this.ventas_gbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(90)))), ((int)(((byte)(96)))));
            this.ventas_gbox.Controls.Add(this.button1);
            this.ventas_gbox.Controls.Add(this.ventas_btn);
            this.ventas_gbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventas_gbox.ForeColor = System.Drawing.SystemColors.Control;
            this.ventas_gbox.Location = new System.Drawing.Point(16, 232);
            this.ventas_gbox.Name = "ventas_gbox";
            this.ventas_gbox.Size = new System.Drawing.Size(442, 155);
            this.ventas_gbox.TabIndex = 15;
            this.ventas_gbox.TabStop = false;
            this.ventas_gbox.Text = "Gestión de Ventas:";
            // 
            // ventas_btn
            // 
            this.ventas_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ventas_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(90)))), ((int)(((byte)(96)))));
            this.ventas_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventas_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.ventas_btn.Location = new System.Drawing.Point(6, 37);
            this.ventas_btn.Name = "ventas_btn";
            this.ventas_btn.Size = new System.Drawing.Size(218, 46);
            this.ventas_btn.TabIndex = 16;
            this.ventas_btn.Text = "Registrar Venta";
            this.ventas_btn.UseVisualStyleBackColor = false;
            this.ventas_btn.Click += new System.EventHandler(this.ventas_btn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(90)))), ((int)(((byte)(96)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(6, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 46);
            this.button1.TabIndex = 17;
            this.button1.Text = "Generar Reportes";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(90)))), ((int)(((byte)(96)))));
            this.back_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.back_btn.Location = new System.Drawing.Point(12, 623);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(228, 46);
            this.back_btn.TabIndex = 16;
            this.back_btn.Text = "Cerrar Sesión";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // InicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(90)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.ventas_gbox);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.talla_lbl);
            this.Controls.Add(this.tallaS_cb);
            this.Controls.Add(this.modificar_btn);
            this.Controls.Add(this.añadir_btn);
            this.Controls.Add(this.eliminar_btn);
            this.Controls.Add(this.buscar_btn);
            this.Controls.Add(this.nombreProducto_lbl);
            this.Controls.Add(this.nombreProducto_txt);
            this.Controls.Add(this.inventario_gbox);
            this.Name = "InicioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioForm";
            this.inventario_gbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventario_dv)).EndInit();
            this.ventas_gbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox inventario_gbox;
        private System.Windows.Forms.TextBox nombreProducto_txt;
        private System.Windows.Forms.Label nombreProducto_lbl;
        private System.Windows.Forms.Button buscar_btn;
        private System.Windows.Forms.Button modificar_btn;
        private System.Windows.Forms.Button añadir_btn;
        private System.Windows.Forms.Button eliminar_btn;
        private System.Windows.Forms.DataGridView inventario_dv;
        private System.Windows.Forms.CheckBox tallaS_cb;
        private System.Windows.Forms.Label talla_lbl;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Talla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Venta;
        private System.Windows.Forms.GroupBox ventas_gbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ventas_btn;
        private System.Windows.Forms.Button back_btn;
    }
}
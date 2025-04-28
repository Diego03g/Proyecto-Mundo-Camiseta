using System;

namespace Login.Forms
{
    partial class AñadirProductosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AñadirProductosForm));
            this.registroProductos_gbox = new System.Windows.Forms.GroupBox();
            this.categoria_cbox = new System.Windows.Forms.ComboBox();
            this.pictureBoxAñadirImg = new System.Windows.Forms.PictureBox();
            this.imagen_lbl = new System.Windows.Forms.Label();
            this.total_txt = new System.Windows.Forms.TextBox();
            this.tallaXL_lbl = new System.Windows.Forms.Label();
            this.tallaXL_nud = new System.Windows.Forms.NumericUpDown();
            this.tallaL_lbl = new System.Windows.Forms.Label();
            this.tallaL_nud = new System.Windows.Forms.NumericUpDown();
            this.tallaM_lbl = new System.Windows.Forms.Label();
            this.tallaM_nud = new System.Windows.Forms.NumericUpDown();
            this.tallaS_lbl = new System.Windows.Forms.Label();
            this.volver_btn = new System.Windows.Forms.Button();
            this.añadir_btn = new System.Windows.Forms.Button();
            this.tbx_precio = new System.Windows.Forms.TextBox();
            this.precio_lbl = new System.Windows.Forms.Label();
            this.marca_lbl = new System.Windows.Forms.Label();
            this.tbx_Marca = new System.Windows.Forms.TextBox();
            this.tallaS_nud = new System.Windows.Forms.NumericUpDown();
            this.stock_lbl = new System.Windows.Forms.Label();
            this.categoria_lbl = new System.Windows.Forms.Label();
            this.nombre_producto_lbl = new System.Windows.Forms.Label();
            this.nombre_producto_txt = new System.Windows.Forms.TextBox();
            this.registroProductos_gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAñadirImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tallaXL_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tallaL_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tallaM_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tallaS_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // registroProductos_gbox
            // 
            this.registroProductos_gbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registroProductos_gbox.BackColor = System.Drawing.Color.Transparent;
            this.registroProductos_gbox.Controls.Add(this.categoria_cbox);
            this.registroProductos_gbox.Controls.Add(this.pictureBoxAñadirImg);
            this.registroProductos_gbox.Controls.Add(this.imagen_lbl);
            this.registroProductos_gbox.Controls.Add(this.total_txt);
            this.registroProductos_gbox.Controls.Add(this.tallaXL_lbl);
            this.registroProductos_gbox.Controls.Add(this.tallaXL_nud);
            this.registroProductos_gbox.Controls.Add(this.tallaL_lbl);
            this.registroProductos_gbox.Controls.Add(this.tallaL_nud);
            this.registroProductos_gbox.Controls.Add(this.tallaM_lbl);
            this.registroProductos_gbox.Controls.Add(this.tallaM_nud);
            this.registroProductos_gbox.Controls.Add(this.tallaS_lbl);
            this.registroProductos_gbox.Controls.Add(this.volver_btn);
            this.registroProductos_gbox.Controls.Add(this.añadir_btn);
            this.registroProductos_gbox.Controls.Add(this.tbx_precio);
            this.registroProductos_gbox.Controls.Add(this.precio_lbl);
            this.registroProductos_gbox.Controls.Add(this.marca_lbl);
            this.registroProductos_gbox.Controls.Add(this.tbx_Marca);
            this.registroProductos_gbox.Controls.Add(this.tallaS_nud);
            this.registroProductos_gbox.Controls.Add(this.stock_lbl);
            this.registroProductos_gbox.Controls.Add(this.categoria_lbl);
            this.registroProductos_gbox.Controls.Add(this.nombre_producto_lbl);
            this.registroProductos_gbox.Controls.Add(this.nombre_producto_txt);
            this.registroProductos_gbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroProductos_gbox.ForeColor = System.Drawing.SystemColors.Control;
            this.registroProductos_gbox.Location = new System.Drawing.Point(6, 5);
            this.registroProductos_gbox.Name = "registroProductos_gbox";
            this.registroProductos_gbox.Size = new System.Drawing.Size(749, 606);
            this.registroProductos_gbox.TabIndex = 8;
            this.registroProductos_gbox.TabStop = false;
            this.registroProductos_gbox.Text = "Registro de Productos";
            this.registroProductos_gbox.Enter += new System.EventHandler(this.registroProductos_gbox_Enter);
            // 
            // categoria_cbox
            // 
            this.categoria_cbox.FormattingEnabled = true;
            this.categoria_cbox.Items.AddRange(new object[] {
            "Camisa",
            "Jersey",
            "Polo",
            "Sin Mangas",
            "Interior"});
            this.categoria_cbox.Location = new System.Drawing.Point(15, 131);
            this.categoria_cbox.Name = "categoria_cbox";
            this.categoria_cbox.Size = new System.Drawing.Size(501, 29);
            this.categoria_cbox.TabIndex = 35;
            // 
            // pictureBoxAñadirImg
            // 
            this.pictureBoxAñadirImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAñadirImg.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAñadirImg.Image")));
            this.pictureBoxAñadirImg.InitialImage = null;
            this.pictureBoxAñadirImg.Location = new System.Drawing.Point(565, 64);
            this.pictureBoxAñadirImg.Name = "pictureBoxAñadirImg";
            this.pictureBoxAñadirImg.Size = new System.Drawing.Size(153, 187);
            this.pictureBoxAñadirImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAñadirImg.TabIndex = 34;
            this.pictureBoxAñadirImg.TabStop = false;
            this.pictureBoxAñadirImg.Click += new System.EventHandler(this.pictureBoxAñadirImg_Click);
            // 
            // imagen_lbl
            // 
            this.imagen_lbl.AutoSize = true;
            this.imagen_lbl.BackColor = System.Drawing.Color.Transparent;
            this.imagen_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagen_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.imagen_lbl.Location = new System.Drawing.Point(561, 40);
            this.imagen_lbl.Name = "imagen_lbl";
            this.imagen_lbl.Size = new System.Drawing.Size(127, 21);
            this.imagen_lbl.TabIndex = 32;
            this.imagen_lbl.Text = "Añadir Imagen:";
            this.imagen_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // total_txt
            // 
            this.total_txt.BackColor = System.Drawing.Color.White;
            this.total_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.total_txt.Location = new System.Drawing.Point(15, 480);
            this.total_txt.Name = "total_txt";
            this.total_txt.ReadOnly = true;
            this.total_txt.Size = new System.Drawing.Size(498, 29);
            this.total_txt.TabIndex = 31;
            // 
            // tallaXL_lbl
            // 
            this.tallaXL_lbl.AutoSize = true;
            this.tallaXL_lbl.BackColor = System.Drawing.Color.Transparent;
            this.tallaXL_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tallaXL_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.tallaXL_lbl.Location = new System.Drawing.Point(392, 386);
            this.tallaXL_lbl.Name = "tallaXL_lbl";
            this.tallaXL_lbl.Size = new System.Drawing.Size(32, 21);
            this.tallaXL_lbl.TabIndex = 30;
            this.tallaXL_lbl.Text = "XL:";
            // 
            // tallaXL_nud
            // 
            this.tallaXL_nud.Location = new System.Drawing.Point(396, 410);
            this.tallaXL_nud.Name = "tallaXL_nud";
            this.tallaXL_nud.Size = new System.Drawing.Size(120, 29);
            this.tallaXL_nud.TabIndex = 8;
            // 
            // tallaL_lbl
            // 
            this.tallaL_lbl.AutoSize = true;
            this.tallaL_lbl.BackColor = System.Drawing.Color.Transparent;
            this.tallaL_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tallaL_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.tallaL_lbl.Location = new System.Drawing.Point(266, 386);
            this.tallaL_lbl.Name = "tallaL_lbl";
            this.tallaL_lbl.Size = new System.Drawing.Size(22, 21);
            this.tallaL_lbl.TabIndex = 28;
            this.tallaL_lbl.Text = "L:";
            // 
            // tallaL_nud
            // 
            this.tallaL_nud.Location = new System.Drawing.Point(270, 410);
            this.tallaL_nud.Name = "tallaL_nud";
            this.tallaL_nud.Size = new System.Drawing.Size(120, 29);
            this.tallaL_nud.TabIndex = 7;
            // 
            // tallaM_lbl
            // 
            this.tallaM_lbl.AutoSize = true;
            this.tallaM_lbl.BackColor = System.Drawing.Color.Transparent;
            this.tallaM_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tallaM_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.tallaM_lbl.Location = new System.Drawing.Point(140, 386);
            this.tallaM_lbl.Name = "tallaM_lbl";
            this.tallaM_lbl.Size = new System.Drawing.Size(29, 21);
            this.tallaM_lbl.TabIndex = 26;
            this.tallaM_lbl.Text = "M:";
            // 
            // tallaM_nud
            // 
            this.tallaM_nud.Location = new System.Drawing.Point(144, 410);
            this.tallaM_nud.Name = "tallaM_nud";
            this.tallaM_nud.Size = new System.Drawing.Size(120, 29);
            this.tallaM_nud.TabIndex = 6;
            // 
            // tallaS_lbl
            // 
            this.tallaS_lbl.AutoSize = true;
            this.tallaS_lbl.BackColor = System.Drawing.Color.Transparent;
            this.tallaS_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tallaS_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.tallaS_lbl.Location = new System.Drawing.Point(14, 386);
            this.tallaS_lbl.Name = "tallaS_lbl";
            this.tallaS_lbl.Size = new System.Drawing.Size(23, 21);
            this.tallaS_lbl.TabIndex = 24;
            this.tallaS_lbl.Text = "S:";
            // 
            // volver_btn
            // 
            this.volver_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.volver_btn.BackColor = System.Drawing.Color.Transparent;
            this.volver_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volver_btn.FlatAppearance.BorderSize = 0;
            this.volver_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.volver_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.volver_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.volver_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volver_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volver_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.volver_btn.Image = ((System.Drawing.Image)(resources.GetObject("volver_btn.Image")));
            this.volver_btn.Location = new System.Drawing.Point(22, 542);
            this.volver_btn.Name = "volver_btn";
            this.volver_btn.Size = new System.Drawing.Size(77, 46);
            this.volver_btn.TabIndex = 9;
            this.volver_btn.UseVisualStyleBackColor = false;
            this.volver_btn.Click += new System.EventHandler(this.volver_btn_Click);
            // 
            // añadir_btn
            // 
            this.añadir_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.añadir_btn.BackColor = System.Drawing.Color.Transparent;
            this.añadir_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.añadir_btn.FlatAppearance.BorderSize = 0;
            this.añadir_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.añadir_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.añadir_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.añadir_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.añadir_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.añadir_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.añadir_btn.Image = ((System.Drawing.Image)(resources.GetObject("añadir_btn.Image")));
            this.añadir_btn.Location = new System.Drawing.Point(650, 542);
            this.añadir_btn.Name = "añadir_btn";
            this.añadir_btn.Size = new System.Drawing.Size(77, 46);
            this.añadir_btn.TabIndex = 10;
            this.añadir_btn.UseVisualStyleBackColor = false;
            this.añadir_btn.Click += new System.EventHandler(this.añadir_btn_Click);
            // 
            // tbx_precio
            // 
            this.tbx_precio.BackColor = System.Drawing.Color.White;
            this.tbx_precio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_precio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbx_precio.Location = new System.Drawing.Point(18, 288);
            this.tbx_precio.Name = "tbx_precio";
            this.tbx_precio.Size = new System.Drawing.Size(498, 29);
            this.tbx_precio.TabIndex = 4;
            this.tbx_precio.TextChanged += new System.EventHandler(this.tbx_precio_TextChanged);
            // 
            // precio_lbl
            // 
            this.precio_lbl.AutoSize = true;
            this.precio_lbl.BackColor = System.Drawing.Color.Transparent;
            this.precio_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.precio_lbl.Location = new System.Drawing.Point(14, 257);
            this.precio_lbl.Name = "precio_lbl";
            this.precio_lbl.Size = new System.Drawing.Size(132, 21);
            this.precio_lbl.TabIndex = 20;
            this.precio_lbl.Text = "Precio de venta:";
            // 
            // marca_lbl
            // 
            this.marca_lbl.AutoSize = true;
            this.marca_lbl.BackColor = System.Drawing.Color.Transparent;
            this.marca_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marca_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.marca_lbl.Location = new System.Drawing.Point(14, 179);
            this.marca_lbl.Name = "marca_lbl";
            this.marca_lbl.Size = new System.Drawing.Size(163, 21);
            this.marca_lbl.TabIndex = 19;
            this.marca_lbl.Text = "Marca del producto:";
            // 
            // tbx_Marca
            // 
            this.tbx_Marca.BackColor = System.Drawing.Color.White;
            this.tbx_Marca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Marca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbx_Marca.Location = new System.Drawing.Point(18, 214);
            this.tbx_Marca.Name = "tbx_Marca";
            this.tbx_Marca.Size = new System.Drawing.Size(498, 29);
            this.tbx_Marca.TabIndex = 3;
            this.tbx_Marca.TextChanged += new System.EventHandler(this.tbx_Marca_TextChanged);
            // 
            // tallaS_nud
            // 
            this.tallaS_nud.Location = new System.Drawing.Point(18, 410);
            this.tallaS_nud.Name = "tallaS_nud";
            this.tallaS_nud.Size = new System.Drawing.Size(120, 29);
            this.tallaS_nud.TabIndex = 5;
            // 
            // stock_lbl
            // 
            this.stock_lbl.AutoSize = true;
            this.stock_lbl.BackColor = System.Drawing.Color.Transparent;
            this.stock_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.stock_lbl.Location = new System.Drawing.Point(14, 347);
            this.stock_lbl.Name = "stock_lbl";
            this.stock_lbl.Size = new System.Drawing.Size(124, 21);
            this.stock_lbl.TabIndex = 16;
            this.stock_lbl.Text = "Stock de tallas:";
            // 
            // categoria_lbl
            // 
            this.categoria_lbl.AutoSize = true;
            this.categoria_lbl.BackColor = System.Drawing.Color.Transparent;
            this.categoria_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.categoria_lbl.Location = new System.Drawing.Point(11, 106);
            this.categoria_lbl.Name = "categoria_lbl";
            this.categoria_lbl.Size = new System.Drawing.Size(88, 21);
            this.categoria_lbl.TabIndex = 14;
            this.categoria_lbl.Text = "Categoría:";
            // 
            // nombre_producto_lbl
            // 
            this.nombre_producto_lbl.AutoSize = true;
            this.nombre_producto_lbl.BackColor = System.Drawing.Color.Transparent;
            this.nombre_producto_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_producto_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.nombre_producto_lbl.Location = new System.Drawing.Point(11, 29);
            this.nombre_producto_lbl.Name = "nombre_producto_lbl";
            this.nombre_producto_lbl.Size = new System.Drawing.Size(151, 21);
            this.nombre_producto_lbl.TabIndex = 12;
            this.nombre_producto_lbl.Text = "Nombre producto:";
            // 
            // nombre_producto_txt
            // 
            this.nombre_producto_txt.BackColor = System.Drawing.Color.White;
            this.nombre_producto_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_producto_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nombre_producto_txt.Location = new System.Drawing.Point(18, 64);
            this.nombre_producto_txt.Name = "nombre_producto_txt";
            this.nombre_producto_txt.Size = new System.Drawing.Size(498, 29);
            this.nombre_producto_txt.TabIndex = 1;
            this.nombre_producto_txt.TextChanged += new System.EventHandler(this.nombre_producto_txt_TextChanged);
            // 
            // AñadirProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(761, 622);
            this.Controls.Add(this.registroProductos_gbox);
            this.Name = "AñadirProductosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductosForm";
            this.registroProductos_gbox.ResumeLayout(false);
            this.registroProductos_gbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAñadirImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tallaXL_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tallaL_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tallaM_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tallaS_nud)).EndInit();
            this.ResumeLayout(false);

        }

        private void nombre_producto_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void categoria_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void tbx_Marca_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbx_precio_TextChanged(object sender, EventArgs e)
        {
        }

        private void registroProductos_gbox_Enter(object sender, EventArgs e)
        {
       
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.GroupBox registroProductos_gbox;
        private System.Windows.Forms.Label marca_lbl;
        private System.Windows.Forms.TextBox tbx_Marca;
        private System.Windows.Forms.NumericUpDown tallaS_nud;
        private System.Windows.Forms.Label stock_lbl;
        private System.Windows.Forms.Label categoria_lbl;
        private System.Windows.Forms.Label nombre_producto_lbl;
        private System.Windows.Forms.TextBox nombre_producto_txt;
        private System.Windows.Forms.TextBox tbx_precio;
        private System.Windows.Forms.Label precio_lbl;
        private System.Windows.Forms.Button añadir_btn;
        private System.Windows.Forms.Label tallaXL_lbl;
        private System.Windows.Forms.NumericUpDown tallaXL_nud;
        private System.Windows.Forms.Label tallaL_lbl;
        private System.Windows.Forms.NumericUpDown tallaL_nud;
        private System.Windows.Forms.Label tallaM_lbl;
        private System.Windows.Forms.NumericUpDown tallaM_nud;
        private System.Windows.Forms.Label tallaS_lbl;
        private System.Windows.Forms.Button volver_btn;
        private System.Windows.Forms.TextBox total_txt;
        private System.Windows.Forms.Label imagen_lbl;
        private System.Windows.Forms.PictureBox pictureBoxAñadirImg;
        private System.Windows.Forms.ComboBox categoria_cbox;
    }
}
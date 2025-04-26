namespace Login.Forms
{
    partial class VentasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasForm));
            this.volver_btn = new System.Windows.Forms.Button();
            this.vender_btn = new System.Windows.Forms.Button();
            this.cliente_lbl = new System.Windows.Forms.Label();
            this.cliente_txt = new System.Windows.Forms.TextBox();
            this.nombre_producto_lbl = new System.Windows.Forms.Label();
            this.nombre_producto_txt = new System.Windows.Forms.TextBox();
            this.cantidad_lbl = new System.Windows.Forms.Label();
            this.cantidad_txt = new System.Windows.Forms.TextBox();
            this.id_lbl = new System.Windows.Forms.Label();
            this.idProducto_lbl = new System.Windows.Forms.TextBox();
            this.total_lbl = new System.Windows.Forms.Label();
            this.total_txt = new System.Windows.Forms.TextBox();
            this.fecha_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buscar_btn = new System.Windows.Forms.Button();
            this.tallaXL_lbl = new System.Windows.Forms.Label();
            this.tallaXL_nud = new System.Windows.Forms.NumericUpDown();
            this.tallaL_lbl = new System.Windows.Forms.Label();
            this.tallaL_nud = new System.Windows.Forms.NumericUpDown();
            this.tallaM_lbl = new System.Windows.Forms.Label();
            this.tallaM_nud = new System.Windows.Forms.NumericUpDown();
            this.tallaS_lbl = new System.Windows.Forms.Label();
            this.tallaS_nud = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tallaXL_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tallaL_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tallaM_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tallaS_nud)).BeginInit();
            this.SuspendLayout();
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
            this.volver_btn.ForeColor = System.Drawing.Color.Transparent;
            this.volver_btn.Image = ((System.Drawing.Image)(resources.GetObject("volver_btn.Image")));
            this.volver_btn.Location = new System.Drawing.Point(19, 546);
            this.volver_btn.Name = "volver_btn";
            this.volver_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.volver_btn.Size = new System.Drawing.Size(158, 64);
            this.volver_btn.TabIndex = 11;
            this.volver_btn.UseVisualStyleBackColor = false;
            this.volver_btn.Click += new System.EventHandler(this.volver_btn_Click);
            // 
            // vender_btn
            // 
            this.vender_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.vender_btn.BackColor = System.Drawing.Color.Transparent;
            this.vender_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vender_btn.FlatAppearance.BorderSize = 0;
            this.vender_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.vender_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.vender_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.vender_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vender_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vender_btn.ForeColor = System.Drawing.Color.Transparent;
            this.vender_btn.Image = ((System.Drawing.Image)(resources.GetObject("vender_btn.Image")));
            this.vender_btn.Location = new System.Drawing.Point(427, 546);
            this.vender_btn.Name = "vender_btn";
            this.vender_btn.Size = new System.Drawing.Size(158, 64);
            this.vender_btn.TabIndex = 12;
            this.vender_btn.UseVisualStyleBackColor = false;
            this.vender_btn.Click += new System.EventHandler(this.vender_btn_Click);
            // 
            // cliente_lbl
            // 
            this.cliente_lbl.AutoSize = true;
            this.cliente_lbl.BackColor = System.Drawing.Color.Transparent;
            this.cliente_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.cliente_lbl.Location = new System.Drawing.Point(15, 387);
            this.cliente_lbl.Name = "cliente_lbl";
            this.cliente_lbl.Size = new System.Drawing.Size(72, 21);
            this.cliente_lbl.TabIndex = 44;
            this.cliente_lbl.Text = "Cliente: ";
            // 
            // cliente_txt
            // 
            this.cliente_txt.BackColor = System.Drawing.Color.White;
            this.cliente_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cliente_txt.Location = new System.Drawing.Point(19, 422);
            this.cliente_txt.Name = "cliente_txt";
            this.cliente_txt.Size = new System.Drawing.Size(569, 29);
            this.cliente_txt.TabIndex = 9;
            // 
            // nombre_producto_lbl
            // 
            this.nombre_producto_lbl.AutoSize = true;
            this.nombre_producto_lbl.BackColor = System.Drawing.Color.Transparent;
            this.nombre_producto_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_producto_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.nombre_producto_lbl.Location = new System.Drawing.Point(12, 179);
            this.nombre_producto_lbl.Name = "nombre_producto_lbl";
            this.nombre_producto_lbl.Size = new System.Drawing.Size(151, 21);
            this.nombre_producto_lbl.TabIndex = 41;
            this.nombre_producto_lbl.Text = "Nombre producto:";
            // 
            // nombre_producto_txt
            // 
            this.nombre_producto_txt.BackColor = System.Drawing.Color.White;
            this.nombre_producto_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_producto_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nombre_producto_txt.Location = new System.Drawing.Point(19, 214);
            this.nombre_producto_txt.Name = "nombre_producto_txt";
            this.nombre_producto_txt.Size = new System.Drawing.Size(569, 29);
            this.nombre_producto_txt.TabIndex = 3;
            // 
            // cantidad_lbl
            // 
            this.cantidad_lbl.AutoSize = true;
            this.cantidad_lbl.BackColor = System.Drawing.Color.Transparent;
            this.cantidad_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.cantidad_lbl.Location = new System.Drawing.Point(15, 262);
            this.cantidad_lbl.Name = "cantidad_lbl";
            this.cantidad_lbl.Size = new System.Drawing.Size(83, 21);
            this.cantidad_lbl.TabIndex = 46;
            this.cantidad_lbl.Text = "Cantidad:";
            // 
            // cantidad_txt
            // 
            this.cantidad_txt.BackColor = System.Drawing.Color.White;
            this.cantidad_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cantidad_txt.Location = new System.Drawing.Point(19, 297);
            this.cantidad_txt.Name = "cantidad_txt";
            this.cantidad_txt.Size = new System.Drawing.Size(569, 29);
            this.cantidad_txt.TabIndex = 4;
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.BackColor = System.Drawing.Color.Transparent;
            this.id_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.id_lbl.Location = new System.Drawing.Point(12, 20);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(199, 21);
            this.id_lbl.TabIndex = 48;
            this.id_lbl.Text = "ID o código de producto:";
            // 
            // idProducto_lbl
            // 
            this.idProducto_lbl.BackColor = System.Drawing.Color.White;
            this.idProducto_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProducto_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.idProducto_lbl.Location = new System.Drawing.Point(16, 55);
            this.idProducto_lbl.Name = "idProducto_lbl";
            this.idProducto_lbl.Size = new System.Drawing.Size(443, 29);
            this.idProducto_lbl.TabIndex = 1;
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.BackColor = System.Drawing.Color.Transparent;
            this.total_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.total_lbl.Location = new System.Drawing.Point(15, 467);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(104, 21);
            this.total_lbl.TabIndex = 50;
            this.total_lbl.Text = "Precio Total:";
            // 
            // total_txt
            // 
            this.total_txt.BackColor = System.Drawing.Color.White;
            this.total_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.total_txt.Location = new System.Drawing.Point(19, 499);
            this.total_txt.Name = "total_txt";
            this.total_txt.ReadOnly = true;
            this.total_txt.Size = new System.Drawing.Size(569, 29);
            this.total_txt.TabIndex = 10;
            // 
            // fecha_txt
            // 
            this.fecha_txt.BackColor = System.Drawing.Color.White;
            this.fecha_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fecha_txt.Location = new System.Drawing.Point(301, 17);
            this.fecha_txt.Name = "fecha_txt";
            this.fecha_txt.ReadOnly = true;
            this.fecha_txt.Size = new System.Drawing.Size(158, 29);
            this.fecha_txt.TabIndex = 51;
            this.fecha_txt.TextChanged += new System.EventHandler(this.fecha_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(15, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 56;
            this.label1.Text = "Tallas:";
            // 
            // buscar_btn
            // 
            this.buscar_btn.AllowDrop = true;
            this.buscar_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buscar_btn.BackColor = System.Drawing.Color.Transparent;
            this.buscar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscar_btn.FlatAppearance.BorderSize = 0;
            this.buscar_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buscar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buscar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buscar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.buscar_btn.Image = ((System.Drawing.Image)(resources.GetObject("buscar_btn.Image")));
            this.buscar_btn.Location = new System.Drawing.Point(465, 32);
            this.buscar_btn.Name = "buscar_btn";
            this.buscar_btn.Size = new System.Drawing.Size(72, 52);
            this.buscar_btn.TabIndex = 2;
            this.buscar_btn.UseVisualStyleBackColor = false;
            this.buscar_btn.Click += new System.EventHandler(this.buscar_btn_Click);
            // 
            // tallaXL_lbl
            // 
            this.tallaXL_lbl.AutoSize = true;
            this.tallaXL_lbl.BackColor = System.Drawing.Color.Transparent;
            this.tallaXL_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tallaXL_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.tallaXL_lbl.Location = new System.Drawing.Point(461, 339);
            this.tallaXL_lbl.Name = "tallaXL_lbl";
            this.tallaXL_lbl.Size = new System.Drawing.Size(32, 21);
            this.tallaXL_lbl.TabIndex = 64;
            this.tallaXL_lbl.Text = "XL:";
            // 
            // tallaXL_nud
            // 
            this.tallaXL_nud.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tallaXL_nud.Location = new System.Drawing.Point(465, 363);
            this.tallaXL_nud.Name = "tallaXL_nud";
            this.tallaXL_nud.Size = new System.Drawing.Size(120, 29);
            this.tallaXL_nud.TabIndex = 60;
            // 
            // tallaL_lbl
            // 
            this.tallaL_lbl.AutoSize = true;
            this.tallaL_lbl.BackColor = System.Drawing.Color.Transparent;
            this.tallaL_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tallaL_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.tallaL_lbl.Location = new System.Drawing.Point(335, 339);
            this.tallaL_lbl.Name = "tallaL_lbl";
            this.tallaL_lbl.Size = new System.Drawing.Size(22, 21);
            this.tallaL_lbl.TabIndex = 63;
            this.tallaL_lbl.Text = "L:";
            // 
            // tallaL_nud
            // 
            this.tallaL_nud.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tallaL_nud.Location = new System.Drawing.Point(339, 363);
            this.tallaL_nud.Name = "tallaL_nud";
            this.tallaL_nud.Size = new System.Drawing.Size(120, 29);
            this.tallaL_nud.TabIndex = 59;
            // 
            // tallaM_lbl
            // 
            this.tallaM_lbl.AutoSize = true;
            this.tallaM_lbl.BackColor = System.Drawing.Color.Transparent;
            this.tallaM_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tallaM_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.tallaM_lbl.Location = new System.Drawing.Point(209, 339);
            this.tallaM_lbl.Name = "tallaM_lbl";
            this.tallaM_lbl.Size = new System.Drawing.Size(29, 21);
            this.tallaM_lbl.TabIndex = 62;
            this.tallaM_lbl.Text = "M:";
            // 
            // tallaM_nud
            // 
            this.tallaM_nud.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tallaM_nud.Location = new System.Drawing.Point(213, 363);
            this.tallaM_nud.Name = "tallaM_nud";
            this.tallaM_nud.Size = new System.Drawing.Size(120, 29);
            this.tallaM_nud.TabIndex = 58;
            // 
            // tallaS_lbl
            // 
            this.tallaS_lbl.AutoSize = true;
            this.tallaS_lbl.BackColor = System.Drawing.Color.Transparent;
            this.tallaS_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tallaS_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.tallaS_lbl.Location = new System.Drawing.Point(83, 339);
            this.tallaS_lbl.Name = "tallaS_lbl";
            this.tallaS_lbl.Size = new System.Drawing.Size(23, 21);
            this.tallaS_lbl.TabIndex = 61;
            this.tallaS_lbl.Text = "S:";
            // 
            // tallaS_nud
            // 
            this.tallaS_nud.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tallaS_nud.Location = new System.Drawing.Point(87, 363);
            this.tallaS_nud.Name = "tallaS_nud";
            this.tallaS_nud.Size = new System.Drawing.Size(120, 29);
            this.tallaS_nud.TabIndex = 57;
            // 
            // VentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(610, 622);
            this.Controls.Add(this.tallaXL_lbl);
            this.Controls.Add(this.tallaXL_nud);
            this.Controls.Add(this.tallaL_lbl);
            this.Controls.Add(this.tallaL_nud);
            this.Controls.Add(this.tallaM_lbl);
            this.Controls.Add(this.tallaM_nud);
            this.Controls.Add(this.tallaS_lbl);
            this.Controls.Add(this.tallaS_nud);
            this.Controls.Add(this.buscar_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fecha_txt);
            this.Controls.Add(this.total_lbl);
            this.Controls.Add(this.total_txt);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.idProducto_lbl);
            this.Controls.Add(this.cantidad_lbl);
            this.Controls.Add(this.cantidad_txt);
            this.Controls.Add(this.volver_btn);
            this.Controls.Add(this.vender_btn);
            this.Controls.Add(this.cliente_lbl);
            this.Controls.Add(this.cliente_txt);
            this.Controls.Add(this.nombre_producto_lbl);
            this.Controls.Add(this.nombre_producto_txt);
            this.Name = "VentasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.VentasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tallaXL_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tallaL_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tallaM_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tallaS_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button volver_btn;
        private System.Windows.Forms.Button vender_btn;
        private System.Windows.Forms.Label cliente_lbl;
        private System.Windows.Forms.TextBox cliente_txt;
        private System.Windows.Forms.Label nombre_producto_lbl;
        private System.Windows.Forms.TextBox nombre_producto_txt;
        private System.Windows.Forms.Label cantidad_lbl;
        private System.Windows.Forms.TextBox cantidad_txt;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.TextBox idProducto_lbl;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.TextBox total_txt;
        private System.Windows.Forms.TextBox fecha_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buscar_btn;
        private System.Windows.Forms.Label tallaXL_lbl;
        private System.Windows.Forms.NumericUpDown tallaXL_nud;
        private System.Windows.Forms.Label tallaL_lbl;
        private System.Windows.Forms.NumericUpDown tallaL_nud;
        private System.Windows.Forms.Label tallaM_lbl;
        private System.Windows.Forms.NumericUpDown tallaM_nud;
        private System.Windows.Forms.Label tallaS_lbl;
        private System.Windows.Forms.NumericUpDown tallaS_nud;
    }
}
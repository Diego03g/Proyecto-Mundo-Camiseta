﻿namespace Login
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioForm));
            this.inventario_gbox = new System.Windows.Forms.GroupBox();
            this.inventario_dv = new System.Windows.Forms.DataGridView();
            this.modificar_btn = new System.Windows.Forms.Button();
            this.añadir_btn = new System.Windows.Forms.Button();
            this.eliminar_btn = new System.Windows.Forms.Button();
            this.ventas_gbox = new System.Windows.Forms.GroupBox();
            this.reportes_btn = new System.Windows.Forms.Button();
            this.ventas_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.welcome_lbl = new System.Windows.Forms.Label();
            this.nombreuser_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inventario_gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventario_dv)).BeginInit();
            this.ventas_gbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventario_gbox
            // 
            this.inventario_gbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventario_gbox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.inventario_gbox.Controls.Add(this.inventario_dv);
            this.inventario_gbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventario_gbox.ForeColor = System.Drawing.SystemColors.Control;
            this.inventario_gbox.Location = new System.Drawing.Point(385, 10);
            this.inventario_gbox.Name = "inventario_gbox";
            this.inventario_gbox.Size = new System.Drawing.Size(1068, 656);
            this.inventario_gbox.TabIndex = 0;
            this.inventario_gbox.TabStop = false;
            this.inventario_gbox.Text = "Inventario";
            this.inventario_gbox.Enter += new System.EventHandler(this.inventario_gbox_Enter);
            // 
            // inventario_dv
            // 
            this.inventario_dv.AllowUserToAddRows = false;
            this.inventario_dv.AllowUserToDeleteRows = false;
            this.inventario_dv.AllowUserToResizeColumns = false;
            this.inventario_dv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.inventario_dv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.inventario_dv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventario_dv.BackgroundColor = System.Drawing.Color.Black;
            this.inventario_dv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventario_dv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.inventario_dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventario_dv.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inventario_dv.Location = new System.Drawing.Point(6, 28);
            this.inventario_dv.Name = "inventario_dv";
            this.inventario_dv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventario_dv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.inventario_dv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.inventario_dv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.inventario_dv.Size = new System.Drawing.Size(1056, 622);
            this.inventario_dv.TabIndex = 0;
            this.inventario_dv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventario_dv_CellContentClick);
            // 
            // modificar_btn
            // 
            this.modificar_btn.AllowDrop = true;
            this.modificar_btn.BackColor = System.Drawing.Color.Transparent;
            this.modificar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificar_btn.FlatAppearance.BorderSize = 0;
            this.modificar_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.modificar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.modificar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.modificar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificar_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.modificar_btn.Image = ((System.Drawing.Image)(resources.GetObject("modificar_btn.Image")));
            this.modificar_btn.Location = new System.Drawing.Point(238, 28);
            this.modificar_btn.Name = "modificar_btn";
            this.modificar_btn.Size = new System.Drawing.Size(89, 83);
            this.modificar_btn.TabIndex = 3;
            this.modificar_btn.UseVisualStyleBackColor = false;
            this.modificar_btn.Click += new System.EventHandler(this.modificar_btn_Click);
            // 
            // añadir_btn
            // 
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
            this.añadir_btn.Location = new System.Drawing.Point(12, 28);
            this.añadir_btn.Name = "añadir_btn";
            this.añadir_btn.Size = new System.Drawing.Size(89, 83);
            this.añadir_btn.TabIndex = 1;
            this.añadir_btn.UseVisualStyleBackColor = false;
            this.añadir_btn.Click += new System.EventHandler(this.añadir_btn_Click);
            // 
            // eliminar_btn
            // 
            this.eliminar_btn.BackColor = System.Drawing.Color.Transparent;
            this.eliminar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminar_btn.FlatAppearance.BorderSize = 0;
            this.eliminar_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.eliminar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eliminar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.eliminar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.eliminar_btn.Image = ((System.Drawing.Image)(resources.GetObject("eliminar_btn.Image")));
            this.eliminar_btn.Location = new System.Drawing.Point(123, 28);
            this.eliminar_btn.Name = "eliminar_btn";
            this.eliminar_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eliminar_btn.Size = new System.Drawing.Size(89, 83);
            this.eliminar_btn.TabIndex = 2;
            this.eliminar_btn.UseVisualStyleBackColor = false;
            this.eliminar_btn.Click += new System.EventHandler(this.eliminar_btn_Click);
            // 
            // ventas_gbox
            // 
            this.ventas_gbox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ventas_gbox.Controls.Add(this.reportes_btn);
            this.ventas_gbox.Controls.Add(this.ventas_btn);
            this.ventas_gbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventas_gbox.ForeColor = System.Drawing.SystemColors.Control;
            this.ventas_gbox.Location = new System.Drawing.Point(12, 281);
            this.ventas_gbox.Name = "ventas_gbox";
            this.ventas_gbox.Size = new System.Drawing.Size(357, 185);
            this.ventas_gbox.TabIndex = 15;
            this.ventas_gbox.TabStop = false;
            this.ventas_gbox.Text = "Gestión de Ventas:";
            this.ventas_gbox.Enter += new System.EventHandler(this.ventas_gbox_Enter);
            // 
            // reportes_btn
            // 
            this.reportes_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reportes_btn.BackColor = System.Drawing.Color.Transparent;
            this.reportes_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportes_btn.FlatAppearance.BorderSize = 0;
            this.reportes_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportes_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportes_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.reportes_btn.Image = ((System.Drawing.Image)(resources.GetObject("reportes_btn.Image")));
            this.reportes_btn.Location = new System.Drawing.Point(164, 31);
            this.reportes_btn.Name = "reportes_btn";
            this.reportes_btn.Size = new System.Drawing.Size(154, 124);
            this.reportes_btn.TabIndex = 5;
            this.reportes_btn.UseVisualStyleBackColor = false;
            this.reportes_btn.Click += new System.EventHandler(this.reportes_btn_Click);
            // 
            // ventas_btn
            // 
            this.ventas_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ventas_btn.BackColor = System.Drawing.Color.Transparent;
            this.ventas_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ventas_btn.FlatAppearance.BorderSize = 0;
            this.ventas_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ventas_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventas_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.ventas_btn.Image = ((System.Drawing.Image)(resources.GetObject("ventas_btn.Image")));
            this.ventas_btn.Location = new System.Drawing.Point(21, 48);
            this.ventas_btn.Name = "ventas_btn";
            this.ventas_btn.Size = new System.Drawing.Size(105, 107);
            this.ventas_btn.TabIndex = 4;
            this.ventas_btn.UseVisualStyleBackColor = false;
            this.ventas_btn.Click += new System.EventHandler(this.ventas_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Black;
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.back_btn.Location = new System.Drawing.Point(12, 580);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(228, 46);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "Cerrar Sesión";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // welcome_lbl
            // 
            this.welcome_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.welcome_lbl.AutoSize = true;
            this.welcome_lbl.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.welcome_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.welcome_lbl.Location = new System.Drawing.Point(15, 22);
            this.welcome_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.welcome_lbl.Name = "welcome_lbl";
            this.welcome_lbl.Size = new System.Drawing.Size(209, 46);
            this.welcome_lbl.TabIndex = 17;
            this.welcome_lbl.Text = "Bienvenido,";
            this.welcome_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nombreuser_lbl
            // 
            this.nombreuser_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nombreuser_lbl.AutoSize = true;
            this.nombreuser_lbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.nombreuser_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.nombreuser_lbl.Location = new System.Drawing.Point(18, 68);
            this.nombreuser_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nombreuser_lbl.Name = "nombreuser_lbl";
            this.nombreuser_lbl.Size = new System.Drawing.Size(0, 28);
            this.nombreuser_lbl.TabIndex = 18;
            this.nombreuser_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.añadir_btn);
            this.groupBox1.Controls.Add(this.eliminar_btn);
            this.groupBox1.Controls.Add(this.modificar_btn);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 130);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion de Inventario:";
            // 
            // InicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1465, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nombreuser_lbl);
            this.Controls.Add(this.welcome_lbl);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.ventas_gbox);
            this.Controls.Add(this.inventario_gbox);
            this.Name = "InicioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.InicioForm_Load);
            this.inventario_gbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventario_dv)).EndInit();
            this.ventas_gbox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox inventario_gbox;
        private System.Windows.Forms.Button modificar_btn;
        private System.Windows.Forms.Button añadir_btn;
        private System.Windows.Forms.Button eliminar_btn;
        private System.Windows.Forms.DataGridView inventario_dv;
        private System.Windows.Forms.GroupBox ventas_gbox;
        private System.Windows.Forms.Button reportes_btn;
        private System.Windows.Forms.Button ventas_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label welcome_lbl;
        private System.Windows.Forms.Label nombreuser_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
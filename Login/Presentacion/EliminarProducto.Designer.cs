namespace Login.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarProducto));
            this.buscar_btn = new System.Windows.Forms.Button();
            this.idProducto_lbl = new System.Windows.Forms.Label();
            this.idProducto_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buscar_btn
            // 
            this.buscar_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buscar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscar_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.buscar_btn.Location = new System.Drawing.Point(16, 92);
            this.buscar_btn.Name = "buscar_btn";
            this.buscar_btn.Size = new System.Drawing.Size(438, 46);
            this.buscar_btn.TabIndex = 5;
            this.buscar_btn.Text = "Eliminar Del Inventario";
            this.buscar_btn.UseVisualStyleBackColor = false;
            this.buscar_btn.Click += new System.EventHandler(this.buscar_btn_Click);
            // 
            // idProducto_lbl
            // 
            this.idProducto_lbl.AutoSize = true;
            this.idProducto_lbl.BackColor = System.Drawing.Color.DarkSlateGray;
            this.idProducto_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProducto_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.idProducto_lbl.Location = new System.Drawing.Point(12, 22);
            this.idProducto_lbl.Name = "idProducto_lbl";
            this.idProducto_lbl.Size = new System.Drawing.Size(133, 21);
            this.idProducto_lbl.TabIndex = 4;
            this.idProducto_lbl.Text = "ID del Producto:";
            // 
            // idProducto_txt
            // 
            this.idProducto_txt.BackColor = System.Drawing.Color.White;
            this.idProducto_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProducto_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.idProducto_txt.Location = new System.Drawing.Point(16, 57);
            this.idProducto_txt.Name = "idProducto_txt";
            this.idProducto_txt.Size = new System.Drawing.Size(438, 29);
            this.idProducto_txt.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(16, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 51);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(489, 207);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buscar_btn);
            this.Controls.Add(this.idProducto_lbl);
            this.Controls.Add(this.idProducto_txt);
            this.Name = "EliminarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Productos";
            this.Load += new System.EventHandler(this.EliminarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscar_btn;
        private System.Windows.Forms.Label idProducto_lbl;
        private System.Windows.Forms.TextBox idProducto_txt;
        private System.Windows.Forms.Button button1;
    }
}
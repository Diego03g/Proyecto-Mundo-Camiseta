namespace Login
{
    partial class RegistroForm
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
            this.registro_gbox = new System.Windows.Forms.GroupBox();
            this.confirmarContraseña_txt = new System.Windows.Forms.TextBox();
            this.confirmarContraseña_lbl = new System.Windows.Forms.Label();
            this.registrar_btn = new System.Windows.Forms.Button();
            this.contraseña_txt = new System.Windows.Forms.TextBox();
            this.correo_txt = new System.Windows.Forms.TextBox();
            this.apellido_txt = new System.Windows.Forms.TextBox();
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imagenes_pnl = new System.Windows.Forms.Panel();
            this.registro_gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // registro_gbox
            // 
            this.registro_gbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.registro_gbox.Controls.Add(this.confirmarContraseña_txt);
            this.registro_gbox.Controls.Add(this.confirmarContraseña_lbl);
            this.registro_gbox.Controls.Add(this.registrar_btn);
            this.registro_gbox.Controls.Add(this.contraseña_txt);
            this.registro_gbox.Controls.Add(this.correo_txt);
            this.registro_gbox.Controls.Add(this.apellido_txt);
            this.registro_gbox.Controls.Add(this.nombre_txt);
            this.registro_gbox.Controls.Add(this.label5);
            this.registro_gbox.Controls.Add(this.label4);
            this.registro_gbox.Controls.Add(this.label2);
            this.registro_gbox.Controls.Add(this.label1);
            this.registro_gbox.ForeColor = System.Drawing.SystemColors.Control;
            this.registro_gbox.Location = new System.Drawing.Point(12, 12);
            this.registro_gbox.Name = "registro_gbox";
            this.registro_gbox.Size = new System.Drawing.Size(437, 639);
            this.registro_gbox.TabIndex = 0;
            this.registro_gbox.TabStop = false;
            this.registro_gbox.Text = "Registro de usuarios";
            // 
            // confirmarContraseña_txt
            // 
            this.confirmarContraseña_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.confirmarContraseña_txt.Location = new System.Drawing.Point(25, 423);
            this.confirmarContraseña_txt.Name = "confirmarContraseña_txt";
            this.confirmarContraseña_txt.Size = new System.Drawing.Size(395, 29);
            this.confirmarContraseña_txt.TabIndex = 5;
            this.confirmarContraseña_txt.UseSystemPasswordChar = true;
            // 
            // confirmarContraseña_lbl
            // 
            this.confirmarContraseña_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.confirmarContraseña_lbl.AutoSize = true;
            this.confirmarContraseña_lbl.Location = new System.Drawing.Point(21, 395);
            this.confirmarContraseña_lbl.Name = "confirmarContraseña_lbl";
            this.confirmarContraseña_lbl.Size = new System.Drawing.Size(179, 21);
            this.confirmarContraseña_lbl.TabIndex = 6;
            this.confirmarContraseña_lbl.Text = "Confirmar contraseña:";
            // 
            // registrar_btn
            // 
            this.registrar_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.registrar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrar_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.registrar_btn.Location = new System.Drawing.Point(25, 537);
            this.registrar_btn.Name = "registrar_btn";
            this.registrar_btn.Size = new System.Drawing.Size(395, 61);
            this.registrar_btn.TabIndex = 6;
            this.registrar_btn.Text = "Registrar";
            this.registrar_btn.UseVisualStyleBackColor = true;
            this.registrar_btn.Click += new System.EventHandler(this.registrar_btn_Click);
            // 
            // contraseña_txt
            // 
            this.contraseña_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.contraseña_txt.Location = new System.Drawing.Point(25, 338);
            this.contraseña_txt.Name = "contraseña_txt";
            this.contraseña_txt.Size = new System.Drawing.Size(395, 29);
            this.contraseña_txt.TabIndex = 4;
            this.contraseña_txt.UseSystemPasswordChar = true;
            // 
            // correo_txt
            // 
            this.correo_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.correo_txt.Location = new System.Drawing.Point(25, 255);
            this.correo_txt.Name = "correo_txt";
            this.correo_txt.Size = new System.Drawing.Size(395, 29);
            this.correo_txt.TabIndex = 3;
            // 
            // apellido_txt
            // 
            this.apellido_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.apellido_txt.Location = new System.Drawing.Point(25, 173);
            this.apellido_txt.Name = "apellido_txt";
            this.apellido_txt.Size = new System.Drawing.Size(395, 29);
            this.apellido_txt.TabIndex = 2;
            // 
            // nombre_txt
            // 
            this.nombre_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nombre_txt.Location = new System.Drawing.Point(25, 91);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(395, 29);
            this.nombre_txt.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellido(s)";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Correo Electronico:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre(s):";
            // 
            // imagenes_pnl
            // 
            this.imagenes_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagenes_pnl.Location = new System.Drawing.Point(459, 12);
            this.imagenes_pnl.Name = "imagenes_pnl";
            this.imagenes_pnl.Size = new System.Drawing.Size(793, 657);
            this.imagenes_pnl.TabIndex = 1;
            // 
            // RegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(90)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.imagenes_pnl);
            this.Controls.Add(this.registro_gbox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RegistroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroForm";
            this.registro_gbox.ResumeLayout(false);
            this.registro_gbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox registro_gbox;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel imagenes_pnl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registrar_btn;
        private System.Windows.Forms.TextBox contraseña_txt;
        private System.Windows.Forms.TextBox correo_txt;
        private System.Windows.Forms.TextBox apellido_txt;
        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.TextBox confirmarContraseña_txt;
        private System.Windows.Forms.Label confirmarContraseña_lbl;
    }
}
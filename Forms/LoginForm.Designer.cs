namespace Login
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.titulo_lbl = new System.Windows.Forms.Label();
            this.contraseña_lbl = new System.Windows.Forms.Label();
            this.usuario_lbl = new System.Windows.Forms.Label();
            this.usuario_txt = new System.Windows.Forms.TextBox();
            this.contraseña_txt = new System.Windows.Forms.TextBox();
            this.entrar_btn = new System.Windows.Forms.Button();
            this.registro_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sobreNosotros_img = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sobreNosotros_img)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo_lbl
            // 
            this.titulo_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.titulo_lbl.AutoSize = true;
            this.titulo_lbl.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.titulo_lbl.Location = new System.Drawing.Point(24, 25);
            this.titulo_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titulo_lbl.Name = "titulo_lbl";
            this.titulo_lbl.Size = new System.Drawing.Size(388, 65);
            this.titulo_lbl.TabIndex = 0;
            this.titulo_lbl.Text = "INICIAR SESIÓN";
            this.titulo_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // contraseña_lbl
            // 
            this.contraseña_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.contraseña_lbl.AutoSize = true;
            this.contraseña_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.contraseña_lbl.Location = new System.Drawing.Point(30, 279);
            this.contraseña_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.contraseña_lbl.Name = "contraseña_lbl";
            this.contraseña_lbl.Size = new System.Drawing.Size(113, 25);
            this.contraseña_lbl.TabIndex = 1;
            this.contraseña_lbl.Text = "Contraseña";
            // 
            // usuario_lbl
            // 
            this.usuario_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.usuario_lbl.AutoSize = true;
            this.usuario_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.usuario_lbl.Location = new System.Drawing.Point(30, 108);
            this.usuario_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.usuario_lbl.Name = "usuario_lbl";
            this.usuario_lbl.Size = new System.Drawing.Size(185, 25);
            this.usuario_lbl.TabIndex = 2;
            this.usuario_lbl.Text = "Nombre de usuario";
            // 
            // usuario_txt
            // 
            this.usuario_txt.AcceptsTab = true;
            this.usuario_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.usuario_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(90)))), ((int)(((byte)(96)))));
            this.usuario_txt.ForeColor = System.Drawing.SystemColors.Control;
            this.usuario_txt.Location = new System.Drawing.Point(35, 148);
            this.usuario_txt.Margin = new System.Windows.Forms.Padding(6);
            this.usuario_txt.Name = "usuario_txt";
            this.usuario_txt.Size = new System.Drawing.Size(528, 33);
            this.usuario_txt.TabIndex = 1;
            // 
            // contraseña_txt
            // 
            this.contraseña_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.contraseña_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(90)))), ((int)(((byte)(96)))));
            this.contraseña_txt.ForeColor = System.Drawing.SystemColors.Control;
            this.contraseña_txt.Location = new System.Drawing.Point(35, 317);
            this.contraseña_txt.Margin = new System.Windows.Forms.Padding(6);
            this.contraseña_txt.Name = "contraseña_txt";
            this.contraseña_txt.Size = new System.Drawing.Size(528, 33);
            this.contraseña_txt.TabIndex = 2;
            this.contraseña_txt.UseSystemPasswordChar = true;
            // 
            // entrar_btn
            // 
            this.entrar_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.entrar_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.entrar_btn.FlatAppearance.BorderSize = 0;
            this.entrar_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.entrar_btn.Location = new System.Drawing.Point(35, 614);
            this.entrar_btn.Name = "entrar_btn";
            this.entrar_btn.Size = new System.Drawing.Size(132, 55);
            this.entrar_btn.TabIndex = 3;
            this.entrar_btn.Text = "Comenzar";
            this.entrar_btn.UseVisualStyleBackColor = true;
            this.entrar_btn.Click += new System.EventHandler(this.entrar_btn_Click);
            // 
            // registro_btn
            // 
            this.registro_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.registro_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.registro_btn.FlatAppearance.BorderSize = 0;
            this.registro_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registro_btn.Location = new System.Drawing.Point(173, 614);
            this.registro_btn.Name = "registro_btn";
            this.registro_btn.Size = new System.Drawing.Size(132, 55);
            this.registro_btn.TabIndex = 4;
            this.registro_btn.Text = "Registrar";
            this.registro_btn.UseVisualStyleBackColor = true;
            this.registro_btn.Click += new System.EventHandler(this.registro_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.sobreNosotros_img);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(591, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 644);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sobre Nosotros.";
            // 
            // sobreNosotros_img
            // 
            this.sobreNosotros_img.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sobreNosotros_img.Image = ((System.Drawing.Image)(resources.GetObject("sobreNosotros_img.Image")));
            this.sobreNosotros_img.Location = new System.Drawing.Point(54, 55);
            this.sobreNosotros_img.Name = "sobreNosotros_img";
            this.sobreNosotros_img.Size = new System.Drawing.Size(561, 543);
            this.sobreNosotros_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sobreNosotros_img.TabIndex = 0;
            this.sobreNosotros_img.TabStop = false;
            this.sobreNosotros_img.Click += new System.EventHandler(this.sobreNosotros_img_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(90)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.registro_btn);
            this.Controls.Add(this.entrar_btn);
            this.Controls.Add(this.contraseña_txt);
            this.Controls.Add(this.usuario_txt);
            this.Controls.Add(this.usuario_lbl);
            this.Controls.Add(this.contraseña_lbl);
            this.Controls.Add(this.titulo_lbl);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor_Inventarios";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sobreNosotros_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo_lbl;
        private System.Windows.Forms.Label contraseña_lbl;
        private System.Windows.Forms.Label usuario_lbl;
        private System.Windows.Forms.TextBox usuario_txt;
        private System.Windows.Forms.TextBox contraseña_txt;
        private System.Windows.Forms.Button entrar_btn;
        private System.Windows.Forms.Button registro_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox sobreNosotros_img;
    }
}


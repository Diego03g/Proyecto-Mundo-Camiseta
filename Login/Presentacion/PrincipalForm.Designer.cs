namespace Login.Presentacion
{
    partial class PrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_registro = new System.Windows.Forms.Button();
            this.btn_presentacion = new System.Windows.Forms.Button();
            this.titulo_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Image = ((System.Drawing.Image)(resources.GetObject("btn_Login.Image")));
            this.btn_Login.Location = new System.Drawing.Point(55, 156);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(210, 198);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_registro
            // 
            this.btn_registro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registro.FlatAppearance.BorderSize = 0;
            this.btn_registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registro.Image = ((System.Drawing.Image)(resources.GetObject("btn_registro.Image")));
            this.btn_registro.Location = new System.Drawing.Point(545, 156);
            this.btn_registro.Name = "btn_registro";
            this.btn_registro.Size = new System.Drawing.Size(210, 198);
            this.btn_registro.TabIndex = 1;
            this.btn_registro.UseVisualStyleBackColor = true;
            this.btn_registro.Click += new System.EventHandler(this.btn_registro_Click);
            // 
            // btn_presentacion
            // 
            this.btn_presentacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_presentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_presentacion.Location = new System.Drawing.Point(281, 156);
            this.btn_presentacion.Name = "btn_presentacion";
            this.btn_presentacion.Size = new System.Drawing.Size(247, 198);
            this.btn_presentacion.TabIndex = 2;
            this.btn_presentacion.Text = "button1";
            this.btn_presentacion.UseVisualStyleBackColor = true;
            // 
            // titulo_lbl
            // 
            this.titulo_lbl.AutoSize = true;
            this.titulo_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titulo_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_lbl.Location = new System.Drawing.Point(139, 36);
            this.titulo_lbl.Name = "titulo_lbl";
            this.titulo_lbl.Size = new System.Drawing.Size(547, 43);
            this.titulo_lbl.TabIndex = 3;
            this.titulo_lbl.Text = "Bienvienido a Mundo Camiseta ";
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(817, 417);
            this.Controls.Add(this.titulo_lbl);
            this.Controls.Add(this.btn_presentacion);
            this.Controls.Add(this.btn_registro);
            this.Controls.Add(this.btn_Login);
            this.Name = "PrincipalForm";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_registro;
        private System.Windows.Forms.Button btn_presentacion;
        private System.Windows.Forms.Label titulo_lbl;
    }
}
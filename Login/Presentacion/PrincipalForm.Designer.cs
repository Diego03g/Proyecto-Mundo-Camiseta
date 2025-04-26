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
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_registro = new System.Windows.Forms.Button();
            this.btn_presentacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(136, 244);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "button1";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_registro
            // 
            this.btn_registro.Location = new System.Drawing.Point(613, 244);
            this.btn_registro.Name = "btn_registro";
            this.btn_registro.Size = new System.Drawing.Size(75, 23);
            this.btn_registro.TabIndex = 1;
            this.btn_registro.Text = "button1";
            this.btn_registro.UseVisualStyleBackColor = true;
            // 
            // btn_presentacion
            // 
            this.btn_presentacion.Location = new System.Drawing.Point(383, 244);
            this.btn_presentacion.Name = "btn_presentacion";
            this.btn_presentacion.Size = new System.Drawing.Size(75, 23);
            this.btn_presentacion.TabIndex = 2;
            this.btn_presentacion.Text = "button1";
            this.btn_presentacion.UseVisualStyleBackColor = true;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.btn_presentacion);
            this.Controls.Add(this.btn_registro);
            this.Controls.Add(this.btn_Login);
            this.Name = "PrincipalForm";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_registro;
        private System.Windows.Forms.Button btn_presentacion;
    }
}
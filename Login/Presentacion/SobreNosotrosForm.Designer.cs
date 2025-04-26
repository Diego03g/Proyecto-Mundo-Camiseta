namespace Login.Forms
{
    partial class SobreNosotrosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SobreNosotrosForm));
            this.quienesSomos_lbl = new System.Windows.Forms.Label();
            this.quienesSomos_txt = new System.Windows.Forms.TextBox();
            this.contacto_txt = new System.Windows.Forms.TextBox();
            this.contacto_lbl = new System.Windows.Forms.Label();
            this.redes_lbl = new System.Windows.Forms.Label();
            this.fb_img = new System.Windows.Forms.PictureBox();
            this.tw_img = new System.Windows.Forms.PictureBox();
            this.volver_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fb_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tw_img)).BeginInit();
            this.SuspendLayout();
            // 
            // quienesSomos_lbl
            // 
            this.quienesSomos_lbl.AutoSize = true;
            this.quienesSomos_lbl.BackColor = System.Drawing.Color.Transparent;
            this.quienesSomos_lbl.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.quienesSomos_lbl.Location = new System.Drawing.Point(12, 9);
            this.quienesSomos_lbl.Name = "quienesSomos_lbl";
            this.quienesSomos_lbl.Size = new System.Drawing.Size(134, 21);
            this.quienesSomos_lbl.TabIndex = 0;
            this.quienesSomos_lbl.Text = "Quiénes Somos?";
            // 
            // quienesSomos_txt
            // 
            this.quienesSomos_txt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.quienesSomos_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quienesSomos_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quienesSomos_txt.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.quienesSomos_txt.Location = new System.Drawing.Point(16, 42);
            this.quienesSomos_txt.Multiline = true;
            this.quienesSomos_txt.Name = "quienesSomos_txt";
            this.quienesSomos_txt.ReadOnly = true;
            this.quienesSomos_txt.Size = new System.Drawing.Size(582, 134);
            this.quienesSomos_txt.TabIndex = 0;
            this.quienesSomos_txt.Text = resources.GetString("quienesSomos_txt.Text");
            // 
            // contacto_txt
            // 
            this.contacto_txt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.contacto_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contacto_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacto_txt.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.contacto_txt.Location = new System.Drawing.Point(16, 221);
            this.contacto_txt.Multiline = true;
            this.contacto_txt.Name = "contacto_txt";
            this.contacto_txt.ReadOnly = true;
            this.contacto_txt.Size = new System.Drawing.Size(582, 71);
            this.contacto_txt.TabIndex = 0;
            this.contacto_txt.Text = "Diego Mendivil Vazquez\r\ndiegomv@gmail.com\r\n";
            this.contacto_txt.TextChanged += new System.EventHandler(this.contacto_txt_TextChanged);
            // 
            // contacto_lbl
            // 
            this.contacto_lbl.AutoSize = true;
            this.contacto_lbl.BackColor = System.Drawing.Color.Transparent;
            this.contacto_lbl.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.contacto_lbl.Location = new System.Drawing.Point(12, 188);
            this.contacto_lbl.Name = "contacto_lbl";
            this.contacto_lbl.Size = new System.Drawing.Size(83, 21);
            this.contacto_lbl.TabIndex = 2;
            this.contacto_lbl.Text = "Contacto:";
            // 
            // redes_lbl
            // 
            this.redes_lbl.AutoSize = true;
            this.redes_lbl.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.redes_lbl.Location = new System.Drawing.Point(12, 334);
            this.redes_lbl.Name = "redes_lbl";
            this.redes_lbl.Size = new System.Drawing.Size(125, 21);
            this.redes_lbl.TabIndex = 4;
            this.redes_lbl.Text = "Redes Sociales:";
            // 
            // fb_img
            // 
            this.fb_img.Image = ((System.Drawing.Image)(resources.GetObject("fb_img.Image")));
            this.fb_img.Location = new System.Drawing.Point(16, 377);
            this.fb_img.Name = "fb_img";
            this.fb_img.Size = new System.Drawing.Size(93, 90);
            this.fb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fb_img.TabIndex = 5;
            this.fb_img.TabStop = false;
            // 
            // tw_img
            // 
            this.tw_img.Image = ((System.Drawing.Image)(resources.GetObject("tw_img.Image")));
            this.tw_img.Location = new System.Drawing.Point(115, 377);
            this.tw_img.Name = "tw_img";
            this.tw_img.Size = new System.Drawing.Size(97, 90);
            this.tw_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tw_img.TabIndex = 6;
            this.tw_img.TabStop = false;
            // 
            // volver_btn
            // 
            this.volver_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.volver_btn.BackColor = System.Drawing.Color.Transparent;
            this.volver_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volver_btn.FlatAppearance.BorderSize = 0;
            this.volver_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.volver_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.volver_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volver_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volver_btn.ForeColor = System.Drawing.Color.Transparent;
            this.volver_btn.Image = ((System.Drawing.Image)(resources.GetObject("volver_btn.Image")));
            this.volver_btn.Location = new System.Drawing.Point(532, 420);
            this.volver_btn.Name = "volver_btn";
            this.volver_btn.Size = new System.Drawing.Size(52, 47);
            this.volver_btn.TabIndex = 1;
            this.volver_btn.UseVisualStyleBackColor = false;
            this.volver_btn.Click += new System.EventHandler(this.volver_btn_Click);
            // 
            // SobreNosotrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(610, 496);
            this.Controls.Add(this.volver_btn);
            this.Controls.Add(this.tw_img);
            this.Controls.Add(this.fb_img);
            this.Controls.Add(this.redes_lbl);
            this.Controls.Add(this.contacto_txt);
            this.Controls.Add(this.contacto_lbl);
            this.Controls.Add(this.quienesSomos_txt);
            this.Controls.Add(this.quienesSomos_lbl);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SobreNosotrosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Us";
            ((System.ComponentModel.ISupportInitialize)(this.fb_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tw_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quienesSomos_lbl;
        private System.Windows.Forms.TextBox quienesSomos_txt;
        private System.Windows.Forms.TextBox contacto_txt;
        private System.Windows.Forms.Label contacto_lbl;
        private System.Windows.Forms.Label redes_lbl;
        private System.Windows.Forms.PictureBox fb_img;
        private System.Windows.Forms.PictureBox tw_img;
        private System.Windows.Forms.Button volver_btn;
    }
}
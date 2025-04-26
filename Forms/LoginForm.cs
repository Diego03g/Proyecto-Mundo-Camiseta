using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Clases;
using Login.Forms;

namespace Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void registro_btn_Click(object sender, EventArgs e)
        {
            var registro = new RegistroForm();
            registro.Show();
            var login  = new LoginForm();
            login.Close();
        }

        private void entrar_btn_Click(object sender, EventArgs e)
        {
            string email = usuario_txt.Text;
            string password = contraseña_txt.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                usuario_lbl.ForeColor = Color.OrangeRed;
                contraseña_lbl.ForeColor = Color.OrangeRed;
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsvalidEmail(email))
            {
                usuario_lbl.ForeColor = Color.OrangeRed;
                MessageBox.Show("Por favor, ingrese un email válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!VerificarCredenciales(email, password))
            {
                usuario_lbl.ForeColor = Color.OrangeRed;
                contraseña_lbl.ForeColor = Color.OrangeRed;
                MessageBox.Show("Credenciales incorrectas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var inicio = new InicioForm();
            inicio.Show();
            var login = new LoginForm();
            this.Hide();
        }
        private bool IsvalidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool VerificarCredenciales(string email, string password)
        {
            // Aquí debería ir la lógica para verificar las credenciales del usuario.
            // Por ejemplo, consultar una base de datos o un servicio web.
            // Este es solo un ejemplo simple:
            return email == "proyect@gmail.com" && password == "123";
        }

        private void sobreNosotros_img_Click(object sender, EventArgs e)
        {
            var aboutUS = new SobreNosotrosForm();
            aboutUS.Show();
            var login = new LoginForm();
            login.Hide();
        }
    }
}

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

namespace Login
{
    public partial class RegistroForm: Form
    {
        public RegistroForm()
        {
            InitializeComponent();
        }

        private void registrar_btn_Click(object sender, EventArgs e)
        {
            string email = correo_txt.Text;
            string password = contraseña_txt.Text;
            string confirmPassword = confirmarContraseña_txt.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Correo no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Usuario.Registrar(email, password))
            {
                MessageBox.Show("El usuario ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Registro exitoso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var login = new LoginForm();
            login.Show();
            var registro = new RegistroForm();
            registro.Hide();
        }
        private bool IsValidEmail(string email)
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
        }
}

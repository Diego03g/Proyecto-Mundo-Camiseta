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
    public partial class RegistroForm : Form
    {
        // Constructor para inicializar el formulario de registro
        public RegistroForm()
        {
            InitializeComponent();
        }

        // Manejador de evento cuando se hace clic en el boton de registrar
        private void registrar_btn_Click(object sender, EventArgs e)
        {
            string nombre = nombre_txt.Text;
            string apellidos = apellido_txt.Text;
            string email = correo_txt.Text;
            string password = contraseña_txt.Text;
            string confirmPassword = confirmarContraseña_txt.Text;

            // Verifica si algun campo esta vacio
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellidos) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                // Resalta los campos vacios en rojo
                nombre_txt.ForeColor = Color.OrangeRed;
                apellido_txt.ForeColor = Color.OrangeRed;
                correo_txt.ForeColor = Color.OrangeRed;
                contraseña_txt.ForeColor = Color.OrangeRed;
                confirmarContraseña_txt.ForeColor = Color.OrangeRed;
                MessageBox.Show("Por favor complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica si el correo es valido
            if (!IsValidEmail(email))
            {
                correo_txt.ForeColor = Color.OrangeRed;
                MessageBox.Show("Correo no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica si las contraseñas coinciden
            if (password != confirmPassword)
            {
                contraseña_txt.ForeColor = Color.OrangeRed;
                confirmarContraseña_txt.ForeColor = Color.OrangeRed;
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Intenta registrar el usuario y verifica si ya existe
            if (!Usuario.Registrar(nombre, apellidos, email, password))
            {
                correo_txt.ForeColor = Color.OrangeRed;
                MessageBox.Show("El usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Resalta los campos en verde si el registro es exitoso
            nombre_txt.ForeColor = Color.Green;
            apellido_txt.ForeColor = Color.Green;
            correo_txt.ForeColor = Color.Green;
            contraseña_txt.ForeColor = Color.Green;
            confirmarContraseña_txt.ForeColor = Color.Green;
            MessageBox.Show("Registro exitoso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var login = new LoginForm();
            login.Show();
            this.Hide();
        }

        // Metodo para validar si el correo es valido
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

        // Manejador de evento cuando se hace clic en el boton de volver al login
        private void button1_Click(object sender, EventArgs e)
        {
            var login = new LoginForm();
            login.Show();
            this.Close();
        }

        // Metodo que se ejecuta cuando el formulario de registro se carga
        private void RegistroForm_Load(object sender, EventArgs e)
        {

        }
    }
}

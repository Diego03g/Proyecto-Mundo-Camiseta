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
        // Constructor para inicializar el formulario de login
        public LoginForm()
        {
            InitializeComponent();
        }

        // Manejador de evento cuando se hace clic en el boton de registro
        private void registro_btn_Click(object sender, EventArgs e)
        {
            // Abre el formulario de registro
            var registro = new RegistroForm();
            registro.Show();
            // Cierra el formulario de login
            this.Hide();
        }

        // Manejador de evento cuando se hace clic en el boton de entrar
        private async void entrar_btn_Click(object sender, EventArgs e)
        {
            string email = usuario_txt.Text;
            string password = contraseña_txt.Text;

            // Verifica si los campos estan vacios
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                usuario_lbl.ForeColor = Color.DarkRed;
                contraseña_lbl.ForeColor = Color.DarkRed;
                MessageBox.Show("Por favor complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica las credenciales del usuario de manera asincrona
            Usuario usuario = await Usuario.VerificarCredencialesAsync(email, password);
            if (usuario == null)
            {
                usuario_lbl.ForeColor = Color.DarkRed;
                contraseña_lbl.ForeColor = Color.DarkRed;
                MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Abre el formulario de inicio si las credenciales son correctas
            var inicio = new InicioForm(usuario);
            inicio.Show();
            // Oculta el formulario de login
            this.Hide();
        }

        // Manejador de evento cuando se hace clic en la imagen de sobre nosotros
        private void sobreNosotros_img_Click(object sender, EventArgs e)
        {
            // Abre el formulario de sobre nosotros
            var aboutUS = new SobreNosotrosForm();
            aboutUS.Show();
            // Oculta el formulario de login
            this.Hide();
        }

        // Manejador de evento cuando cambia el texto en el campo de usuario
        private void usuario_txt_TextChanged(object sender, EventArgs e)
        {
            // Valida el formato del email
            if (!Validaciones.ValidarEmail(usuario_txt.Text))
            {
                usuario_lbl.ForeColor = Color.DarkRed;
            }
            else
            {
                usuario_lbl.ForeColor = Color.Green;
            }
        }

        // Manejador de evento cuando cambia el texto en el campo de contraseña
        private void contraseña_txt_TextChanged(object sender, EventArgs e)
        {
            // Valida si la contraseña es válida
            if (!Validaciones.ValidarString(contraseña_txt.Text))
            {
                contraseña_lbl.ForeColor = Color.DarkRed;
            }
            else
            {
                contraseña_lbl.ForeColor = Color.Green;
            }
        }

        // Metodo que se ejecuta cuando el formulario de login se carga
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}


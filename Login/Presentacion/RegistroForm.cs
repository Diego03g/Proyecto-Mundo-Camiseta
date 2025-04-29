using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Clases;
using Login.Logica;
using Login.Presentacion;

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
            string apellidos = apellido_txt.Text;
            string email = correo_txt.Text;
            string password = contraseña_txt.Text;
            string confirmPassword = confirmarContraseña_txt.Text;
            List<string> Errores = new List<string>();

            var Logica = new LogicaRegistro();

            if (!Logica.ValidarNombre(nombre_txt.Text))
            {
                Errores.Add("Coloque un Nombre Valido");
                nombre_lbl.ForeColor = Color.DarkRed;
            }
            if (!Logica.ValidarApellido(apellido_txt.Text))
            {
                Errores.Add("Coloque un Apellido Valido");
                apellido_lbl.ForeColor = Color.DarkRed;
            }
            if (!Logica.ValidarEmail(correo_txt.Text))
            {
                Errores.Add("Coloque un Correo Valido");
                correo_lbl.ForeColor = Color.DarkRed;
            }
            if (!Logica.ValidarContraseña(contraseña_txt.Text))
            {
                Errores.Add("Coloque una Contraseña Valida");
                contraseña_lbl.ForeColor = Color.DarkRed;
            }
            if (!Logica.ValidarConfirmacionContraseña(contraseña_txt.Text, confirmarContraseña_txt.Text))
            {
                Errores.Add("Las Contraseñas no Coinciden");
                confirmarContraseña_lbl.ForeColor = Color.DarkRed;
            }
            if (Errores.Count > 0)
            {
                string mensajeError = "";
                foreach (string error in Errores)
                {
                    mensajeError = mensajeError + error + " \n";
                }
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var nuevoUsuario = new Usuario
            {
                Nombre = nombre_txt.Text,
                Apellidos = apellido_txt.Text,
                CorreoElectronico = correo_txt.Text,
                Contraseña = confirmarContraseña_txt.Text,
               
            };


            try
            {
                if (nuevoUsuario.Registrar())
                {
                    MessageBox.Show("Usuario registrado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var inicio = new LoginForm();
                    inicio.Show();
                    this.Close();
                }
                else
                {
                    correo_txt.ForeColor = Color.OrangeRed;
                    MessageBox.Show("El usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Manejador de evento cuando se hace clic en el boton de volver al login
        private void button1_Click(object sender, EventArgs e)
        {
            var login = new PrincipalForm();
            login.Show();
            this.Close();
        }

        // Metodo que se ejecuta cuando el formulario de registro se carga
        private void RegistroForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nombre_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.ValidarSoloLetras(e.KeyChar);
        }

        private void apellido_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void apellido_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.ValidarSoloLetras(e.KeyChar);
        }
    }
}

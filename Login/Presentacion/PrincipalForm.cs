using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Presentacion
{
    public partial class PrincipalForm : Form
    {
        private Timer timer; //timer para cambiar el color del label
        private Random random = new Random(); //generador de numeros aleatorios para el color

        //constructor del formulario principal
        public PrincipalForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen; //Centra el formulario
        }

        //evento que se ejecuta cuando el formulario carga
        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            //inicializar el timer
            timer = new Timer();
            timer.Interval = 1000; //intervalo de 1 segundo
            timer.Tick += Timer_Tick; // signar el metodo que se ejecutara cada vez que pase el intervalo
            timer.Start(); //iniciar el timer
        }

        //evento que se ejecuta cada vez que el timer hace tick
        private void Timer_Tick(object sender, EventArgs e)
        {
            //cambiar el color del label llamado titulo_lbl a un color aleatorio
            titulo_lbl.ForeColor = Color.FromArgb(
                random.Next(256), //componente rojo aleatorio
                random.Next(256), //componente verde aleatorio
                random.Next(256)  //componente azul aleatorio
            );
        }

        //evento que se ejecuta cuando se hace click en el boton de login
        private void btn_Login_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario de login
            LoginForm loginForm = new LoginForm();

            // Mostrar el formulario de login
            loginForm.Show();
            // Cierra el formulario Principal
            this.Hide();
        }

        // Manejador de evento cuando se hace clic en el boton de registro
        private void btn_registro_Click(object sender, EventArgs e)
        {
            // Abre el formulario de registro
            var registro = new RegistroForm();
            registro.Show();
            // Cierra el formulario Principal
            this.Hide();
        }
    }
}

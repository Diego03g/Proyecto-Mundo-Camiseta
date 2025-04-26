using Login.Clases;
using Login.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class InicioForm: Form
    {
        public InicioForm()
        {
            InitializeComponent();
        }
        private void añadir_btn_Click(object sender, EventArgs e)
        {
            var productos = new AñadirProductosForm();
            productos.Show();
            this.Close();
        }

        private void CargarProductos()
        {
            var productos = Inventarios.ObtenerProductos();
            inventario_dv.DataSource = productos;
        }

        private void modificar_btn_Click(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea cerrar sesión?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var login = new LoginForm();
                login.Show();
                this.Close();
            }
        }

        private void ventas_btn_Click(object sender, EventArgs e)
        {

        }
    }
}

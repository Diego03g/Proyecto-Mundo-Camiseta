using System;
using System.Drawing;
using System.Windows.Forms;
using Login.Clases;

namespace Login.Forms
{
    public partial class EliminarProducto : Form
    {
        private Usuario usuarioActual;

        // Constructor para inicializar el formulario y asignar el usuario actual
        public EliminarProducto(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        // Manejador del evento de busqueda de un producto por su ID
        private void buscar_btn_Click(object sender, EventArgs e)
        {
            string idProducto = idProducto_txt.Text;

            // Verifica si el ID del producto no esta vacio
            if (string.IsNullOrWhiteSpace(idProducto))
            {
                MessageBox.Show("Por favor ingrese el codigo del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Busca el producto por el ID ingresado
            Productos producto = Productos.BuscarProductoPorId(idProducto);

            // Si el producto no es encontrado muestra un mensaje de error
            if (producto == null)
            {
                idProducto_lbl.ForeColor = Color.Red;
                MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Intenta eliminar el producto por el ID
            bool resultado = Productos.EliminarProductoPorId(idProducto);

            // Si el producto es eliminado con exito muestra un mensaje de exito
            if (resultado)
            {
                idProducto_lbl.ForeColor = Color.Green;
                MessageBox.Show("Producto eliminado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var inicio = new InicioForm(usuarioActual);
                inicio.Show();
                this.Close();
            }
            else
            {
                // Si ocurre un error al eliminar muestra un mensaje de error
                idProducto_lbl.ForeColor = Color.Red;
                MessageBox.Show("Error al eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Manejador del evento para volver al formulario de inicio
        private void button1_Click(object sender, EventArgs e)
        {
            var inicio = new InicioForm(usuarioActual);
            inicio.Show();
            this.Close();
        }

        // Metodo que se ejecuta cuando el formulario se carga
        private void EliminarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}

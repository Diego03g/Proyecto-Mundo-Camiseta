using System;
using System.Windows.Forms;
using Login.Clases;

namespace Login.Forms
{
    public partial class ModificarProducto : Form
    {
        private Productos productoActual;
        private Usuario usuarioActual;

        //Constructor para inicializar el formulario y asignar el usuario actual
        public ModificarProducto(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        //Manejador del evento de busqueda de un producto por su ID
        private void buscar_btn_Click(object sender, EventArgs e)
        {
            string idProducto = idProducto_txt.Text;

            //Verifica si el ID del producto no esta vacio
            if (string.IsNullOrWhiteSpace(idProducto))
            {
                idProducto_lbl.ForeColor = System.Drawing.Color.OrangeRed;
                MessageBox.Show("Por favor ingrese el codigo del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Busca el producto por el ID ingresado
            productoActual = Productos.BuscarProductoPorId(idProducto);

            //Si el producto no es encontrado muestra un mensaje de error
            if (productoActual == null)
            {
                idProducto_lbl.ForeColor = System.Drawing.Color.OrangeRed;
                MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Si el producto es encontrado carga sus datos
            CargarDatosProducto();
        }

        //Carga los datos del producto en los controles de la interfaz
        private void CargarDatosProducto()
        {
            producto_lbl.Text = productoActual.Nombre;
            marca_txt.Text = productoActual.Marca;
            categoria_cbox.Text = productoActual.Categoria;
            precio_txt.Text = productoActual.Precio.ToString();
            tallaL_nud.Text = productoActual.StockL.ToString();
            tallaS_nud.Text = productoActual.StockM.ToString();
            tallaM_nud.Text = productoActual.StockS.ToString();
            tallaXL_nud.Text = productoActual.StockXL.ToString();
        }

        //Manejador del evento de guardar cambios en el producto
        private void guardar_btn_Click(object sender, EventArgs e)
        {
            //Verifica si no hay producto cargado para modificar
            if (productoActual == null)
            {
                idProducto_lbl.ForeColor = System.Drawing.Color.OrangeRed;
                MessageBox.Show("No hay producto cargado para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Asigna los nuevos valores al producto actual
            productoActual.Nombre = producto_lbl.Text;
            productoActual.Marca = marca_txt.Text;
            productoActual.Categoria = categoria_cbox.Text;
            productoActual.Precio = double.Parse(precio_txt.Text);
            productoActual.StockL = int.Parse(tallaL_nud.Text);
            productoActual.StockM = int.Parse(tallaM_nud.Text);
            productoActual.StockS = int.Parse(tallaS_nud.Text);
            productoActual.StockXL = int.Parse(tallaXL_nud.Text);

            try
            {
                //Intenta modificar el producto en la base de datos
                Productos.ModificarProductos(productoActual);
                MessageBox.Show("Producto modificado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //Si ocurre un error al modificar, cambia el color de los controles a rojo y muestra mensaje de error
                producto_lbl.ForeColor = System.Drawing.Color.OrangeRed;
                marca_lbl.ForeColor = System.Drawing.Color.OrangeRed;
                categoria_lbl.ForeColor = System.Drawing.Color.OrangeRed;
                precio_lbl.ForeColor = System.Drawing.Color.OrangeRed;
                tallaL_lbl.ForeColor = System.Drawing.Color.OrangeRed;
                tallaM_lbl.ForeColor = System.Drawing.Color.OrangeRed;
                tallaS_lbl.ForeColor = System.Drawing.Color.OrangeRed;
                tallaXL_lbl.ForeColor = System.Drawing.Color.OrangeRed;
                MessageBox.Show("Error al modificar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Manejador del evento para volver al formulario de inicio
        private void volver_btn_Click(object sender, EventArgs e)
        {
            var inicio = new InicioForm(usuarioActual);
            inicio.Show();
            this.Close();
        }

        //Metodo que se ejecuta cuando el formulario se carga
        private void ModificarProducto_Load(object sender, EventArgs e)
        {

        }

        //Manejador de eventos para el cambio de texto en el campo del ID del producto
        private void idProducto_txt_TextChanged(object sender, EventArgs e)
        {

        }

        //Manejador de eventos para el cambio de texto en el campo de marca
        private void marca_txt_TextChanged(object sender, EventArgs e)
        {

        }

        //Manejador de eventos para el cambio de texto en el campo de precio
        private void precio_txt_TextChanged(object sender, EventArgs e)
        {

        }

        //Manejador de eventos para el cambio de seleccion en el combo de categoria
        private void categoria_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
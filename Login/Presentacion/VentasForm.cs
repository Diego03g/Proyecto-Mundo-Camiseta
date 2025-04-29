using System;
using System.Windows.Forms;
using Login.Clases;

namespace Login.Forms
{
    public partial class VentasForm : Form
    {
        // Variable para almacenar el usuario actual
        private Usuario usuarioActual;

        // Constructor de la clase VentasForm
        public VentasForm(Usuario usuario)
        {
            InitializeComponent();
            // Asigna el usuario actual
            usuarioActual = usuario;
            // Registra los manejadores de eventos para las cantidades de tallas
            tallaS_nud.ValueChanged += tallaS_nud_ValueChanged;
            tallaM_nud.ValueChanged += tallaM_nud_ValueChanged;
            tallaL_nud.ValueChanged += tallaL_nud_ValueChanged;
            tallaXL_nud.ValueChanged += tallaXL_nud_ValueChanged;
        }

        // Manejador del evento de hacer clic en el botón de vender
        private void vender_btn_Click(object sender, EventArgs e)
        {
            // Obtiene el id del producto
            string idProducto = idProducto_lbl.Text;
            // Obtiene las cantidades vendidas para cada talla
            int cantidadVendidaS = int.Parse(tallaS_nud.Text);
            int cantidadVendidaM = int.Parse(tallaM_nud.Text);
            int cantidadVendidaL = int.Parse(tallaL_nud.Text);
            int cantidadVendidaXL = int.Parse(tallaXL_nud.Text);

            // Busca el producto en la base de datos usando el id
            Productos producto = Productos.BuscarProductoPorId(Convert.ToInt32(idProducto));

            // Si no se encuentra el producto, muestra un mensaje de error
            if (producto == null)
            {
                MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica si hay suficiente stock para las cantidades vendidas
            if (producto.StockS < cantidadVendidaS || producto.StockM < cantidadVendidaM || producto.StockL < cantidadVendidaL || producto.StockXL < cantidadVendidaXL)
            {
                MessageBox.Show("Stock insuficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Reduce el stock de cada talla según las cantidades vendidas
            producto.StockS -= cantidadVendidaS;
            producto.StockM -= cantidadVendidaM;
            producto.StockL -= cantidadVendidaL;
            producto.StockXL -= cantidadVendidaXL;

            // Actualiza el stock en la base de datos
            Productos.ActualizarStock(producto);

            // Calcula el total de la venta y lo muestra en el control total_txt en formato moneda
            decimal total = (cantidadVendidaS + cantidadVendidaM + cantidadVendidaL + cantidadVendidaXL) * (decimal)producto.Precio;
            total_txt.Text = total.ToString("C");

            // Genera el reporte de ventas del mes
            Reportes.GenerarReporteVentasDelMes();

            // Muestra un mensaje indicando que la venta se realizó con éxito
            MessageBox.Show("Venta realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Manejador del evento de hacer clic en el botón de buscar
        private void buscar_btn_Click(object sender, EventArgs e)
        {
            // Obtiene el id del producto
            string idProducto = idProducto_lbl.Text;

            // Si no se ha ingresado un id de producto, muestra un mensaje de error
            if (string.IsNullOrWhiteSpace(idProducto))
            {
                MessageBox.Show("Por favor, ingrese el código del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Busca el producto usando el id ingresado
            Productos producto = Productos.BuscarProductoPorId(Convert.ToInt32(idProducto));

            // Si no se encuentra el producto, muestra un mensaje de error
            if (producto == null)
            {
                MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si se encuentra el producto, carga los datos del producto en los controles de texto
            CargarDatosProducto(producto);
        }

        // Método que carga los datos del producto en los controles de la interfaz
        private void CargarDatosProducto(Productos producto)
        {
            // Asigna el nombre del producto al control de texto nombre_producto_txt
            nombre_producto_txt.Text = producto.Nombre;
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            //Fecha actual
            fecha_txt.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void CalcularTotal()
        {
            // Intenta convertir los valores de las cantidades vendidas de cada talla a enteros
            if (int.TryParse(tallaS_nud.Text, out int cantidadVendidaS) &&
                int.TryParse(tallaM_nud.Text, out int cantidadVendidaM) &&
                int.TryParse(tallaL_nud.Text, out int cantidadVendidaL) &&
                int.TryParse(tallaXL_nud.Text, out int cantidadVendidaXL))
            {
                int idProducto = Convert.ToInt32(idProducto_lbl.Text);
                // Busca el producto en la base de datos por el ID del producto
                Productos producto = Productos.BuscarProductoPorId(idProducto);

                // Si se encuentra el producto
                if (producto != null)
                {
                    // Calcula el total multiplicando las cantidades vendidas por el precio del producto
                    decimal total = (cantidadVendidaS + cantidadVendidaM + cantidadVendidaL + cantidadVendidaXL) * (decimal)producto.Precio;

                    // Muestra el total en el control de texto en formato moneda
                    total_txt.Text = total.ToString("C");
                }
            }
        }

        private void tallaS_nud_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void tallaM_nud_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void tallaL_nud_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void tallaXL_nud_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void volver_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioForm inicioForm = new InicioForm(usuarioActual);
            inicioForm.ShowDialog();
            this.Close();
        }

        private void fecha_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


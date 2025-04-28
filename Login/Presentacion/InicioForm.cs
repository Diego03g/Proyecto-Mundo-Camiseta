using Login.Clases;
using Login.Forms;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// namespace que agrupa las clases relacionadas al login
namespace Login
{
    // definicion del formulario principal llamado InicioForm
    public partial class InicioForm : Form
    {
        // variable privada para almacenar el usuario actual
        private Usuario usuarioActual;

        // constructor del formulario que recibe un objeto usuario
        public InicioForm(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        // evento que se ejecuta cuando el formulario carga
        private void InicioForm_Load(object sender, EventArgs e)
        {
            // mostrar el nombre del usuario en la etiqueta
            nombreuser_lbl.Text = usuarioActual.Nombre;
            // convertir el texto a mayusculas
            nombreuser_lbl.Text.ToUpper();
            // cargar los productos en el datagridview
            CargarProductos();
        }

        // evento que se ejecuta al hacer click en el boton añadir
        private void añadir_btn_Click(object sender, EventArgs e)
        {
            // abrir el formulario para añadir productos
            var productos = new AñadirProductosForm(usuarioActual);
            productos.Show();
            this.Close();
        }

        // metodo para cargar los productos en el datagridview
        private void CargarProductos()
        {
            var productos = Productos.ObtenerProductos();
            Console.WriteLine($"Total productos cargados: {productos.Count}");
            inventario_dv.DataSource = productos;

            // fija altura de fila para imagenes
            inventario_dv.RowTemplate.Height = 100;

            // obtiene la columna Imagen del grid
            var imgCol = (DataGridViewImageColumn)inventario_dv.Columns["Imagen"];

            // ajusta layout para que la imagen mantenga proporcion
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            // define ancho fijo para columna imagen
            imgCol.Width = 100;

        }

        // evento que se ejecuta al hacer click en el boton modificar
        private void modificar_btn_Click(object sender, EventArgs e)
        {
            // abrir el formulario para modificar productos
            var productos = new ModificarProducto(usuarioActual);
            productos.Show();
            this.Close();
        }

        // evento que se ejecuta al hacer click en el boton de cerrar sesion
        private void back_btn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea cerrar sesión?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // volver al formulario de login
                var login = new LoginForm();
                login.Show();
                this.Close();
            }
        }

        // evento que se ejecuta al hacer click en el boton ventas
        private void ventas_btn_Click(object sender, EventArgs e)
        {
            // abrir el formulario de ventas
            var ventas = new VentasForm(usuarioActual);
            ventas.Show();
            this.Close();
        }

        // evento que se ejecuta al hacer click en el boton reportes
        private void reportes_btn_Click(object sender, EventArgs e)
        {
            // generar el reporte de ventas del mes
            List<Venta> ventasDelMes = Reportes.GenerarReporteVentasDelMes();

            if (ventasDelMes.Count == 0)
            {
                // si no hay ventas cambiar el color del boton y mostrar mensaje
                reportes_btn.ForeColor = Color.Red;
                MessageBox.Show("No hay ventas registradas este mes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // si hay ventas restablecer el color del boton
                reportes_btn.ForeColor = Color.Black;

                // exportar las ventas a un archivo excel
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Ventas del Mes");
                    worksheet.Cells[1, 1].Value = "ID";
                    worksheet.Cells[1, 2].Value = "Producto";
                    worksheet.Cells[1, 3].Value = "Cantidad";
                    worksheet.Cells[1, 4].Value = "Precio";
                    worksheet.Cells[1, 5].Value = "Fecha";

                    for (int i = 0; i < ventasDelMes.Count; i++)
                    {
                        worksheet.Cells[i + 2, 1].Value = ventasDelMes[i].IdReporte;
                        worksheet.Cells[i + 2, 2].Value = ventasDelMes[i].NombreCliente;
                        worksheet.Cells[i + 2, 3].Value = ventasDelMes[i].IdProducto;
                        worksheet.Cells[i + 2, 4].Value = ventasDelMes[i].Cantidad;
                        worksheet.Cells[i + 2, 5].Value = ventasDelMes[i].PrecioUnitario;
                        worksheet.Cells[i + 2, 6].Value = ventasDelMes[i].Total;
                        worksheet.Cells[i + 2, 7].Value = ventasDelMes[i].FechaVenta;
                    }

                    var saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel files (*.xlsx)|*.xlsx",
                        FileName = "ReporteVentasDelMes.xlsx"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // guardar el archivo excel en la ruta seleccionada
                        FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                        package.SaveAs(fileInfo);
                        MessageBox.Show("Reporte de ventas del mes exportado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        // evento que se ejecuta al hacer click en el boton eliminar
        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            // abrir el formulario para eliminar productos
            var productos = new EliminarProducto(usuarioActual);
            productos.Show();
            this.Close();
        }

        // evento vacio que se dispara al entrar al groupbox de ventas
        private void ventas_gbox_Enter(object sender, EventArgs e)
        {

        }

        // evento vacio que se dispara al entrar al groupbox de inventario
        private void inventario_gbox_Enter(object sender, EventArgs e)
        {

        }

        // evento vacio que se dispara al hacer click en una celda del datagridview
        private void inventario_dv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


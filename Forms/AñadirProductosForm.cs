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
namespace Login.Forms
{
    public partial class AñadirProductosForm : Form
    {
        public AñadirProductosForm()
        {
            InitializeComponent();
        }

        private void añadir_btn_Click(object sender, EventArgs e)
        {

            string nombre = nombre_producto_txt.Text;
            string marca = textBox1.Text;
            string categoria = categoria_cbox.SelectedItem?.ToString();
            decimal precio;
            int stockS = (int)tallaS_nud.Value;
            int stockM = (int)tallaM_nud.Value;
            int stockL = (int)tallaL_nud.Value;
            int stockXL = (int)tallaXL_nud.Value;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(marca) || string.IsNullOrWhiteSpace(categoria) ||
                !decimal.TryParse(textBox2.Text, out precio))
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (stockS <= 0 && stockM <= 0 && stockL <= 0 && stockXL <= 0)
            {
                MessageBox.Show("Debe haber al menos una talla con stock mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Productos nuevoProducto = new Productos
            {
                Nombre = nombre,
                Marca = marca,
                Categoria = categoria,
                Precio = (double)precio,
                StockS = stockS,
                StockM = stockM,
                StockL = stockL,
                StockXL = stockXL
            };

            Inventarios.AgregarProducto(nuevoProducto);

            MessageBox.Show("Producto registrado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var inicio = new InicioForm();
            inicio.Show();
            this.Close();
        }

        private void volver_btn_Click(object sender, EventArgs e)
        {
            var inicio = new InicioForm();
            inicio.Show();
            this.Close();
        }
    }
}

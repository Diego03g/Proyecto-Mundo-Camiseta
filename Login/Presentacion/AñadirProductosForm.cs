using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Clases;
using Login.Forms;
using System.Collections;
using Login.Logica;

namespace Login.Forms
{
    public partial class AñadirProductosForm : Form
    {
        private Usuario usuarioActual;

        private Boolean Errores = false;
        public AñadirProductosForm(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            tallaS_nud.ValueChanged += tallaS_nud_ValueChanged;
            tallaM_nud.ValueChanged += tallaM_nud_ValueChanged;
            tallaL_nud.ValueChanged += tallaL_nud_ValueChanged;
            tallaXL_nud.ValueChanged += tallaXL_nud_ValueChanged;
        }

        private void añadir_btn_Click(object sender, EventArgs e)
        {

            double precio;
            int stockS = (int)tallaS_nud.Value;
            int stockM = (int)tallaM_nud.Value;
            int stockL = (int)tallaL_nud.Value;
            int stockXL = (int)tallaXL_nud.Value;
            Image imagen = pictureBoxAñadirImg.Image;
            var Logica = new LogicaProducto();
            List<string> Errores = new List<string>();

            if (!Logica.ValidarNombre(nombre_producto_txt.Text))
            {
                Errores.Add("Coloque un Nombre Valido");
                nombre_producto_lbl.ForeColor = Color.DarkRed;
            }

            if (!Logica.ValidarMarca(tbx_Marca.Text))
            {
                Errores.Add("Coloque una Marca Valido");
                marca_lbl.ForeColor = Color.DarkRed;
            }

            if (!Logica.ValidarCategoria(categoria_cbox.Text))
            {
                Errores.Add("Coloque una Categoria Valido");
                categoria_lbl.ForeColor = Color.DarkRed;
            }

            if (!Logica.ValidarPrecio(tbx_precio.Text))
            {
                Errores.Add("Coloque un Precio Valido");
                precio_lbl.ForeColor = Color.DarkRed;
            }
            if (!Logica.ValidarImagen(pictureBoxAñadirImg.Image))
            {
                Errores.Add("Coloque una Imagen Valido");
                imagen_lbl.ForeColor = Color.DarkRed;
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

            Productos nuevoProducto = new Productos
            {
                Nombre = nombre_producto_txt.Text,
                Marca = tbx_Marca.Text,
                Categoria = categoria_cbox.SelectedItem?.ToString(),
                Precio = double.TryParse(tbx_precio.Text, out precio) ? precio : 0,
                StockS = stockS,
                StockM = stockM,
                StockL = stockL,
                StockXL = stockXL,
                Imagen = pictureBoxAñadirImg.Image
            };


            try
            {
                nuevoProducto.AgregarProducto();
                MessageBox.Show("Producto registrado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var inicio = new InicioForm(usuarioActual);
                inicio.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void volver_btn_Click(object sender, EventArgs e)
        {
            var inicio = new InicioForm(usuarioActual);
            inicio.Show();
            this.Close();
        }

        private void CalcularTotal()
        {
            if (decimal.TryParse(tbx_precio.Text, out decimal precio))
            {
                int stockS = (int)tallaS_nud.Value;
                int stockM = (int)tallaM_nud.Value;
                int stockL = (int)tallaL_nud.Value;
                int stockXL = (int)tallaXL_nud.Value;

                decimal total = (stockS + stockM + stockL + stockXL) * precio;
                total_txt.Text = total.ToString("C");
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
        private void btn_añadirimagen_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxAñadirImg_Click(object sender, EventArgs e)
        {
            LogicaProducto producto = new LogicaProducto();
            producto.Imagen = producto.SubirImagenProductos();
            pictureBoxAñadirImg.Image = producto.Imagen;
        }

        private void tbx_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.ValidarSoloDigitos(e.KeyChar);
        }

        private void nombre_producto_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.ValidarSoloLetras(e.KeyChar);
        }

        private void tbx_Marca_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.ValidarSoloLetras(e.KeyChar);
        }
    }
}



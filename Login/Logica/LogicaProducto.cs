using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Clases;

// namespace que contiene la logica relacionada a productos
namespace Login.Logica
{
    // clase que contiene metodos para validar datos de productos
    class LogicaProducto: Productos
    {
        // metodo para validar el nombre del producto
        public Boolean ValidarNombre(string nombre)
        {
            return Validaciones.ValidarString(nombre);
        }

        // metodo para validar la marca del producto
        public Boolean ValidarMarca(string marca)
        {
            return Validaciones.ValidarString(marca);
        }

        // metodo para validar la categoria del producto
        public Boolean ValidarCategoria(string categoria)
        {
            return Validaciones.ValidarString(categoria);
        }

        // metodo para validar el precio del producto
        public Boolean ValidarPrecio(string precio)
        {
            return Validaciones.ValidarDecimalMayorQueCero(precio);
        }

        public Boolean ValidarImagen (Image imagen)
        {
            return Validaciones.ImagenValida(imagen);
        }

        public void SubirImagenProductos()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Seleccione un logo personalizado";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // cargar la imagen seleccionada en el logo
                    string selectedFilePath = openFileDialog.FileName;
                    Productos producto = new Productos();
                    producto.Imagen = Image.FromFile(selectedFilePath);
                    MessageBox.Show("Logo personalizado cargado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

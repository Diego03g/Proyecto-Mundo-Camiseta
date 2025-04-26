using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Clases
{
    class Inventarios: Productos
    {
        private static List<Productos> productos = new List<Productos>();

        public static void AgregarProducto(Productos producto)
        {
            productos.Add(producto);
        }

        public static List<Productos> ObtenerProductos()
        {
            return productos;
        }
    }
}

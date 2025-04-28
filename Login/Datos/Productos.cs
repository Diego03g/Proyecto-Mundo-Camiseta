using LinqToDB;
using LinqToDB.Mapping;
using Login.Datos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace Login.Clases
{
    [Table(Name = "Productos")] //Mapea la tabla Inventario
    public class Productos
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_PRODUCTO")]
        public int Id { get; set; }

        [Column(Name = "Nombre_Producto")]
        public string Nombre { get; set; }

        [Column(Name = "Marca")]
        public string Marca { get; set; }

        [Column(Name = "Categoria")]
        public string Categoria { get; set; }

        [Column(Name = "Precio")]
        public double Precio { get; set; }

        //No existe como columna, solo para manejar en el programa
        public int StockS { get; set; }
        public int StockM { get; set; }
        public int StockL { get; set; }
        public int StockXL { get; set; }

        [Column(Name = "Talla")]
        public string Talla
        {
            get
            {
                return $"S: {StockS}, M: {StockM}, L: {StockL}, XL: {StockXL}";
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    var tallas = value.Split(',').Select(t => t.Split(':').Last().Trim()).ToArray();
                    if (tallas.Length == 4)
                    {
                        StockS = int.Parse(tallas[0]);
                        StockM = int.Parse(tallas[1]);
                        StockL = int.Parse(tallas[2]);
                        StockXL = int.Parse(tallas[3]);
                    }
                }
            }
        }

        [Column(Name = "Imagen")]
        public byte[] ImagenBytes { get; set; }

        //Imagen procesada en memoria
        public Image Imagen
        {
            get
            {
                if (ImagenBytes == null) return null;
                using (var ms = new MemoryStream(ImagenBytes))
                {
                    return Image.FromStream(ms);
                }
            }
            set
            {
                if (value != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        value.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        ImagenBytes = ms.ToArray();
                    }
                }
                else
                {
                    ImagenBytes = null;
                }
            }
        }

        // Metodos de acceso a la base de datos
        private static List<Productos> productos = new List<Productos>();

        // Obtener todos los productos
        public static List<Productos> ObtenerProductos()
        {
            using (var db = new ConexionBD())
            {
                return db.GetTable<Productos>().ToList();
            }
        }

        //Cargar todos los productos
        public static void CargarProductos()
        {
            productos = ObtenerProductos();
        }

        //Agregar un nuevo producto
        public void AgregarProducto()
        {
            using (var db = new ConexionBD())
            {
                db.Insert(this);
            }
        }

        //Actualizar stock (tallas) de un producto
        public static void ActualizarStock(Productos producto)
        {
            using (var db = new ConexionBD())
            {
                db.Update(producto);
            }
        }

        //Modificar todos los datos de un producto
        public static void ModificarProductos(Productos productoActualizado)
        {
            using (var db = new ConexionBD())
            {
                db.Update(productoActualizado);
            }
        }

        //Buscar un producto por ID
        public static Productos BuscarProductoPorId(int idProducto)
        {
            using (var db = new ConexionBD())
            {
                return db.GetTable<Productos>()
                         .FirstOrDefault(p => p.Id == idProducto);
            }
        }

        //Eliminar un producto por ID
        public static bool EliminarProductoPorId(int idProducto)
        {
            using (var db = new ConexionBD())
            {
                var filas = db.GetTable<Productos>()
                              .Where(p => p.Id == idProducto)
                              .Delete();
                return filas > 0; //Si borro al menos una fila
            }
        }
    }
}

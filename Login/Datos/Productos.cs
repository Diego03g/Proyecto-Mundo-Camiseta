using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Clases
{
    class Productos
    {
        // Propiedades básicas del producto
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public int StockS { get; set; }
        public int StockM { get; set; }
        public int StockL { get; set; }
        public int StockXL { get; set; }

        public Image Imagen { get; set; }

        // Lista estática para almacenar productos en memoria
        private static List<Productos> productos = new List<Productos>();

        // Obtiene productos desde la base de datos
        public static List<Productos> ObtenerProductos()
        {
            return ObtenerProductosBD();
        }

        // Método para agregar un producto a la lista y a la base de datos
        public void AgregarProducto()
        {
            productos.Add(this); // Agrega el producto actual a la lista local

            using (SqlConnection conexion = new ConexionBD().GetConnection())
            {
                conexion.Open();
                string query = "INSERT INTO Inventario (Nombre_Producto, Marca, Categoria, Stock_Disponible, Talla, Precio, Imagen) " +
                               "VALUES (@Nombre, @Marca, @Categoria, @Stock, @Talla, @Precio, @Imagen)";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    // Asigna los valores a los parámetros de la consulta
                    comando.Parameters.AddWithValue("@Nombre", this.Nombre);
                    comando.Parameters.AddWithValue("@Marca", this.Marca);
                    comando.Parameters.AddWithValue("@Categoria", this.Categoria);
                    comando.Parameters.AddWithValue("@Stock", this.StockS + this.StockM + this.StockL + this.StockXL);
                    comando.Parameters.AddWithValue("@Talla", "S: " + this.StockS + ", M: " + this.StockM + ", L: " + this.StockL + ", XL: " + this.StockXL);
                    comando.Parameters.AddWithValue("@Precio", this.Precio);
                    // convertir la imagen a un arreglo de bytes
                    byte[] imgBytes = null;
                    if (this.Imagen != null)
                    {
                        using (var ms = new MemoryStream())
                        {
                            // guardamos en PNG (puedes usar Jpeg o BMP si prefieres)
                            this.Imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            imgBytes = ms.ToArray();
                        }
                    }

                    // y luego al parámetro
                    if (imgBytes != null)
                        comando.Parameters.AddWithValue("@Imagen", imgBytes);
                    else
                        comando.Parameters.AddWithValue("@Imagen", DBNull.Value);
                    comando.ExecuteNonQuery(); // Ejecuta la consulta de inserción
                }
            }
        }

        // Actualiza las tallas del producto en la base de datos
        public static void ActualizarStock(Productos producto)
        {
            using (SqlConnection conexion = new ConexionBD().GetConnection())
            {
                conexion.Open();
                string query = "UPDATE Inventario SET Talla = @Talla WHERE ID_PRODUCTO = @Id";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    string tallas = $"S: {producto.StockS}, M: {producto.StockM}, L: {producto.StockL}, XL: {producto.StockXL}";

                    comando.Parameters.AddWithValue("@Talla", tallas);
                    comando.Parameters.AddWithValue("@Id", producto.Id);

                    comando.ExecuteNonQuery(); // Ejecuta la actualización
                }
            }
        }

        // Carga productos desde la base de datos y los convierte en objetos
        private static List<Productos> ObtenerProductosBD()
        {
            List<Productos> listaProductos = new List<Productos>();

            using (SqlConnection conexion = new ConexionBD().GetConnection())
            {
                conexion.Open();
                string query = "SELECT ID_PRODUCTO, Nombre_Producto, Marca, Categoria, Precio, Talla, Imagen FROM Inventario";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Productos producto = new Productos();
                            try
                            {
                                // Asignación de datos del producto desde la base de datos
                                producto.Id = reader.GetInt32(0);
                                producto.Nombre = reader.GetString(1);
                                producto.Marca = reader.GetString(2);
                                producto.Categoria = reader.GetString(3);
                                producto.Precio = reader.IsDBNull(4) ? 0.0 : (double)reader.GetDecimal(4);
                                
                                if (!reader.IsDBNull(6))
                                {
                                    byte[] imgBytes = (byte[])reader.GetValue(6);
                                    using (var ms = new MemoryStream(imgBytes))
                                    {
                                        producto.Imagen = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    producto.Imagen = null; // o imagen por defecto
                                }


                                // Leer tallas como string y dividirlo para separar cantidades
                                string talla = reader.GetString(5);
                                var tallas = talla.Split(',').Select(t => t.Split(':').Last().Trim()).ToArray();
                                producto.StockS = int.Parse(tallas[0]);
                                producto.StockM = int.Parse(tallas[1]);
                                producto.StockL = int.Parse(tallas[2]);
                                producto.StockXL = int.Parse(tallas[3]);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error al leer producto: {ex.Message}");
                                continue;
                            }
                            listaProductos.Add(producto); // Agrega el producto leído a la lista
                        }
                    }
                }
            }

            Console.WriteLine($"Total productos obtenidos: {listaProductos.Count}");
            return listaProductos;
        }

        // Carga productos del inventario a la lista local
        public static void CargarProductos()
        {
            using (SqlConnection conexion = new ConexionBD().GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Inventario";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Productos producto = new Productos
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Marca = reader.GetString(2),
                                Categoria = reader.GetString(3),
                                Precio = reader.IsDBNull(5) ? 0.0 : (double.TryParse(reader[5].ToString(), out double precio) ? precio : 0.0),
                                StockS = reader.GetInt32(4),
                                StockM = reader.GetInt32(4),
                                StockL = reader.GetInt32(4),
                                StockXL = reader.GetInt32(4)
                                
                            };
                            // Leer la imagen si existe (columna Imagen en el índice 6)
                            if (!reader.IsDBNull(6))
                            {
                                byte[] imgBytes = (byte[])reader.GetValue(6);
                                using (var ms = new MemoryStream(imgBytes))
                                {
                                    producto.Imagen = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                producto.Imagen = null; // o asigna una imagen por defecto
                            }

                            productos.Add(producto); // Agrega el producto a la lista en memoria
                        }
                    }
                }
            }
        }

        // Modifica los datos de un producto existente
        public static void ModificarProductos(Productos productoActual)
        {
            using (SqlConnection conexion = new ConexionBD().GetConnection())
            {
                conexion.Open();
                string query = "UPDATE Inventario SET Nombre_Producto = @Nombre, Marca = @Marca, Categoria = @Categoria, Stock_Disponible = @Stock, Talla = @Talla, Precio = @Precio, @Imagen WHERE ID_PRODUCTO = @Id";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    // Actualiza todos los campos necesarios del producto
                    comando.Parameters.AddWithValue("@Nombre", productoActual.Nombre);
                    comando.Parameters.AddWithValue("@Marca", productoActual.Marca);
                    comando.Parameters.AddWithValue("@Categoria", productoActual.Categoria);
                    comando.Parameters.AddWithValue("@Stock", productoActual.StockS + productoActual.StockM + productoActual.StockL + productoActual.StockXL);
                    comando.Parameters.AddWithValue("@Talla", "S: " + productoActual.StockS + ", M: " + productoActual.StockM + ", L: " + productoActual.StockL + ", XL: " + productoActual.StockXL);
                    comando.Parameters.AddWithValue("@Precio", productoActual.Precio);
                    comando.Parameters.AddWithValue("@Id", productoActual.Id);
                    // convertir imagen a byte[] o enviar DBNull
                    byte[] imgBytes = null;
                    if (productoActual.Imagen != null)
                    {
                        using (var ms = new MemoryStream())
                        {
                            productoActual.Imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            imgBytes = ms.ToArray();
                        }
                    }

                    if (imgBytes != null)
                        comando.Parameters.AddWithValue("@Imagen", imgBytes);
                    else
                        comando.Parameters.AddWithValue("@Imagen", DBNull.Value);

                    comando.ExecuteNonQuery();

                    comando.ExecuteNonQuery(); // Ejecuta la actualización
                }
            }
        }

        // Busca un producto en base a su ID
        public static Productos BuscarProductoPorId(string idProducto)
        {
            using (SqlConnection conexion = new ConexionBD().GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Inventario WHERE ID_PRODUCTO = @Id";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", idProducto);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retorna el producto encontrado
                            return new Productos
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Marca = reader.GetString(2),
                                Categoria = reader.GetString(3),
                                Precio = reader.IsDBNull(5) ? 0.0 : (double.TryParse(reader[5].ToString(), out double precio) ? precio : 0.0),
                                StockS = reader.GetInt32(4),
                                StockM = reader.GetInt32(4),
                                StockL = reader.GetInt32(4),
                                StockXL = reader.GetInt32(4),

                            };

                            var producto = new Productos();

                            // Leer imagen si existe (columna Imagen en indice 6)
                            int idxImagen = 6;
                            if (!reader.IsDBNull(idxImagen))
                            {
                                byte[] imgBytes = (byte[])reader.GetValue(idxImagen);
                                using (var ms = new MemoryStream(imgBytes))
                                {
                                    producto.Imagen = Image.FromStream(ms);
                                }
                            }

                            return producto;
                        }
                    }
                }
            }
            return null; // Si no encuentra el producto, retorna null
        }

        // Elimina un producto de la base de datos por su ID
        public static bool EliminarProductoPorId(string idProducto)
        {
            using (SqlConnection conexion = new ConexionBD().GetConnection())
            {
                conexion.Open();
                string query = "DELETE FROM Inventario WHERE ID_PRODUCTO = @Id";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", idProducto);
                    int rowsAffected = comando.ExecuteNonQuery();

                    // Si afectó al menos una fila, se eliminó el producto
                    return rowsAffected > 0;
                }
            }
        }
    }
}

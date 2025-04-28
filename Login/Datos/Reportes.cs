using LinqToDB;
using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Login.Clases
{
    class Reportes
    {
        //Metodo para generar un reporte de ventas del mes actual
        public static List<Venta> GenerarReporteVentasDelMes()
        {
            using (var db = new AppDataConnection()) // Crea una conexion a la base de datos
            {
                //Obtiene todas las ventas donde el mes y el anio coincidan con la fecha actual
                var ventasDelMes = db.GetTable<Venta>()
                    .Where(v => v.FechaVenta.Month == DateTime.Now.Month &&
                                v.FechaVenta.Year == DateTime.Now.Year)
                    .ToList(); //Convierte el resultado en una lista

                return ventasDelMes; //Devuelve la lista de ventas
            }
        }
    }

    //Clase que representa una venta
    [Table(Name = "Reportes_Venta")] // Mapea la clase a la tabla Reportes_Venta
    public class Venta
    {
        [Column(Name = "ID_REPORTE"), PrimaryKey, Identity] //Llave primaria con identidad
        public int IdReporte { get; set; }

        [Column(Name = "Nombre_Cliente")] //Nombre del cliente
        public string NombreCliente { get; set; }

        [Column(Name = "ID_PRODUCTO")] //ID del producto vendido
        public int IdProducto { get; set; }

        [Column(Name = "Cantidad")] //Cantidad de productos vendidos
        public int Cantidad { get; set; }

        [Column(Name = "Precio_Unitario")] //Precio unitario del producto
        public decimal PrecioUnitario { get; set; }

        [Column(Name = "Total")] //Total de la venta
        public decimal Total { get; set; }

        [Column(Name = "Fecha_Venta")] //Fecha en que se realizo la venta
        public DateTime FechaVenta { get; set; }
    }
}

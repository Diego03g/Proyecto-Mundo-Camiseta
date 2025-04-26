using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Login.Clases
{
    class Reportes
    {
        public static List<Venta> GenerarReporteVentasDelMes()
        {
            List<Venta> ventasDelMes = new List<Venta>();

            using (SqlConnection conexion = new ConexionBD().GetConnection())
            {
                conexion.Open();
                string query = "SELECT * FROM Reportes_Venta WHERE MONTH(Fecha_Venta) = MONTH(GETDATE()) AND YEAR(Fecha_Venta) = YEAR(GETDATE())";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Venta venta = new Venta
                            {
                                IdReporte = reader.GetInt32(0),
                                NombreCliente = reader.GetString(1),
                                IdProducto = reader.GetInt32(2),
                                Cantidad = reader.GetInt32(3),
                                PrecioUnitario = reader.GetDecimal(4),
                                Total = reader.GetDecimal(5),
                                FechaVenta = reader.GetDateTime(6)
                            };
                            ventasDelMes.Add(venta);
                        }
                    }
                }
            }

            return ventasDelMes;
        }
    }

    public class Venta
    {
        public int IdReporte { get; set; }
        public string NombreCliente { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaVenta { get; set; }
    }
}

using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Data;
using Login.Clases;

namespace Login.Datos
{
    public class ConexionBD : DataConnection
    {
        public ConexionBD() : base("conexionBD") // Nombre de la conexión en App.config
        {
        }

        public ITable<Usuario> Usuarios => this.GetTable<Usuario>();
        public ITable<Productos> Productos => this.GetTable<Productos>();
        public ITable<Venta> Reportes_Venta => this.GetTable<Venta>();
    }
}

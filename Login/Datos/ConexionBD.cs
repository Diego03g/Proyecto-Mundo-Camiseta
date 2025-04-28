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

        // Puedes agregar tablas como propiedades para facilitar el acceso
        public ITable<Usuario> Usuarios => GetTable<Usuario>();
        public ITable<Productos> Productos => GetTable<Productos>();
        public ITable<Reportes> Reportes => GetTable<Reportes>();
    }

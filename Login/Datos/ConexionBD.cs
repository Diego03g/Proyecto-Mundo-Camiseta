using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Clases
{
    class ConexionBD
    {
            private string connectionString = "Server=.\\SQLEXPRESS;Database=BD_Inventario;Integrated Security=True;";
            public SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        
    }
}

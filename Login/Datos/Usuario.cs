using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Clases
{
    public class Usuario
    {
        // Propiedades del usuario
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contraseña { get; set; }

        // Lista para almacenar usuarios en memoria
        private static List<Usuario> usuarios = new List<Usuario>();

        // Metodo para registrar un nuevo usuario
        public static bool Registrar(string nombre, string apellidos, string correoElectronico, string contraseña)
        {
            // Comprobar si ya existe un usuario con el mismo correo
            if (usuarios.Any(u => u.CorreoElectronico == correoElectronico))
            {
                return false; // Si existe, devuelve falso
            }

            // Si no existe, agrega el nuevo usuario a la lista
            usuarios.Add(new Usuario { Nombre = nombre, Apellidos = apellidos, CorreoElectronico = correoElectronico, Contraseña = contraseña });

            // Llama al metodo para guardar el usuario en la base de datos
            RegistrarUsuarioBD(nombre, apellidos, correoElectronico, contraseña);

            return true; // Devuelve verdadero si el registro es exitoso
        }

        // Metodo asyncrono para verificar las credenciales de un usuario
        public static async Task<Usuario> VerificarCredencialesAsync(string correoElectronico, string contraseña)
        {
            using (SqlConnection conexion = new ConexionBD().GetConnection()) // Crea una conexion a la base de datos
            {
                conexion.Open(); // Abre la conexion

                // Consulta SQL para verificar si las credenciales coinciden
                string query = "SELECT * FROM Usuarios WHERE Correo_Electronico = @CorreoElectronico AND Contraseña = @Contraseña";

                using (SqlCommand comando = new SqlCommand(query, conexion)) // Crea un comando con la consulta
                {
                    // Agrega los parametros de correo y contraseña a la consulta
                    comando.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);
                    comando.Parameters.AddWithValue("@Contraseña", contraseña);

                    // Ejecuta la consulta y lee los resultados
                    using (SqlDataReader reader = await comando.ExecuteReaderAsync())
                    {
                        if (reader.Read()) // Si encuentra un usuario
                        {
                            // Devuelve un nuevo objeto Usuario con los datos encontrados
                            return new Usuario
                            {
                                Nombre = reader["Nombre"].ToString(),
                                Apellidos = reader["Apellidos"].ToString(),
                                CorreoElectronico = reader["Correo_Electronico"].ToString(),
                                Contraseña = reader["Contraseña"].ToString()
                            };
                        }
                        else
                        {
                            return null; // Si no se encuentra el usuario, devuelve null
                        }
                    }
                }
            }
        }

        // Metodo para registrar un usuario en la base de datos
        private static void RegistrarUsuarioBD(string nombre, string apellidos, string correoElectronico, string contraseña)
        {
            using (SqlConnection conexion = new ConexionBD().GetConnection()) // Crea una conexion a la base de datos
            {
                conexion.Open(); // Abre la conexion

                // Consulta SQL para insertar el nuevo usuario en la base de datos
                string query = "INSERT INTO Usuarios (Nombre, Apellidos, Correo_Electronico, Contraseña) VALUES (@Nombre, @Apellidos, @CorreoElectronico, @Contraseña)";

                using (SqlCommand comando = new SqlCommand(query, conexion)) // Crea un comando con la consulta
                {
                    // Agrega los parametros de los datos del usuario
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Apellidos", apellidos);
                    comando.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);
                    comando.Parameters.AddWithValue("@Contraseña", contraseña);

                    comando.ExecuteNonQuery(); // Ejecuta la consulta para insertar el usuario
                }
            }
        }
    }
}


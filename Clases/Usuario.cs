using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Clases
{
    public class Usuario
    {
        public string Email { get; set; }
        public string Password { get; set; }

        private static List<Usuario> usuarios = new List<Usuario>();

        public static bool Registrar(string email, string password)
        {
            if (usuarios.Any(u => u.Email == email))
            {
                return false; // El usuario ya existe
            }

            usuarios.Add(new Usuario { Email = email, Password = password });
            return true;
        }

        public static bool VerificarCredenciales(string email, string password)
        {
            return usuarios.Any(u => u.Email == email && u.Password == password);
        }
    }
}

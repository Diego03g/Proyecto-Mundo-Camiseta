﻿using LinqToDB;
using LinqToDB.Mapping;
using Login.Datos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Clases
{
    [Table(Name = "Usuarios")]
    public class Usuario
    {
        // Propiedades del usuario
        [Column(Name = "Nombre")]
        public string Nombre { get; set; }

        [Column(Name = "Apellidos")]
        public string Apellidos { get; set; }

        [Column(Name = "Correo_Electronico"), PrimaryKey]
        public string CorreoElectronico { get; set; }

        [Column(Name = "Contraseña")]
        public string Contraseña { get; set; }

        // Lista para almacenar usuarios en memoria
        private static List<Usuario> usuarios = new List<Usuario>();

        // Metodo para registrar un nuevo usuario
        public bool Registrar()
        {
            // Comprobar si ya existe un usuario en memoria
            if (usuarios.Any(u => u.CorreoElectronico == this.CorreoElectronico))
            {
                return false; // Si existe en la lista local, devuelve falso
            }

            // Agrega el nuevo usuario en la lista local
            usuarios.Add(new Usuario { Nombre = this.Nombre, Apellidos = this.Apellidos, CorreoElectronico = this.CorreoElectronico, Contraseña = this.Contraseña });

            // Llama al metodo para guardar en base de datos
            RegistrarUsuarioBD();

            return true; // Registro exitoso
        }

        // Metodo asíncrono para verificar las credenciales de un usuario
        public static async Task<Usuario> VerificarCredencialesAsync(string correoElectronico, string contraseña)
        {
            using (var db = new ConexionBD())
            {
                var usuario = await db.GetTable<Usuario>()
                    .Where(u => u.CorreoElectronico == correoElectronico && u.Contraseña == contraseña)
                    .FirstOrDefaultAsync();

                return usuario; // Devuelve el usuario encontrado o null
            }
        }

        // Metodo para registrar un usuario en la base de datos
        private void RegistrarUsuarioBD()
        {
            using (var db = new ConexionBD())
            {
                var nuevoUsuario = new Usuario
                {
                    Nombre = this.Nombre,
                    Apellidos = this.Apellidos,
                    CorreoElectronico = this.CorreoElectronico,
                    Contraseña = this.Contraseña
                };

                db.Insert(nuevoUsuario);
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.Clases;
using System.Windows.Forms;


// namespace que contiene la logica relacionada a productos
namespace Login.Logica
{
    // clase que contiene metodos para validar datos de productos
    class LogicaRegistro
    {
            // metodo para validar el nombre del producto
            public Boolean ValidarNombre(string nombre)
            {
                return Validaciones.ValidarString(nombre);
            }

            // metodo para validar la marca del producto
            public Boolean ValidarApellido(string apellido)
            {
                return Validaciones.ValidarString(apellido);
            }

            // metodo para validar la categoria del producto
            public Boolean ValidarEmail(string email)
            {
                return Validaciones.ValidarEmail(email);
            }

            // metodo para validar el precio del producto
            public Boolean ValidarContraseña(string contraseña)
            {
                return Validaciones.ValidarString(contraseña);
            }
        //Validar Confirmacion de contraseña
        public Boolean ValidarConfirmacionContraseña(string contraseña, string confirmacionContraseña)
        {
            if (contraseña != confirmacionContraseña)
            {
                return false;
            }
            return true;
        }
    }
}


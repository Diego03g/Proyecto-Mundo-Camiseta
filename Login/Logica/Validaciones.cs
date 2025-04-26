using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

// namespace que contiene clases de validaciones
namespace Login.Clases
{
    // clase que contiene metodos estaticos para validar datos
    class Validaciones
    {
        // metodo para validar si un string es un correo electronico valido
        public static Boolean ValidarEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // metodo para validar si un string no esta vacio ni solo espacios
        public static Boolean ValidarString(string cadena)
        {
            if (string.IsNullOrWhiteSpace(cadena))
            {
                return false;
            }
            return true;
        }

        // metodo para validar si un string representa un numero decimal mayor que cero
        public static Boolean ValidarDecimalMayorQueCero(string numeroString)
        {
            if (EsNumero(numeroString))
            {
                Decimal numero = Convert.ToDecimal(numeroString);
                if (numero > 0)
                {
                    return true;
                }
            }
            return false;
        }

        // metodo para validar si un string es un numero decimal
        public static Boolean EsNumero(string s)
        {
            return decimal.TryParse(s, out var value);
        }

        // Valida que la imagen no sea nula tenga dimensiones validas y sea formato comun
        public static Boolean ImagenValida(Image imagen)
        {
            // Verificar que la imagen exista
            if (imagen == null)
                return false;

            // Verificar dimensiones positivas
            if (imagen.Width <= 0 || imagen.Height <= 0)
                return false;

            // Verificar formatos permitidos JPEG PNG BMP
            var rawFormat = imagen.RawFormat;
            if (rawFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg) ||
                rawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png) ||
                rawFormat.Equals(System.Drawing.Imaging.ImageFormat.Bmp))
            {
                return true;
            }

            // Si no cumple ningun criterio
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Clases
{
    class Productos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public int StockS { get; set; }
        public int StockM { get; set; }
        public int StockL { get; set; }
        public int StockXL { get; set; }
    }
}

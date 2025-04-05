using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class ProductoEntity
    {
        public int cod_productos { get; set; } // Clave primaria
        public string nombre_producto { get; set; }
        public int precio_producto { get; set; }
        public string descripcion_producto { get; set; }
        public int stock { get; set; }
    }
}

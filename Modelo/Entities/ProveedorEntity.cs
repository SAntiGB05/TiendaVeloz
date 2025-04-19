using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class ProveedorEntity
    {
        public int Id { get; set; }
        public int nit_proveedor { get; set; }
        public string nombre_proveedor { get; set; }
        public string direccion_proveedor { get; set; }
        public string telefono_proveedor { get; set; }
    }
}

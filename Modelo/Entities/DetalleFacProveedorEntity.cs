using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class DetalleFacturaProveedorEntity
    {
        public int cod_detalle_fac_proveedor { get; set; }
        public int FKcod_factura_proveedor { get; set; }
        public int FKcod_producto { get; set; }
        public int cantidad { get; set; }
        public decimal precio_unitario { get; set; }
        public decimal precio_total { get; set; }
    }
}

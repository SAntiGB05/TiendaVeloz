using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class FacturaProveedorEntity
    {
        public int cod_factura_proveedor { get; set; }
        public int FKcod_proveedor { get; set; }
        public DateTime fecha_fac_proveedor { get; set; }

        public List<DetalleFacturaProveedorEntity> DetallesFactura { get; set; }

        public FacturaProveedorEntity()
        {
            DetallesFactura = new List<DetalleFacturaProveedorEntity>();
        }
    }
}

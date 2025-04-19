using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class FacturaClienteEntity
    {
        public int cod_factura_cliente { get; set; }
        public int FKid_cliente { get; set; }        
        public int FKid_empleado { get; set; }    
        public DateTime fecha_fac_cliente { get; set; }  

        public List<DetalleFacturaClienteEntity> DetallesFactura { get; set; }

        public FacturaClienteEntity()
        {
            DetallesFactura = new List<DetalleFacturaClienteEntity>();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entities;
using Modelo;

namespace Logica
{
    public class FacturaProveedorControler
    {
        public string GuardarFacturaProveedorConDetalles(int FKcod_proveedor, DateTime fecha, List<DetalleFacturaProveedorEntity> detalles)
        {
            BaseDatos db = new BaseDatos();
            int idFactura = db.GuardarFacturaProveedorConDetalles(FKcod_proveedor, fecha, detalles);
            return idFactura > 0 ? "Factura y detalles guardados correctamente." : "Error al guardar.";
        }

        public List<FacturaProveedorEntity> MostrarFacturasProveedor()
        {
            BaseDatos db = new BaseDatos();
            return db.MostrarFacturasProveedor();
        }

        public string ActualizarFacturaProveedor(FacturaProveedorEntity facturaProveedorActualizada)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            bool facturaProveedorActualizadaExitosamente = db.ActualizarFacturaProveedor(facturaProveedorActualizada);

            if (facturaProveedorActualizadaExitosamente)
            {
                resultado = "Factura de Proveedor Actualizada";
            }
            else
            {
                resultado = "No se pudo actualizar la Factura de Proveedor";
            }

            return resultado;
        }

        public string EliminarFacturaProveedor(int codFacturaProveedor)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            bool facturaProveedorEliminada = db.EliminarFacturaProveedor(codFacturaProveedor);

            if (facturaProveedorEliminada)
            {
                resultado = "Factura de Proveedor Eliminada";
            }
            else
            {
                resultado = "No se pudo eliminar la Factura de Proveedor";
            }

            return resultado;
        }
    }
}
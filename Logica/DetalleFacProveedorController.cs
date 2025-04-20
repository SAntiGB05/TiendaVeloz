using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entities;
using Modelo;

namespace Logica
{
    public class DetalleFacturaProveedorControler
    {
        public string GuardarFacturaProveedorConDetalles(int FKcod_proveedor, DateTime fecha, List<DetalleFacturaProveedorEntity> detalles)
        {
            BaseDatos db = new BaseDatos();
            int idFactura = db.GuardarFacturaProveedorConDetalles(FKcod_proveedor, fecha, detalles);
            return idFactura > 0 ? "Factura y detalles guardados correctamente." : "Error al guardar.";
        }

        public List<DetalleFacturaProveedorEntity> MostrarDetallesFacturaProveedor()
        {
            BaseDatos db = new BaseDatos();
            return db.MostrarDetalleFacProveedor();
        }

        public string ActualizarDetalleFacturaProveedor(DetalleFacturaProveedorEntity detalleActualizado)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            bool actualizado = db.ActualizarDetalleFacProveedor(detalleActualizado);

            if (actualizado)
            {
                resultado = "Detalle de Factura de Proveedor Actualizado";
            }
            else
            {
                resultado = "No se pudo actualizar el Detalle de Factura de Proveedor";
            }

            return resultado;
        }

        public string EliminarDetalleFacturaProveedor(int codDetalle)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            bool eliminado = db.EliminarDetalleFacProveedor(codDetalle);

            if (eliminado)
            {
                resultado = "Detalle de Factura de Proveedor Eliminado";
            }
            else
            {
                resultado = "No se pudo eliminar el Detalle de Factura de Proveedor";
            }

            return resultado;
        }
    }
}
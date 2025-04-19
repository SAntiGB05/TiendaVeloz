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
        public string GuardarDetalleFacturaProveedor(int cantidad, decimal precio_unitario, decimal precio_total,
                                                   int FKcod_factura_proveedor, int FKcod_producto)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasInsertadas = db.GuardarDetalleFacProveedor(new DetalleFacturaProveedorEntity
            {
                cantidad = cantidad,
                precio_unitario = precio_unitario,
                precio_total = precio_total,
                FKcod_factura_proveedor = FKcod_factura_proveedor,
                FKcod_producto = FKcod_producto
            });

            if (filasInsertadas > 0)
            {
                resultado = "Detalle de Factura de Proveedor Guardado";
            }
            else
            {
                resultado = "No se pudo guardar el Detalle de Factura de Proveedor";
            }
            return resultado;
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
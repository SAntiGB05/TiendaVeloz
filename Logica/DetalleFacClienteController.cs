using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entities;
using Modelo;

namespace Logica
{
    public class DetalleFacturaClienteControler
    {
        public string GuardarDetalleFacturaCliente(int cantidad, decimal precio_unitario, decimal precio_total,
                                                 int FKcod_factura_cliente, int FKcod_producto)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasInsertadas = db.GuardarDetalleFacCliente(new DetalleFacturaClienteEntity
            {
                cantidad = cantidad,
                precio_unitario = precio_unitario,
                precio_total = precio_total,
                FKcod_factura_cliente = FKcod_factura_cliente,
                FKcod_producto = FKcod_producto
            });

            if (filasInsertadas > 0)
            {
                resultado = "Detalle de Factura de Cliente Guardado";
            }
            else
            {
                resultado = "No se pudo guardar el Detalle de Factura de Cliente";
            }
            return resultado;
        }

        public List<DetalleFacturaClienteEntity> MostrarDetallesFacturaCliente()
        {
            BaseDatos db = new BaseDatos();
            return db.MostrarDetalleFacCliente();
        }

        public string ActualizarDetalleFacturaCliente(DetalleFacturaClienteEntity detalleActualizado)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            bool actualizado = db.ActualizarDetalleFacCliente(detalleActualizado);

            if (actualizado)
            {
                resultado = "Detalle de Factura de Cliente Actualizado";
            }
            else
            {
                resultado = "No se pudo actualizar el Detalle de Factura de Cliente";
            }

            return resultado;
        }

        public string EliminarDetalleFacturaCliente(int codDetalle)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            bool eliminado = db.EliminarDetalleFacCliente(codDetalle);

            if (eliminado)
            {
                resultado = "Detalle de Factura de Cliente Eliminado";
            }
            else
            {
                resultado = "No se pudo eliminar el Detalle de Factura de Cliente";
            }

            return resultado;
        }
    }
}
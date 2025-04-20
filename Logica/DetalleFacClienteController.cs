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
        public string GuardarFacturaClienteConDetalles(int FKid_cliente, int FKid_empleado, DateTime fecha, List<DetalleFacturaClienteEntity> detalles)
        {
            BaseDatos db = new BaseDatos();
            int idFactura = db.GuardarFacturaClienteConDetalles(FKid_cliente, FKid_empleado, fecha, detalles);
            return idFactura > 0 ? "Factura guardada con éxito (ID: " + idFactura + ")" : "Error al guardar";
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
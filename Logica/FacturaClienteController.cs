using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entities;
using Modelo;

namespace Logica
{
    public class FacturaClienteControler
    {
        public string GuardarFacturaClienteConDetalles(int FKid_cliente, int FKid_empleado, DateTime fecha, List<DetalleFacturaClienteEntity> detalles)
        {
            BaseDatos db = new BaseDatos();
            int idFactura = db.GuardarFacturaClienteConDetalles(FKid_cliente, FKid_empleado, fecha, detalles);
            return idFactura > 0 ? "Factura guardada con éxito (ID: " + idFactura + ")" : "Error al guardar";
        }

        public List<FacturaClienteEntity> MostrarFacturasCliente()
        {
            BaseDatos db = new BaseDatos();
            return db.MostrarFacturasCliente();
        }

        public string ActualizarFacturaCliente(FacturaClienteEntity facturaClienteActualizada)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            bool facturaClienteActualizadaExitosamente = db.ActualizarFacturaCliente(facturaClienteActualizada);

            if (facturaClienteActualizadaExitosamente)
            {
                resultado = "Factura de Cliente Actualizada";
            }
            else
            {
                resultado = "No se pudo actualizar la Factura de Cliente";
            }

            return resultado;
        }

        public string EliminarFacturaCliente(int codFacturaCliente)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            bool facturaClienteEliminada = db.EliminarFacturaCliente(codFacturaCliente);

            if (facturaClienteEliminada)
            {
                resultado = "Factura de Cliente Eliminada";
            }
            else
            {
                resultado = "No se pudo eliminar la Factura de Cliente";
            }

            return resultado;
        }
    }
}
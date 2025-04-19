using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.Entities;

namespace Logica
{
    public class ProveedorControler
    {

        public string GuardarProveedor(int nit_proveedor, string nombre_proveedor,string direccion_proeedor, string telefono_proveedor)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasInsertadas = db.GuardarProveedor(nit_proveedor, nombre_proveedor, direccion_proeedor, telefono_proveedor);

            if (filasInsertadas > 0)
            {
                resultado = "Guardado";
            }
            else
            {
                resultado = "No Guardado";
            }
            return resultado;
        }

        public List<ProveedorEntity> MostrarProveedor()
        {
            BaseDatos db = new BaseDatos();
            return db.MostrarProveedor();
        }


        public string ActualizarProveedor(ProveedorEntity proveedorActualizado)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            bool prveedorActualizadoExitosamente = db.ActualizarProveedor(proveedorActualizado);

            if (prveedorActualizadoExitosamente)
            {
                resultado = "Proveedor Actualizado";
            }
            else
            {
                resultado = "No se pudo actualizar el proveedor";
            }

            return resultado;
        }

        public string EliminarProveedor(int nit_proveedor)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            bool proveedorEliminado = db.EliminarProveedor(nit_proveedor);

            if (proveedorEliminado)
            {
                resultado = "Proveedor Eliminado";
            }
            else
            {
                resultado = "No se pudo eliminar el proveedor";
            }

            return resultado;
        }
    }





}

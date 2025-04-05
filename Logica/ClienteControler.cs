using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.Entities;

namespace Logica
{
    public class ClienteControler
    {

        public string GuardarCliente(int cedula_nit_cliente, string nombre_cliente, string telefono_cliente)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasInsertadas = db.GuardarCliente (cedula_nit_cliente,nombre_cliente,telefono_cliente);

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

        public List<ClienteEntity> MostrarClientes()
        {
            BaseDatos db = new BaseDatos();
            return db.MostrarClientes();
        }


        public string ActualizarCliente(ClienteEntity clienteActualizado)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            bool clienteActualizadoExitosamente = db.ActualizarCliente(clienteActualizado);

            if (clienteActualizadoExitosamente)
            {
                resultado = "Cliente Actualizado";
            }
            else
            {
                resultado = "No se pudo actualizar el cliente";
            }

            return resultado;
        }

        public string EliminarCliente(int cedula_nit_cliente)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            bool clienteEliminado = db.EliminarCliente(cedula_nit_cliente);

            if (clienteEliminado)
            {
                resultado = "Cliente Eliminado";
            }
            else
            {
                resultado = "No se pudo eliminar el cliente";
            }

            return resultado;
        }
    }
  
        

      
    
}

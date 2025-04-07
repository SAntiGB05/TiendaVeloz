using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.Entities;

namespace Logica
{
    public class EmpleadoControler
    {

        public string GuardarEmpleado(int cedula_empleado, string nombre_empleado, string telefono_empleado, string rol_empleado, int pin_acceso)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasInsertadas = db.GuardarEmpleado(cedula_empleado, nombre_empleado, telefono_empleado, rol_empleado, pin_acceso);

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

        public List<EmpleadoEntity> MostrarEmpleado()
        {
            BaseDatos db = new BaseDatos();
            return db.MostrarEmpleado();
        }


        public string ActualizarEmpleado(EmpleadoEntity empleadoActualizado)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            bool empleadoActualizadoExitosamente = db.ActualizarEmpleado(empleadoActualizado);

            if (empleadoActualizadoExitosamente)
            {
                resultado = "Empleado Actualizado";
            }
            else
            {
                resultado = "No se pudo actualizar el empleado";
            }

            return resultado;
        }

        public string EliminarEmpleado(int cedula_empleado)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            bool empleadoEliminado = db.EliminarEmpleado(cedula_empleado);

            if (empleadoEliminado)
            {
                resultado = "Empleado Eliminado";
            }
            else
            {
                resultado = "No se pudo eliminar el empleado";
            }

            return resultado;
        }
    }





}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class EmpleadoEntity
    {
        public int Id { get; set; }
        public int cedula_empleado { get; set; }
        public string nombre_empleado { get; set; }
        public string telefono_empleado { get; set; }
        public string rol_empleado { get; set; }
        public int pin_acceso { get; set; }
    }
}

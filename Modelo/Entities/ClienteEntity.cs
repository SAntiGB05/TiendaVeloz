﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class ClienteEntity
    {
        public int Id { get; set; }
        public int cedula_nit_cliente { get; set; }
        public string nombre_cliente { get; set; }
        public string telefono_cliente { get; set; }
    }
}

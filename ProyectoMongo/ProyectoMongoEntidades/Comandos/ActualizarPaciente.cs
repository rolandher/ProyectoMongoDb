﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMongoEntidades.Comandos
{
    public class ActualizarPaciente
    {
        public string Nombre { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Sexo { get; set; }
    }

}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calificacion
    {
        public int IdCalificacion { get; set; }
        public Curricula oCurricula { get; set; }
        public Alumno oAlumno { get; set; }
        public float Nota { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Matricula
    {
        public int IdMatricula { get; set; }
        public Alumno oAlumno { get; set; }
        public NivelDetalle oNivelDetalle { get; set; }
    }
}

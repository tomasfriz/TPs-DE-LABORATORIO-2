using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DocenteCurso
    {
        public int IdDocenteCurso { get; set; }
        public NivelDetalleCurso oNivelDetalleCurso { get; set; }
        public Docente oDocente { get; set; }
        public bool Activo { get; set; }
    }
}

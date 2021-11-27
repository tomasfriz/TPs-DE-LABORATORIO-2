using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ajedrez : Juego
    {
        public Ajedrez()
        {

        }

        public Ajedrez(int codigo, Equipo ganador, int participantesRojos, int participantesVerdes, int puntos, double minutos)
            : base(codigo, ganador, 1, 1, puntos, 60)
        {
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

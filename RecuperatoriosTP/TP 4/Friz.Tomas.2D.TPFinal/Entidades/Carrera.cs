using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrera : Juego
    {
        public Carrera()
        {

        }

        public Carrera(int codigo, Equipo ganador, int participantesRojos, int participantesVerdes, int puntos, double minutos)
            : base(codigo, ganador, participantesRojos, participantesVerdes, puntos, minutos)
        {
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

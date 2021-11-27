using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Quemados : Juego
    {
        public Quemados()
        {

        }

        public Quemados(int codigo, Equipo ganador, int participantesRojos, int participantesVerdes, int puntos, double minutos)
            : base(codigo, ganador, participantesRojos, participantesVerdes, puntos, minutos)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

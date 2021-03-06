using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// FRIZ TOMÁS AGUSTÍN
/// </summary>

namespace Entidades
{
    public class Ajedrez : Juego
    {
        /// <summary>
        /// Constructor vacio de Ajedrez.
        /// </summary>
        public Ajedrez()
        {

        }
        /// <summary>
        /// Constructor de Ajedrez con parametros.
        /// </summary>
        /// <param name="cod"></param>
        /// <param name="ganador"></param>
        /// <param name="participantesRojos"></param>
        /// <param name="participantesVerdes"></param>
        /// <param name="puntos"></param>
        /// <param name="min"></param>
        public Ajedrez(int cod, Equipo ganador, int participantesRojos, int participantesVerdes, int puntos, double min) : base(cod, ganador, 1, 1, puntos, 60)
        {

        }
        /// <summary>
        /// Sobrecarga del ToString.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

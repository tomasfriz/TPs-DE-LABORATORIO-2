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
    public class Carrera : Juego
    {
        /// <summary>
        /// Constructor vacio de Carrera.
        /// </summary>
        public Carrera()
        {

        }
        /// <summary>
        /// Constructor de Carrera con parametros.
        /// </summary>
        /// <param name="cod"></param>
        /// <param name="ganador"></param>
        /// <param name="participantesRojos"></param>
        /// <param name="participantesVerdes"></param>
        /// <param name="puntos"></param>
        /// <param name="min"></param>
        public Carrera(int cod, Equipo ganador, int participantesRojos, int participantesVerdes, int puntos, double min) : base(cod, ganador, participantesRojos, participantesVerdes, puntos, min)
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

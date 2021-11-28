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
    public class CompetenciaFinalizadaException : Exception
    {
        public override string Message => "No se puede agregar el juego porque la competencia llego a su fin.";
    }
}

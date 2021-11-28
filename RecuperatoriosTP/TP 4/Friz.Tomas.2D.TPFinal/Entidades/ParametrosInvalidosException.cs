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
    public class ParametrosInvalidosException : Exception
    {
        public override string Message => "No se puede realizar la accion porque los parametros ingresados tienen un formato incorrecto o estan vacíos.";
    }
}

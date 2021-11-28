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
    interface ISerializable
    {
        bool SerializarAJson(string ruta, List<Juego> juego);
        List<Juego> DeserializarAJson(string ruta);
    }
}

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
        /// <summary>
        /// Se encarga de serializar a Json.
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="juego"></param>
        /// <returns></returns>
        bool SerializarAJson(string ruta, List<Juego> juego);
        /// <summary>
        /// Se encarga de deserializar a Json.
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns></returns>
        List<Juego> DeserializarAJson(string ruta);
    }
}

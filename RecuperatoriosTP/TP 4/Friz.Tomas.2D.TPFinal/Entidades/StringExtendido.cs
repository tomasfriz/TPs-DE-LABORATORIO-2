using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class StringExtendido
    {
        /// <summary>
        /// Metodo de extensión para verificar que un texto solo tenga numeros
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool SoloNumeros(this string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c) && c != '.' && c != ',')
                {
                    return false;
                }
            }

            return true;
        }
        /// <summary>
        /// Metodo de extensión para verificar que un texto solo tenga letras
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool SoloCaracteres(this string str)
        {
            foreach (char c in str)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

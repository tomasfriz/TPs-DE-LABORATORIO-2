using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// FRIZ TOMÁS AGUSTÍN
/// </summary>

namespace Entidades
{
    public class Resultados<T> where T : Juego
    {
        /// <summary>
        /// Genera un log con los resultados de una competencia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public static bool ImprimirResultados(object sender, string tipo)
        {
            try
            {
                string pathArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\FrmAnalisisDeDatos\";
                pathArchivo += @"Resultado " + tipo + ".log";
                using (StreamWriter nuevoTexto = new StreamWriter(pathArchivo))
                {
                    nuevoTexto.WriteLine("Fecha: " + DateTime.Now.ToString("d"));
                    nuevoTexto.WriteLine("Ganador: " + ((Competencia<T>)sender).Ganador);
                    nuevoTexto.WriteLine("Puntos: " + ((Competencia<T>)sender).PuntosTotales);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Genera un log con la duracion de la competencia que se excedio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public static bool ImprimirReporte(object sender, string tipo)
        {
            try
            {
                string pathArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\FrmAnalisisDeDatos\";
                pathArchivo += @"Reporte " + tipo + ".log";
                using (StreamWriter nuevoTexto = new StreamWriter(pathArchivo))
                {
                    nuevoTexto.WriteLine("Fecha: " + DateTime.Now.ToString("d"));
                    nuevoTexto.WriteLine("La duración supero las 6 horas con un total de: " + ((Competencia<T>)sender).DuracionTotal + " min.");
                    nuevoTexto.WriteLine("Para la proxima considerar reducir los tiempos o la cantidad de juegos.");

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

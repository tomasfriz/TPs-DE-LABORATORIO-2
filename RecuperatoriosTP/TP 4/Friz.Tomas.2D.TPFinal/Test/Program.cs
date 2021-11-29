using System;
using Entidades;

/// <summary>
/// FRIZ TOMÁS AGUSTÍN
/// </summary>

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia<Juego> juegos = new(1000);
            Ajedrez ajedrez = new(112, Equipo.Verde, 1, 1, 950, 60);
            Carrera carrera = new(113, Equipo.Verde, 7, 6, 500, 600);
            Quemados quemado = new(111, Equipo.Rojo, 12, 12, 2000, 500);
            juegos.EventoReporte += ManejadorEDuracion;
            juegos.Añadir(carrera);
            juegos.Añadir(ajedrez);
            try
            {
                juegos.Añadir(quemado);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\n----------------------------------------------------------------------------------------------------------\n");
            juegos.Lista = BaseDeDatos.ObtenerTodos();
            static void ManejadorEDuracion(object sender, EventArgs e)
            {
                Console.WriteLine("Se ha disparado el evento porque la duracion de los juegos supera los 360 min.");
            }
            Console.WriteLine(juegos);
        }
    }
}

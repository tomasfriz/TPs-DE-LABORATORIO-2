using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

/// <summary>
/// FRIZ TOMÁS AGUSTÍN
/// </summary>

namespace Entidades
{
    public class Juego : ISerializable
    {
        protected int codigo;
        protected Equipo ganador;
        protected int participantesRojos;
        protected int participantesVerdes;
        protected int puntos;
        protected double minutos;
        /// <summary>
        /// Constructor vacio de Juego.
        /// </summary>
        public Juego()
        {

        }
        /// <summary>
        /// Costructor con parametros de Juego.
        /// </summary>
        /// <param name="cod"></param>
        /// <param name="ganador"></param>
        /// <param name="participantesRojos"></param>
        /// <param name="participantesVerdes"></param>
        /// <param name="puntos"></param>
        /// <param name="min"></param>
        public Juego(int cod, Equipo ganador, int participantesRojos, int participantesVerdes, int puntos, double min)
        {
            this.codigo = cod;
            this.ganador = ganador;
            this.participantesRojos = participantesRojos;
            this.participantesVerdes = participantesVerdes;
            this.puntos = puntos;
            this.minutos = min;
        }
        /// <summary>
        /// Encapsulamiento de Codigo con Lambda.
        /// </summary>
        public int Codigo { get => codigo; set => codigo = value; }
        /// <summary>
        /// Encapsulamiento de Ganador con Lambda.
        /// </summary>
        public Equipo Ganador { get => ganador; set => ganador = value; }
        /// <summary>
        /// Encapsulamiento de ParticipantesRojos con Lambda.
        /// </summary>
        public int ParticipantesRojos { get => participantesRojos; set => participantesRojos = value; }
        /// <summary>
        /// Encapsulamiento de ParticipantesVerdes con Lambda.
        /// </summary>
        public int ParticipantesVerdes { get => participantesVerdes; set => participantesVerdes = value; }
        /// <summary>
        /// Encapsulamiento de Puntos con Lambda.
        /// </summary>
        public int Puntos { get => puntos; set => puntos = value; }
        /// <summary>
        /// Encapsulamiento de Minutos con Lambda.
        /// </summary>
        public double Minutos { get => minutos; set => minutos = value; }
        /// <summary>
        /// Encapsulamiento de Participantes con Lambda.
        /// </summary>
        public int Participantes { get => participantesRojos + ParticipantesVerdes; }

        /// <summary>
        /// Serializa una lista a formato json
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="juego"></param>
        /// <returns></returns>
        public static bool SerializarJson(string ruta, List<Juego> juego)
        {
            try
            {
                JsonSerializerOptions jsonSerializerOptions = new();
                jsonSerializerOptions.WriteIndented = true;
                string objetoJson = JsonSerializer.Serialize<object>(juego, jsonSerializerOptions);
                File.WriteAllText(ruta, objetoJson);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: ", ex);
                throw;
            }
        }
        /// <summary>
        /// Deserializa una lista de formato Json
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns></returns>
        public static List<Juego> DeserializarJson(string ruta)
        {
            string objetoJson = File.ReadAllText(ruta);
            List<Juego> objeto = JsonSerializer.Deserialize<List<Juego>>(objetoJson);
            return objeto;
        }
        /// <summary>
        /// Sobreescribe la funcion Serializar.
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns></returns>
        public List<Juego> DeserializarAJson(string ruta)
        {
            return DeserializarJson(ruta);
        }
        /// <summary>
        /// Sobreescribe la funcion Deserializar.
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="juego"></param>
        /// <returns></returns>
        public bool SerializarAJson(string ruta, List<Juego> juego)
        {
            return SerializarJson(ruta, juego);
        }

        /// <summary>
        /// Devuelve un string con los datos del juego
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Codigo: {Codigo} Ganador: {Ganador} Participantes: {Participantes} Puntos: {Puntos} Duracion: {Minutos} min.");
            return sb.ToString();
        }
    }
}
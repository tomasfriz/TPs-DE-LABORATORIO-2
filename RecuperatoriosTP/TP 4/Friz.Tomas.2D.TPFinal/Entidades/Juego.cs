using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
        public Juego()
        {

        }
        public Juego(int codigo, Equipo ganador, int participantesRojos, int participantesVerdes, int puntos, double minutos)
        {
            this.codigo = codigo;
            this.ganador = ganador;
            this.participantesRojos = participantesRojos;
            this.participantesVerdes = participantesVerdes;
            this.puntos = puntos;
            this.minutos = minutos;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public Equipo Ganador { get => ganador; set => ganador = value; }
        public int ParticipantesRojos { get => participantesRojos; set => participantesRojos = value; }
        public int ParticipantesVerdes { get => participantesVerdes; set => participantesVerdes = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public double Minutos { get => minutos; set => minutos = value; }
        public int Participantes { get => this.participantesRojos + this.ParticipantesVerdes; }       

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
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
                jsonSerializerOptions.WriteIndented = true;

                string objetoJson = JsonSerializer.Serialize<object>(juego, jsonSerializerOptions);

                File.WriteAllText(ruta, objetoJson);
                return true;
            }
            catch (Exception)
            {
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
        public List<Juego> DeserializarAJson(string ruta)
        {
            return Juego.DeserializarJson(ruta);
        }
        public bool SerializarAJson(string ruta, List<Juego> juego)
        {
            return Juego.SerializarJson(ruta, juego);
        }

        /// <summary>
        /// Devuelve un string con los datos del juego
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo: {this.Codigo} Ganador: {this.Ganador} Participantes: {this.Participantes} Puntos: {this.Puntos} Duracion: {this.Minutos} min.");
            return sb.ToString();
        }
    }
}
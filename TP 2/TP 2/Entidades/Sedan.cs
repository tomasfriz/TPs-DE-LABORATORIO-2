using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
//HECHO POR TOMÁS AGUSTÍN FRIZ
namespace Entidades
{
    //HECHO POR TOMÁS AGUSTÍN FRIZ
    public class Sedan : Vehiculo
    {
        //HECHO POR TOMÁS AGUSTÍN FRIZ
        #region Atributos
        ETipo tipo;
        #endregion
        //HECHO POR TOMÁS AGUSTÍN FRIZ
        #region Propiedades
        /// <summary>
        /// Los automoviles son medianos
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        #endregion
        //HECHO POR TOMÁS AGUSTÍN FRIZ
        #region Constructor
        /// <summary>
        /// Por defecto, TIPO será Monovolumen
        /// Y toma referencia de base que contiene chasis, marca y color.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {
            this.tipo = ETipo.CuatroPuertas;
        }
        /// <summary>
        /// Sedan construye el constructor para chasis, marca, color y tipo; y toma referencia del tipo Sedan que contiene chasis, marca y color
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color,ETipo tipo) : this(marca,chasis,color)
        {
            this.tipo = tipo;
        }
        #endregion
        //HECHO POR TOMÁS AGUSTÍN FRIZ
        #region Metodos
        /// <summary>
        /// Publica todos los datos de los vehiculos de categoria Sedan
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
        //HECHO POR TOMÁS AGUSTÍN FRIZ
        #region Enumerados
        /// <summary>
        /// enunciamos los distintas cantidades de puertas que puede tener un Sedande las marcas de los vehiculos
        /// </summary>
        public enum ETipo { CuatroPuertas, CincoPuertas }
        #endregion
    }
}

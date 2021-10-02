using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//HECHO POR TOMÁS AGUSTÍN FRIZ
namespace Entidades
{
    //HECHO POR TOMÁS AGUSTÍN FRIZ
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        //HECHO POR TOMÁS AGUSTÍN FRIZ
        #region Atributos
        private EMarca marca;
        private string chasis;
        private ConsoleColor color;
        #endregion
        //HECHO POR TOMÁS AGUSTÍN FRIZ
        #region Propiedades
        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get; }
        #endregion
        //HECHO POR TOMÁS AGUSTÍN FRIZ
        #region Constructor
        /// <summary>
        /// Vehiculo construye el constructor para chasis, marca y color
        /// </summary>
        /// <param name="chasis"></param>
        /// <param name="marca"></param>
        /// <param name="color"></param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }
        #endregion
        //HECHO POR TOMÁS AGUSTÍN FRIZ
        #region Metodos
        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }
        #endregion
        //HECHO POR TOMÁS AGUSTÍN FRIZ
        #region Sobrecargas de Operadores
        /// <summary>
        /// Sirve para que pueda imprimir los datos de vehiculo
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1.chasis == v2.chasis);
        }
        #endregion
        //HECHO POR TOMÁS AGUSTÍN FRIZ
        #region Enumerados
        /// <summary>
        /// enunciamos los nombres de las marcas de los vehiculos
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        /// <summary>
        /// enunciamos los distintos tamaños posibles
        /// </summary>
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }
        #endregion
    }
}

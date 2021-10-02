using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//HECHO POR TOMÁS AGUSTÍN FRIZ
namespace Entidades
{
    //HECHO POR TOMÁS AGUSTÍN FRIZ
    public class Suv : Vehiculo
    {
        //HECHO POR TOMÁS AGUSTÍN FRIZ
        #region Propiedades
        /// <summary>
        /// Las camionetas son grandes
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }
        #endregion
        //HECHO POR TOMÁS AGUSTÍN FRIZ
        #region Constructor
        /// <summary>
        /// Suv construye el constructor para chasis, marca y color y toma referencia de base que contiene chasis, marca y color
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Suv(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {
        }
        #endregion
        //HECHO POR TOMÁS AGUSTÍN FRIZ
        #region Metodos
        /// <summary>
        /// Publica todos los datos de los vehiculos de categoria Suv
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//HECHO POR TOMÁS AGUSTÍN FRIZ
namespace Entidades
{
    //HECHO POR TOMÁS AGUSTÍN FRIZ
    public class Ciclomotor : Vehiculo
    {
        //HECHO POR TOMÁS AGUSTÍN FRIZ
        #region Propiedades
        /// <summary>
        /// Las motos son chicas
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }
        #endregion
        //HECHO POR TOMÁS AGUSTÍN FRIZ
        #region Constructor
        /// <summary>
        /// Ciclomotor construye el constructor para chasis, marca y color  y toma referencia del tipo base que contiene chasis, marca y color
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {
        }
        #endregion
        //HECHO POR TOMÁS AGUSTÍN FRIZ
        #region Metodos
        /// <summary>
        /// Publica todos los datos de los vehiculos de categoria ciclomotor
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}

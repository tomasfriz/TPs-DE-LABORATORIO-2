using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// CREADO POR TOMÁS AGUSTIN FRIZ
    /// </summary>
    public class Operando
    {
        /// <summary>
        /// CREADO POR TOMÁS AGUSTIN FRIZ
        /// </summary>

        #region Atributos
        private double numero;
        #endregion

        /// <summary>
        /// CREADO POR TOMÁS AGUSTIN FRIZ
        /// </summary>

        #region Propiedades
        /// <summary>
        /// Establece un numero en el atributo numero si y solo si la cadena que lo representa es transformable a double, 
        /// caso contrario asigna 0.
        /// </summary>
        public string Numero
        {
            set
            {
                this.numero = this.ValidarOperando(value);
            }
        }
        #endregion

        /// <summary>
        /// CREADO POR TOMÁS AGUSTIN FRIZ
        /// </summary>

        #region Constructores
        /// <summary>
        /// Genera una instancia de la clase Operando inicializada en 0.
        /// </summary>
        public Operando() : this(0)
        {
        }
        /// <summary>
        /// Genera una instancia de la clase Operando.
        /// </summary>
        /// <param name="numero">Numero en formato Double para inicializar la instancia.</param>
        public Operando(double numero) : this(numero.ToString())
        {
        }
        /// <summary>
        /// Genera una instancia de la clase Operando.
        /// </summary>
        /// <param name="strNumero">Numero en formato string para inicializar instancia.</param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }
        #endregion

        /// <summary>
        /// CREADO POR TOMÁS AGUSTIN FRIZ
        /// </summary>

        #region Operadores
        /// <summary>
        /// Realiza una resta entre los numeros que almacenan dos instancias de Operando y 
        /// devuelve un double con el resultado.
        /// </summary>
        /// <param name="n1">Operando 1.</param>
        /// <param name="n2">Operando 2.</param>
        /// <returns>Devuelve un numero en formato double.</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return (n1.numero - n2.numero);
        }
        /// <summary>
        /// Realiza una suma entre los numeros que almacenan dos instancias de Operando y
        /// devuelve un double con el resultado.
        /// </summary>
        /// <param name="n1">Operando 1.</param>
        /// <param name="n2">Operando 2.</param>
        /// <returns>Devuelve un numero en formato double.</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return (n1.numero + n2.numero);
        }
        /// <summary>
        /// Realiza una multiplicacion entre los numeros que almacenan dos instancias de Operando y
        /// devuelve un double con el resultado.
        /// </summary>
        /// <param name="n1">Operando 1.</param>
        /// <param name="n2">Operando 2.</param>
        /// <returns>Devuelve un numero en formato double.</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return (n1.numero * n2.numero);
        }
        /// <summary>
        /// Realiza una division entre los numeros que almacenan dos instancias de Operando y
        /// devuelve un double con el resultado.
        /// </summary>
        /// <param name="n1">Operando 1.</param>
        /// <param name="n2">Operando 2.</param>
        /// <returns>Devuelve un numero en formato double.</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            return (n1.numero / n2.numero);
        }
        #endregion

        /// <summary>
        /// CREADO POR TOMÁS AGUSTIN FRIZ
        /// </summary>

        #region Metodos
        /// <summary>
        /// Verifica que un numero en formato string puedan ser transformado a double y lo devuelve. 
        /// Caso contrario retorna 0.
        /// </summary>
        /// <param name="strNumero">Operando en formato string a verificar.</param>
        /// <returns>Devuelve un numero en formato double.</returns>
        private double ValidarOperando(string strNumero)
        {
            Double.TryParse(strNumero, out double resultado);
            return resultado;
        }
        /// <summary>
        /// Convierte la parte entera y postiva de un numero binario en formato string a un numero decimal y lo devuelve
        /// como string , caso contrario retorna "Valor invalido".
        /// </summary>
        /// <param name="binario">Operando binario a convertir a decimal.</param>
        /// <returns>Devuelve un numero de base 10 en formato string.</returns>
        public string BinarioDecimal(string binario)
        {
            string resultado = "Valor inválido";

            if (double.TryParse(binario, out double numDecimal))
            {
                numDecimal = 0;
                //Preparo al metodo para recibir numeros con puntos y no fallar.
                binario = binario.Replace(".", "");
                binario = binario.Replace("-", "");
                binario = (binario.Contains(',')) ? binario.Remove(binario.IndexOf(',')) : binario;
                /*Primero se elimina la parte no entera del binario y luego evaluo si solo tiene unos y ceros para
                para cumplir con "Los métodos BinarioDecimal y DecimalBinario trabajaran con enteros positivos, 
                quedándose para esto con el valor absoluto y entero".*/
                if (binario.Trim('1', '0') == string.Empty)
                {
                    for (int i = 0; i < binario.Length; i++)
                    {
                        numDecimal += Convert.ToDouble(binario[i].ToString()) * Math.Pow(2, binario.Length - 1 - i);
                    }
                    resultado = numDecimal.ToString();
                }
            }
            return resultado;
        }
        /// <summary>
        /// Convierte la parte entera y postiva de un numero decimal en formato double a un numero binario y lo devuelve
        /// como string , caso contrario retorna "Valor invalido".
        /// </summary>
        /// <param name="numero">Operando decimal en formato double a convertir a binario.</param>
        /// <returns>Devuelve un numero de base 2 en formato string.</returns>
        public string DecimalBinario(double numero)
        {
            return this.DecimalBinario(numero.ToString());
        }
        /// <summary>
        /// Convierte la parte entera y postiva de un numero decimal en formato string a un numero binario y lo devuelve
        /// como string , caso contrario retorna "Valor invalido".
        /// </summary>
        /// <param name="numero">Operando decimal en formato string a convertir a binario.</param>
        /// <returns>Devuelve un numero de base 2 en formato string.</returns>
        public string DecimalBinario(string numero)
        {
            string binario = "Valor inválido";
            if (double.TryParse(numero, out double numDecimal))
            {
                numDecimal = Math.Abs(Math.Truncate(numDecimal));
                binario = (numDecimal == 0) ? "0" : "";
                while (numDecimal > 0)
                {
                    binario = (numDecimal % 2) + binario;
                    numDecimal = Math.Truncate(numDecimal / 2);
                }
            }
            return binario;
        }
        #endregion

        /// <summary>
        /// CREADO POR TOMÁS AGUSTIN FRIZ
        /// </summary>
    }
}

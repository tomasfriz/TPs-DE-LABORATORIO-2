﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//HECHO POR TOMÁS AGUSTÍN FRIZ
namespace Entidades
{
    //HECHO POR TOMÁS AGUSTÍN FRIZ
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller
    {
        //HECHO POR TOMÁS AGUSTÍN FRIZ
        #region Atributos
        private List<Vehiculo> vehiculos;
        private int espacioDisponible;
        #endregion
        //HECHO POR TOMÁS AGUSTÍN FRIZ
        #region Constructores
        /// <summary>
        /// Taller construye el constructor para una lista de vehiculos y para el espacio maximo disponible.
        /// </summary>
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
            this.espacioDisponible = 6;
        }
        /// <summary>
        /// Taller construye el constructor para el espacio maximo disponible y tambien deriva de This.
        /// </summary>
        /// <param name="espacioDisponible"></param>
        public Taller(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion
        //HECHO POR TOMÁS AGUSTÍN FRIZ
        #region Métodos
        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="t">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Listar(Taller t, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", t.vehiculos.Count, t.espacioDisponible);
            sb.AppendLine("");
            foreach (Vehiculo v in t.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.SUV:
                        if (v is Suv)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Ciclomotor:
                        if (v is Ciclomotor)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Sedan:
                        if (v is Sedan)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    default:
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }
            return sb.ToString();
        }
        #endregion
        //HECHO POR TOMÁS AGUSTÍN FRIZ
        #region Sobrecargas
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Taller.Listar(this, ETipo.Todos);
        }
        #endregion
        //HECHO POR TOMÁS AGUSTÍN FRIZ
        #region Operadores
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="t">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller t, Vehiculo vehiculo)
        {
            bool esta = false;
            if (t.vehiculos.Count < t.espacioDisponible)
            {
                foreach (Vehiculo v in t.vehiculos)
                {
                    if (v == vehiculo)
                    {
                        esta = true;
                        break;
                    }
                }
                if(!esta)
                {
                    t.vehiculos.Add(vehiculo);
                }
            }
            return t;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="t">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller t, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in t.vehiculos)
            {
                if (v == vehiculo)
                {
                    t.vehiculos.Remove(v);
                    break;
                }
            }
            return t;
        }
        #endregion
        //HECHO POR TOMÁS AGUSTÍN FRIZ
        #region Enumerados
        /// <summary>
        /// enunciamos los distintos tipos de vehiculos
        /// </summary>
        public enum ETipo
        {
            Ciclomotor, Sedan, SUV, Todos
        }
        #endregion
    }
}

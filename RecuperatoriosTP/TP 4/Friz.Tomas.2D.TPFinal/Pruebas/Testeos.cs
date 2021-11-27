using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;
using System;

namespace Pruebas
{
    [TestClass]
    public class Testeos
    {
        [TestMethod]
        public void TraerTodos_ConectarALaBaseDeDatosYTraerTablaJuegos_DebeDevolverLista()
        {
            //Arrange
            Competencia<Juego> juegos = new Competencia<Juego>(1000);
            //Act
            juegos.Lista = BaseDeDatos.ObtenerTodos();
            //Assert
            Assert.IsNotNull(juegos);
            Assert.IsTrue(juegos.Lista.Count > 0);
        }

        [TestMethod]
        public void DispararEventos_CumplirCondicionesDelEvento_DebeDispararEventos()
        {
            //Arrange
            Competencia<Juego> juegos = new Competencia<Juego>(1000);
            Quemados quemados = new Quemados(1, Equipo.Rojo, 1, 1, 1001, 500);
            juegos.EventoFinalizado += ManejadorEFinalizado;
            juegos.EventoReporte += ManejadorEDuracion;
            bool seEjecutoFinalizado = false;
            bool seEjecutoDuracion = false;
            //Act
            juegos.Lista.Add(quemados);
            Competencia<Juego>.VerificarEstado(juegos);
            void ManejadorEFinalizado(object sender, EventArgs e)
            {
                seEjecutoFinalizado = true;
            }
            void ManejadorEDuracion(object sender, EventArgs e)
            {
                seEjecutoDuracion = true;
            }
            //Assert
            Assert.IsTrue(seEjecutoDuracion);
            Assert.IsTrue(seEjecutoFinalizado);
        }
    }
}

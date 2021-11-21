using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace Testeos
{
    [TestClass]
    public class Test_TP4
    {
        [TestMethod]
        public void ContarPalabras_CuandoRecibeDosPalabras_DeberiaRetornarNumeroDos()
        {
            //Arrange
            string texto = "Hola Mundo";
            int expected = 2;

            //Act
            int actual = texto.ContarPalabras();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ContarPalabras_RecibeUnStringVacio_DeberiaLanzarArgumentException()
        {
            //Arrange
            string str = string.Empty;

            //Act
            int actual = str.ContarPalabras();
        }
        [TestMethod]
        public void ContarPalabras_CuandoRecibePalabrasSeparadasPorGuion_DeberiaRetornarDos()
        {
            //Arrange
            string texto = "Hola-Mundo";
            int expected = 2;

            //Act
            int actual = texto.ContarPalabras();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

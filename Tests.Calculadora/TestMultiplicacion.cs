using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Numero;

namespace Tests.Calculadora
{


    [TestClass]
    class TestMultiplicacion
    {

        [TestMethod]
        public void Multiplicacion()
        {
            //definicion del escenario
            Numero elPrimerOperando = new Numero("11F1FF", 16);
            Numero elSegundoOperando = new Numero("7", 8);
            Numero elResultadoEsperado = new Numero("8232441", 10);
            Numero elResultadoReal;

            //Invoque el metodo que se prueba
            var laReferencia = new Core.Numero.Dominio.Acciones.Multiplicacion();
            elResultadoReal = laReferencia.MultiOperar(elPrimerOperando, elSegundoOperando, 16, 8);

            //Verificar si el resultado obtenido es el mismo que es el espereado
            Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);
        }


    }
}

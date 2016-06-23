using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Numero;

namespace Tests.Calculadora
{

    [TestClass]
    public class TestResta
    {
        
        [TestMethod]
        public void Resta()
        {
            //definicion del escenario
            Numero elPrimerOperando = new Numero("11F1FF", 16);
            Numero elSegundoOperando = new Numero("7", 8);
            Numero elResultadoEsperado = new Numero("1176056", 10);
            Numero elResultadoReal;

            //Invoque el metodo que se prueba
            var laReferencia = new Core.Numero.Dominio.Acciones.Resta();
            elResultadoReal = laReferencia.RestaOperar(elPrimerOperando, elSegundoOperando, 16, 8);

            //Verificar si el resultado obtenido es el mismo que es el espereado
            Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);
        }



    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Numero;

namespace Tests.Calculadora
{
    [TestClass]
    public class TestDivision
    {


        [TestMethod]
        public void Division()
        {
            //definicion del escenario
            Numero elPrimerOperando = new Numero("11F1FF", 16);
            Numero elSegundoOperando = new Numero("7", 8);
            Numero elResultadoEsperado = new Numero("168009", 10);
            Numero elResultadoReal;

            //Invoque el metodo que se prueba
            var laReferencia = new Core.Numero.Dominio.Acciones.Division();
            elResultadoReal = laReferencia.DividirOperar(elPrimerOperando, elSegundoOperando, 16, 8);

            //Verificar si el resultado obtenido es el mismo que es el espereado
            Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);
        }

        [TestMethod]
        public void DivisionconCero()
        {        
                //definicion del escenario
                Numero elPrimerOperando = new Numero("2", 10);
                Numero elSegundoOperando = new Numero("0", 10);
                Numero elResultadoEsperado = new Numero("∞", 10);
                Numero elResultadoReal;

                //Invoque el metodo que se prueba
                var laReferencia = new Core.Numero.Dominio.Acciones.Division();
                elResultadoReal = laReferencia.DividirOperar(elPrimerOperando, elSegundoOperando,10,10);

                //Verificar si el resultado obtenido es el mismo que es el espereado
                Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);
          

        }
    }
}

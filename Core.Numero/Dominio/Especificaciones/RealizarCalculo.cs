using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Especificaciones
{
    public class RealizarCalculo
    {
        public Numero OperadorBinario(char elOperador, Numero elPrimerNumero, Numero elSegundoNumero)
        {
            Numero elResultado = null;
            int base1 = 0; 
            int base2 = 0;

            switch (elOperador)
            {
                case '+': var accionSuma = new Acciones.Suma();
                    elResultado = accionSuma.Operar(elPrimerNumero, elSegundoNumero, base1, base2);
                    break;

                case '-': var accionResta = new Acciones.Resta();
                    elResultado = accionResta.RestaOperar(elPrimerNumero, elSegundoNumero,base1,base2);
                    break;


                case '/': var accionDivision = new Acciones.Division();
                    elResultado = accionDivision.DividirOperar(elPrimerNumero, elSegundoNumero, base1, base2);
                    break;
                    
                case '*': var accionMultiplicacion = new Acciones.Multiplicacion();
                    elResultado = accionMultiplicacion.MultiOperar(elPrimerNumero, elSegundoNumero,base1, base2);
                    break;
            }
            return (elResultado);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Acciones
{
    public class Suma
    {
        public Numero Operar (Numero elPrimerNumero, Numero elSegundoNumero,int base1, int base2)
        {
           Numero resultado = null;

           var validarBases = new Validaciones.ValidarBase();

           string PrimerNumero = validarBases.BaseCambiarPrimero(elPrimerNumero, base1);
           string SegundoNumero = validarBases.BaseCambiarSegundo(elSegundoNumero, base2);

           Numero numeroUno = new Numero(PrimerNumero, 10);
           Numero  numeroDos = new Numero(SegundoNumero, 10);

           
            if (validarBases.LasDosBasesSonIguiales(numeroUno, numeroDos)){
                
                double elResultadoNumerico = Convert.ToDouble(numeroUno.elNumero) + Convert.ToDouble(numeroDos.elNumero);
                
                resultado = new Numero(elResultadoNumerico.ToString(), 10);

            }
            return (resultado);
        }
    }


      


}

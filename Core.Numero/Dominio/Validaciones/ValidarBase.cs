using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Validaciones
{
    public class ValidarBase
    {
        public bool LaBaseEstaEnElIntervaloCorrecto (int laBase)
        {
            bool resultado;
            resultado = (2 <= laBase) & (laBase <= 32);
            return (resultado);
        }

        public bool LasDosBasesSonIguiales (Numero elPrimerNumero, Numero elSengundoNumero)
        {
            bool resultado;
 
            resultado = (elPrimerNumero.laBase == elSengundoNumero.laBase);
            return (resultado); 
        }


        public String BaseCambiarPrimero(Numero elPrimerNumero, int laBase)
        {

            string Primero = Convert.ToString(elPrimerNumero.elNumero);
            int fromBase = laBase;
            int toBase = 10;
            String primerNumero = Convert.ToString(Convert.ToInt32(Primero, fromBase),toBase);
            return (primerNumero);

            
        }

        public String BaseCambiarSegundo(Numero elSengundoNumero, int laBase)
        {
            string Segundo = Convert.ToString(elSengundoNumero.elNumero);
            int fromBase = laBase;
            int toBase = 10;

            String SegundoNumero = Convert.ToString(Convert.ToInt32(Segundo, fromBase), toBase);
            return (SegundoNumero);
        }

        public bool ValidarNumeroDeBase(int laBase, Numero elPrimerNumero, Numero elSengundoNumero)
        {
            bool resultado = true;
           /* string [] vectorNumeros = {"0","1","2","3","4","5","6","7","8","9" };
            string [] vectorAbecedario = { "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u"};
            int contVectorNumeros;
            int contVectorAbecedario;*/
            switch (laBase)
            {
                case 1://base 2
                    for (int contNumero = 0; contNumero < elPrimerNumero.elNumero.Length; contNumero++)
                    { 
                        if(elPrimerNumero.elNumero.Substring(contNumero) != "0" || elPrimerNumero.elNumero.Substring(contNumero) != "1")
                        {
                            resultado = false;
                            return resultado;
                        }        
                    }//For
                   
                    for (int contNumero = 0; contNumero < elSengundoNumero.elNumero.Length; contNumero++)
                    {
                        if (elSengundoNumero.elNumero.Substring(contNumero) != "0" || elSengundoNumero.elNumero.Substring(contNumero) != "1")
                        {
                            resultado = false;
                            return resultado;
                        }
                    }//For
                    break;

                case 2: //base 4
                    for (int contNumero = 0; contNumero < elPrimerNumero.elNumero.Length; contNumero++)
                    {
                        if (   elPrimerNumero.elNumero.Substring(contNumero) != "0" || elPrimerNumero.elNumero.Substring(contNumero) != "1"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "2" || elPrimerNumero.elNumero.Substring(contNumero) != "3")
                        {
                            resultado = false;
                            return resultado;
                        }
                    }//For
                    for (int contNumero = 0; contNumero < elSengundoNumero.elNumero.Length; contNumero++)
                    {
                        if (   elSengundoNumero.elNumero.Substring(contNumero) != "0" || elSengundoNumero.elNumero.Substring(contNumero) != "1"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "2" || elSengundoNumero.elNumero.Substring(contNumero) != "3")
                        {
                            resultado = false;
                            return resultado;
                        }
                    }//For
                    break;
                case 3: //base 8
                    for (int contNumero = 0; contNumero < elPrimerNumero.elNumero.Length; contNumero++)
                    {
                        if (   elPrimerNumero.elNumero.Substring(contNumero) != "0" || elPrimerNumero.elNumero.Substring(contNumero) != "1"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "2" || elPrimerNumero.elNumero.Substring(contNumero) != "3"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "4" || elPrimerNumero.elNumero.Substring(contNumero) != "5"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "6" || elPrimerNumero.elNumero.Substring(contNumero) != "7")
                        {
                            resultado = false;
                            return resultado;
                        }
                    }//For
                    for (int contNumero = 0; contNumero < elSengundoNumero.elNumero.Length; contNumero++)
                    {
                        if (   elSengundoNumero.elNumero.Substring(contNumero) != "0" || elSengundoNumero.elNumero.Substring(contNumero) != "1"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "2" || elSengundoNumero.elNumero.Substring(contNumero) != "3"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "4" || elSengundoNumero.elNumero.Substring(contNumero) != "5"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "6" || elSengundoNumero.elNumero.Substring(contNumero) != "7")
                        {
                            resultado = false;
                            return resultado;
                        }
                    }//For
                    break;
                case 4: //base 16
                    for (int contNumero = 0; contNumero < elPrimerNumero.elNumero.Length; contNumero++)
                    {
                        if (   elPrimerNumero.elNumero.Substring(contNumero) != "0" || elPrimerNumero.elNumero.Substring(contNumero) != "1"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "2" || elPrimerNumero.elNumero.Substring(contNumero) != "3"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "4" || elPrimerNumero.elNumero.Substring(contNumero) != "5"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "6" || elPrimerNumero.elNumero.Substring(contNumero) != "7"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "8" || elPrimerNumero.elNumero.Substring(contNumero) != "9"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "a" || elPrimerNumero.elNumero.Substring(contNumero) != "b"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "c" || elPrimerNumero.elNumero.Substring(contNumero) != "d"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "e" || elPrimerNumero.elNumero.Substring(contNumero) != "f")
                        {
                            resultado = false;
                            return resultado;
                        }
                    }//For
                    for (int contNumero = 0; contNumero < elSengundoNumero.elNumero.Length; contNumero++)
                    {
                        if (   elSengundoNumero.elNumero.Substring(contNumero) != "0" || elSengundoNumero.elNumero.Substring(contNumero) != "1"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "2" || elSengundoNumero.elNumero.Substring(contNumero) != "3"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "4" || elSengundoNumero.elNumero.Substring(contNumero) != "5"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "6" || elSengundoNumero.elNumero.Substring(contNumero) != "7"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "8" || elSengundoNumero.elNumero.Substring(contNumero) != "9"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "a" || elSengundoNumero.elNumero.Substring(contNumero) != "b"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "c" || elSengundoNumero.elNumero.Substring(contNumero) != "d"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "e" || elSengundoNumero.elNumero.Substring(contNumero) != "f")
                        {
                            resultado = false;
                            return resultado;
                        }
                    }//For
                    break;
                case 5: //base 32
                    for (int contNumero = 0; contNumero < elPrimerNumero.elNumero.Length; contNumero++)
                    {
                        if (elPrimerNumero.elNumero.Substring(contNumero) != "0" || elPrimerNumero.elNumero.Substring(contNumero) != "1"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "2" || elPrimerNumero.elNumero.Substring(contNumero) != "3"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "4" || elPrimerNumero.elNumero.Substring(contNumero) != "5"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "6" || elPrimerNumero.elNumero.Substring(contNumero) != "7"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "8" || elPrimerNumero.elNumero.Substring(contNumero) != "9"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "a" || elPrimerNumero.elNumero.Substring(contNumero) != "b"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "c" || elPrimerNumero.elNumero.Substring(contNumero) != "d"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "e" || elPrimerNumero.elNumero.Substring(contNumero) != "f"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "g" || elPrimerNumero.elNumero.Substring(contNumero) != "h"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "i" || elPrimerNumero.elNumero.Substring(contNumero) != "j"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "k" || elPrimerNumero.elNumero.Substring(contNumero) != "l"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "m" || elPrimerNumero.elNumero.Substring(contNumero) != "n"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "o" || elPrimerNumero.elNumero.Substring(contNumero) != "p"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "q" || elPrimerNumero.elNumero.Substring(contNumero) != "r"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "s" || elPrimerNumero.elNumero.Substring(contNumero) != "t"
                            || elPrimerNumero.elNumero.Substring(contNumero) != "u" )
                            
                        {
                            resultado = false;
                            return resultado;
                        }
                    }//For
                    for (int contNumero = 0; contNumero < elSengundoNumero.elNumero.Length; contNumero++)
                    {
                        if (elSengundoNumero.elNumero.Substring(contNumero) != "0" || elSengundoNumero.elNumero.Substring(contNumero) != "1"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "2" || elSengundoNumero.elNumero.Substring(contNumero) != "3"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "4" || elSengundoNumero.elNumero.Substring(contNumero) != "5"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "6" || elSengundoNumero.elNumero.Substring(contNumero) != "7"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "8" || elSengundoNumero.elNumero.Substring(contNumero) != "9"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "a" || elSengundoNumero.elNumero.Substring(contNumero) != "b"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "c" || elSengundoNumero.elNumero.Substring(contNumero) != "d"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "e" || elSengundoNumero.elNumero.Substring(contNumero) != "f"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "g" || elSengundoNumero.elNumero.Substring(contNumero) != "h"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "i" || elSengundoNumero.elNumero.Substring(contNumero) != "j"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "k" || elSengundoNumero.elNumero.Substring(contNumero) != "l"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "m" || elSengundoNumero.elNumero.Substring(contNumero) != "n"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "o" || elSengundoNumero.elNumero.Substring(contNumero) != "p"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "q" || elSengundoNumero.elNumero.Substring(contNumero) != "r"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "s" || elSengundoNumero.elNumero.Substring(contNumero) != "t"
                            || elSengundoNumero.elNumero.Substring(contNumero) != "u")
                        {
                            resultado = false;
                            return resultado;
                        }
                    }//Fo

                    break;
            }
            return resultado;


        }








    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Validaciones
{
    public class ValidarNumero
    {
        public bool ElNumeroEsValidoEnLaBase (string elNumero, int laBase)
        {
            bool elResultado = true;
            for(int i=0; (elResultado == true) & (i < elNumero.Length); i++)
            {
                elResultado = ElDigitoEsValidoEnLaBase(elNumero[i], laBase);
            }
            return (elResultado);
        }

        private bool ElDigitoEsValidoEnLaBase (char elDigito, int laBase)
        {
            bool elResultado;
            //TODO: Verdificarlo!
            elResultado = true;    
            return (elResultado);
        }

        public bool ElNumeroNoEsDecimal(char elDigito)
        {
            bool elResultado = true;
            if(elDigito.ToString().Contains(".")==true)
            {
                elResultado = false;
            }
            return (elResultado);
        }
    }
}

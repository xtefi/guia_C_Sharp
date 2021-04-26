using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    public class Conversor
    {
        static string DecimalBinario(int numero)
        {
            int resultado;
            string binario;
            do
            {
                if(numero % 2 == 0)
                {
                    binario+="0";
                }
                else
                {
                    binario += "1";
                }

            } while(resultado >= 1);
            return "";
        }
    }
}

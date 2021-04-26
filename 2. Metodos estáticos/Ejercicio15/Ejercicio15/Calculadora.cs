using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    public class Calculadora
    {
        public static double Calcular(double numero1, double numero2, char operador)
        {
            double resultado=double.MinValue;
          
            switch(operador)
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;
                case '-':
                    resultado = numero2 - numero2;
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    break;
                case '/':
                    if(Validar(numero2) == true)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        Console.WriteLine("Error, no se puede dividir por cero");
                        resultado = double.MinValue;
                    }
                    break;
            }                
            return resultado;                      
        }

        private static bool Validar(double numero2)
        {
            bool retorno;

            if (numero2 == 0)
            {
               retorno = false;
            }
            else retorno = true;
            return retorno;
        }
    }
}

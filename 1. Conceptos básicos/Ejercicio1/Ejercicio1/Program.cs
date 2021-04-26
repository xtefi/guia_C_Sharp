using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Ingresar 5 números por consola, guardándolos en una variable escalar.
//Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros;
            int maximo=0;
            int minimo=0;
            int acumulador = 0;
            int promedio;
            int i;
                        
            for(i=0; i<5; i++)
            {
                Console.WriteLine("Ingrese su numero: ");
                numeros = Convert.ToInt32(Console.ReadLine());
                if(i==0)
                {
                    maximo = numeros;
                    minimo = numeros;
                }    
                if(maximo < numeros)
                {
                    maximo = numeros;
                }
                if(minimo > numeros)
                {
                    minimo = numeros;
                }
                acumulador += numeros;
            }
            promedio = acumulador / i;
            Console.WriteLine("Maximo: {0}. Minimo: {1}. Promedio: {2}", maximo, minimo, promedio);
            Console.ReadKey();
        }
    }
}

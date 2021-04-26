using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
//Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {                   
            Console.Title = "Ejercicio_03";
            int numero;
            int contador = 0;
            bool isPrimo = false;
            Console.Write("Ingrese el rango: ");
            bool success = Int32.TryParse(Console.ReadLine(), out numero);

            for (int i = 1; i <= numero; i++)
            {
                for (int j = 1; j <= numero; j++)
                {
                    if (i % j == 0)
                    {
                        contador++;
                        if (contador == 3)
                        {
                            isPrimo = true;
                            contador = 0;
                            break;
                        }
                    }
                }
                if (isPrimo == false)
                {
                    Console.Write("{0} - ", i);
                }
                isPrimo = false;
            }
            Console.ReadKey();            
        }
    }
}

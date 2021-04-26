using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 15";
            double numero1;
            double numero2;
            char operador;
            char menu;
            do
            {
                Console.WriteLine("Ingrese primer numero: ");
                numero1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese segundo numero: ");
                numero2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese operador: ");
                operador = Convert.ToChar(Console.ReadLine());

                Console.WriteLine(Calculadora.Calcular(numero1, numero2, operador));

                Console.WriteLine("Desea continuar? S/N");
                menu = Convert.ToChar(Console.ReadLine());
            } while (menu == 's' || menu == 'S');
            
        }
    }
}

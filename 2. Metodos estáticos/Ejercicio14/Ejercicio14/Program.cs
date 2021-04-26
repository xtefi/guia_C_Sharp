using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 14";

            int menu;
            double medida1;
            double medida2;

            do
            {
                Console.WriteLine("Menu: \n" +
                                    "1. Caluclar area de un cuadrado\n" +
                                    "2. Calcular área de un rectángulo\n" +
                                    "3. Calcular ádea de un círculo\n" +
                                    "4. Salir");
                int.TryParse(Console.ReadLine(), out menu);
                switch(menu)
                {
                    case 1:
                        Console.WriteLine("Ingrese longitud del lado del cuadrado: ");
                        double.TryParse(Console.ReadLine(), out medida1);
                        Console.WriteLine("El área del cuadrado es: {0}", CalculoDeArea.CalcularCuadrado(medida1));
                        break;
                    case 2:
                        Console.WriteLine("Ingrese longitud de la base del triángulo: ");
                        double.TryParse(Console.ReadLine(), out medida1);
                        Console.WriteLine("Ingrese longitud de la altura del triángulo: ");
                        double.TryParse(Console.ReadLine(), out medida2);
                        Console.WriteLine("El área del cuadrado es: {0}", CalculoDeArea.CalcularTriangulo(medida1, medida2));
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el radio del círculo: ");
                        double.TryParse(Console.ReadLine(), out medida1);
                        Console.WriteLine("El área del círculo es: {0}", CalculoDeArea.CalcularCirculo(medida1));
                        break;
                }
            } while (menu != 4);
        }
    }
}

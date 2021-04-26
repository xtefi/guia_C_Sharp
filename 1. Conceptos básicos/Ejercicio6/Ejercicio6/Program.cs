using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Escribir un programa que determine si un año es bisiesto. Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no
//son bisiestos, salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
//Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango. Nota: Utilizar estructuras
//repetitivas, selectivas y la función módulo (%).
namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 6";
            int year;
            char answer;

            do
            {
                Console.WriteLine("Ingrese año: ");
                year = Convert.ToInt32(Console.ReadLine());
                if (year % 4 == 0 || year % 400 == 0)
                {
                    Console.WriteLine("El año sí es bisiesto. \n Desea continuar? S/N");
                }
                else
                {
                    Console.WriteLine("El año no es bisiesto. \n Desea continuar? S/N");
                }
                answer=Convert.ToChar(Console.ReadLine());
            } while (answer == 's' || answer == 'S');
        }
    }
}

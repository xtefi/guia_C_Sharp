using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
/*/*
 * * Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de un mensaje "¿Continuar? (S/N)". 
 * * En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de opciones. El método devolverá
 * * un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
 * */
namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int suma = 0;
            char control;

            do
            {
                Console.WriteLine("Ingrese numero a sumar: ");
                numero = Convert.ToInt32(Console.ReadLine());
                suma += numero;
                Console.WriteLine("Desea continuar? Ingrese S/N");
                control = Convert.ToChar(Console.ReadLine());

            } while(ValidarRespuesta.ValidaS_N(control));
            Console.WriteLine("Suma total: {0}", suma);
            Console.ReadKey();
        }
    }
}

using System;

//2. Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero,
//caso contrario, mostrar el mensaje: //"ERROR. ¡Reingresar número!". Nota: Utilizar el método ‘Pow’
//de la clase Math para realizar la operación.
namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero<=0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }
            else 
            {
                
                double cuadrado=Math.Pow(numero,2);
                double cubo=Math.Pow(numero,3);
                Console.WriteLine("El cuadrado es: {0}. El cubo es: {1}", cuadrado, cubo);
            }
            Console.ReadKey();
        }
    }
}

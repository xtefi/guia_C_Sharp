using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
/*
 * 11. Realizar una clase llamada Validacion que posea un método estático llamado Validar, que posea la siguiente firma:
 * bool Validar(int valor, int min, int max):
 * a. valor: dato a validar
 * b. min y max: rango en el cual deberá estar la variable valor.
 * Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que esten dentro del rango 
 * -100 y 100. Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio. Nota: Utilizar variables escalares, 
 * NO utilizar vectores.
*/
namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 11";
            int numero;
            int minimo=0;
            int maximo=0;
            float promedio;
            int acumulador=0;
            int contador = 0;
           
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("Ingrese un número entre 100 y -100");
                numero = Convert.ToInt32(Console.ReadLine());
                if (Validacion.Validar(numero, -100, 100) == true)
                {
                    acumulador += numero;
                    if(contador==0)
                    {
                        maximo = numero;
                        minimo = numero;
                    }
                    if(numero>maximo)
                    {
                        maximo = numero;
                    }
                    if(numero<minimo)
                    {
                        minimo = numero;
                    }
                    contador++;                    
                }
                else Console.WriteLine("Error, numero entre 100 y -100");
            }
            promedio = acumulador / contador;
            Console.WriteLine("Promedio: {0} \nMaximo: {1} \nMinimo: {2}", promedio, maximo, minimo);
            Console.ReadKey();
        }
    }
}

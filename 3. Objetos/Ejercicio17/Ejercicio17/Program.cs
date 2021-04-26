using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lapiceras;



namespace Ejercicio17
{
    class Program
    {      
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";
            string dibujo;
            Boligrafo colorAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo colorRojo = new Boligrafo(50, ConsoleColor.Red);
            Boligrafo colorVerde = new Boligrafo(10, ConsoleColor.Green);
            Boligrafo colorCeleste = new Boligrafo(0, ConsoleColor.Cyan);

            if (colorAzul.Pintar(4, out dibujo))
            {
                Console.WriteLine(dibujo);
            }
            if (colorVerde.Pintar(15, out dibujo))
            {
                Console.WriteLine(dibujo);
            }
            if (colorRojo.Pintar(50, out dibujo))
            {
                Console.WriteLine(dibujo);
            }
            if (colorCeleste.Pintar(15, out dibujo))
            {
                Console.WriteLine(dibujo);
            }
            else
            {
                Console.WriteLine("No hay suficiente tinta. Se procede con recarga de boligrafo");
                Console.WriteLine("Recarga realizada. Total tinta: {0}", colorCeleste.getTinta());
            }
            Console.ReadKey();
        }
    }
}

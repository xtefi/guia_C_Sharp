using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personas;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {            
            Alumno juan= new Alumno();
            Alumno maria = new Alumno();
            Alumno pedro = new Alumno();

            juan.setLegajo(101);
            juan.setNombreApellido("Juan", "Perez");
            juan.Estudiar(4, 3);

            maria.setLegajo(102);
            maria.setNombreApellido("Maria", "Jones");
            maria.Estudiar(4, 8);

            pedro.setLegajo(103);
            pedro.setNombreApellido("Pedro", "Flinstone");
            pedro.Estudiar(8, 8);

            juan.CalcularFinal();
            maria.CalcularFinal();
            pedro.CalcularFinal();

            Console.WriteLine(juan.Mostrar());
            Console.WriteLine(maria.Mostrar());
            Console.WriteLine(pedro.Mostrar());

            Console.ReadKey();            
        }
    }
}

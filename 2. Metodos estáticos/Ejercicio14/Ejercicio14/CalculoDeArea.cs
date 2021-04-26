using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }
        public static double CalcularTriangulo(double baseLong, double alturaLong)
        {
            return (baseLong * alturaLong) / 2;
        }
        public static double CalcularCirculo(double radio)
        {
            const float pi = 3.14f;
            double area;
            area = pi * (Math.Pow(radio, 2));
            return area;
        }
    }
}

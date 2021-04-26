using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = vertice1;            
            this.vertice4 = vertice3;

            float base1 = Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
            float altura = Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());

            this.area = base1 * altura;
            this.perimetro = (base1 + altura) * 2;
        }
        public float Area()
        {
            return this.area;
        }
        public float Perimetro()
        {
            return this.perimetro;
        }
        public void getVertices()
        {
            
        }
    }
}

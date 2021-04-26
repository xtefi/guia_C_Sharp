using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lapiceras
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private short tinta;
        private ConsoleColor color;

        //CONSTRUCTOR
        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        //GETTERS
        public ConsoleColor getColor()
        {
            return this.color;
        }

        public short getTinta()
        {
            return this.tinta;
        }
        //SETTERS
        private void SetTinta(short tinta)
        {
            if (getTinta() >= 0  && tinta > 0)
            {
                this.tinta -= tinta;
            }
            else if(getTinta() >= 0 && getTinta() <= cantidadTintaMaxima && tinta <= 0)
            {
                this.tinta += tinta;
            }            
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            bool pudoPintar;
            dibujo = "";
            Console.ForegroundColor = this.color;
            if (getTinta() > 0)
            {                
                if (getTinta() >= gasto)
                {
                    
                    Console.WriteLine("gasto: {0}", gasto);
                    Console.WriteLine("Tinta: {0}", getTinta());
                    short auxTinta = getTinta();                    
                    SetTinta(gasto);
                    dibujo = String.Concat(Enumerable.Repeat("*", gasto));                    
                }
                else if (getTinta() < gasto)
                {
                    short auxTinta = getTinta();
;                   dibujo = String.Concat(Enumerable.Repeat("*", getTinta()));                    
                    SetTinta(auxTinta--);
                }
                pudoPintar = true;
                Console.WriteLine("Total tinta: {0}", getTinta());
            }
            else pudoPintar = false;

            return pudoPintar;
        }
        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

    }
}

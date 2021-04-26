using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euros
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        //CONSUTRCTORES
        static Euros()
        {
            Euros.cotizRespectoDolar = 1 / 1.21f;
        }
        public Euros(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euros(double cantidad, double cotizacion)
            :this(cantidad)
        {
            Euros.cotizRespectoDolar = cotizacion;
        }
        //GETTERS
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }
        #region Conversiones
        public static implicit operator Euros(double d)
        {
            Euros aux= new Euros(d);
            return aux;
        }
        public static explicit operator Dolar(Euros p)
        {
            return new Dolar(p.cantidad / Euros.GetCotizacion());
        }
        public static explicit operator Pesos(Euros e)
        {
            return (Pesos)((Dolar)e);
        }
        #endregion

        #region Operaciones
        public static Euros operator +(Euros e, Dolar d)
        {
            Euros aux = new Euros(e.cantidad + ((Euros)d).cantidad);
            return aux;
        }
        public static Euros operator -(Euros e, Dolar d)
        {
            Euros aux = new Euros(e.cantidad - ((Euros)d).cantidad);
            return aux;
        }
        public static Euros operator +(Euros e, Pesos p)
        {
            Euros aux = new Euros(e.cantidad + ((Euros)p).cantidad);
            return aux;
        }
        public static Euros operator -(Euros e, Pesos p)
        {
            Euros aux = new Euros(e.cantidad + ((Euros)p).cantidad);
            return aux;
        }
        #endregion

        #region Comparaciones
        public static bool operator ==(Euros e1, Euros e2)
        {
            return (e1.cantidad == e2.cantidad);
        }
        public static bool operator !=(Euros e1, Euros e2)
        {
            return !(e1 == e2);
        }
        public static bool operator ==(Euros e, Dolar d)
        {
            return (e == (Euros)d);
        }
        public static bool operator !=(Euros e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator ==(Euros e, Pesos p)
        {
            return (e == (Euros)p);
        }
        public static bool operator !=(Euros e, Pesos p)
        {
            return !(e == p);
        }
        #endregion
    }
}

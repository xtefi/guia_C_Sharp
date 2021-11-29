using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{

    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        protected Franja franjaHoraria;

        public float CostoLlamada { get { return this.CalcularCosto(); } }

        public Provincial(Franja miFranja, Llamada llamada)
            :this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            :base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            float auxRetorno=0;

            switch(this.franjaHoraria)
            {
                case Franja.Franja_1:
                    auxRetorno= base.Duracion * (float)0.99;                    
                    break;
                case Franja.Franja_2:
                    auxRetorno = base.Duracion * (float)1.25;
                    break;
                case Franja.Franja_3:
                    auxRetorno = base.Duracion * (float)0.66;
                    break;
            }
            return auxRetorno;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo: {this.CostoLlamada}");
            return sb.ToString();
        }
    }
}

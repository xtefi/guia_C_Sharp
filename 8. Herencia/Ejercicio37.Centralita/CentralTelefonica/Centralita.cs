using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal { get { return CalcularGanancia(TipoLlamada.Local); } }
        public float GananciasPorProvincial { get { return CalcularGanancia(TipoLlamada.Provincial); } }
        public float GananciasPorTotal { get { return CalcularGanancia(TipoLlamada.Todas); } }
        public List<Llamada> Llamadas { get { return this.listaDeLlamadas; } }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;

            foreach (Llamada llamada in this.Llamadas)
            {
                if (llamada is Local)
                {
                    gananciaLocal += ((Local)llamada).CostoLlamada;
                }
                else if (llamada is Provincial)
                {
                    gananciaProvincial += ((Provincial)llamada).CostoLlamada;
                }
            }
            switch (tipo)
            {
                case TipoLlamada.Local:
                    {
                        return gananciaLocal;

                    }
                case TipoLlamada.Provincial:
                    {
                        return gananciaProvincial;
                    }
                default:
                    {
                        return gananciaLocal + gananciaProvincial;
                    }
            }
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon social: {this.razonSocial}");
            sb.AppendLine($"Ganancia por llamados total: {this.GananciasPorTotal}");
            sb.AppendLine($"Ganancia por llamado local: {this.GananciasPorLocal}");
            sb.AppendLine($"Ganancia por llamado provincial: {this.GananciasPorProvincial}");
            sb.AppendLine("LLAMADASSSSSSSSSSSSSSSSSSSS");

            foreach (Llamada llamada in this.Llamadas)
            {
                sb.AppendLine(llamada.ToString());
            }
            return sb.ToString();
        }

    }
}

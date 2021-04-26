using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        private string apellido;
        private int legajo;
        private string nombre;
       
        // GETTERS
        public string getNombreCompleto()
        {
            return $"{this.nombre} {this.apellido}";
        }

        public byte getNota1()
        {
            return nota1;
        }
        public byte getNota2()
        {
            return nota2;
        }
        public int getLegajo()
        {
            return legajo;
        }
        public float getNotaFinal()
        {
            return notaFinal;
        }
        // SETTERS
        public void setLegajo(int legajo)
        {
            this.legajo = legajo;
        }
        public void setNombreApellido(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        private void setNota1(byte nota1)
        {
            this.nota1 = nota1;
        }
        private void setNota2(byte nota2)
        {
            this.nota2 = nota2;
        }
        private void setNotaFinal(float notaFinal)
        {
            this.notaFinal = notaFinal;
        }
         

        public void CalcularFinal()
        {
            if(this.nota1 >= 4 && this.nota2 >= 4)
            {
                float auxNota = (nota1 + nota2) / 2;
                setNotaFinal(auxNota);
            }
            else
            {
                setNotaFinal(-1);
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {            
            setNota1(notaUno);            
            setNota2(notaDos);
        }

        public string Mostrar()
        {
            string retorno = $"Nombre: {this.nombre}, Legajo: {this.legajo}, Nota 1: {this.nota1}, Nota 2: {this.nota2}";
            if(this.notaFinal != -1)
            {
                retorno += $". Nota final: {this.notaFinal}";
            }
            else
            {
                retorno += ". Alumno desaprobado";
            }
            return retorno;
        }
    }
}

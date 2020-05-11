using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente:Personal
    {
        private double valorHora;

        public double ValorHora
        {
            get { return valorHora; }
            set { valorHora = value; }
        }

        public int HorasMensuales
        {
            get
            {
                double horasDiarias;
                horasDiarias = HoraSalida.Subtract(HoraEntrada).TotalHours;
                return (int)horasDiarias * 20;
            }
             
        }

        public Docente(string apellido, string nombre, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida, double valorHora) : base(apellido: apellido, nombre: nombre, dni: dni, femenino: femenino, horaEntrada: horaEntrada, horaSalida: horaSalida)
        {
            this.valorHora =valorHora;
        }

        public override double CalcularSalario()
        {
            // ojo, ver horas - ya estaroa reuelsto
           
            return HorasMensuales * ValorHora;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
           
            sb.AppendLine("Valor hora: $" + ValorHora);
          
            return sb.ToString();
        }

        

    }
}

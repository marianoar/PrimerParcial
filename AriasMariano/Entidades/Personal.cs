using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Personal : Persona
    {
        private DateTime horaEntrada = new DateTime() ;
        private DateTime horaSalida = new DateTime();
        //DateTime d = new DateTime(01,01,01,hora,00,00);
        //d.Hour devuelve la hora y con el metodo AddHours se puede restar o sumar

        protected Personal(string apellido, string nombre, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida) : base (apellido:apellido, nombre:nombre, dni:dni, femenino: femenino)
        {

            this.horaEntrada = horaEntrada;
            this.horaSalida = horaSalida;
        }

        public DateTime HoraEntrada
        {
            get { return horaEntrada; }
            set { horaEntrada = value; }
        }

        public DateTime HoraSalida
        {
            get { return horaSalida; }
            set { horaSalida = value; }
        }

        public double Salario
        {
            get { return this.CalcularSalario(); }
        }
        public abstract double CalcularSalario();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Horario: ");
            sb.AppendLine("Desde las "+ HoraEntrada.Hour.ToString() + " hasta las " + HoraSalida.Hour.ToString()+" hs."); 
            return sb.ToString();
        }
    }
}

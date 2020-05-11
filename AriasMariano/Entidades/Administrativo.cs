using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrativo:Personal
    {
        private ECargo cargo;
        static double SalarioBase;

        public ECargo Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        //Administrativo: 1 constructor estatico que setea el salarioBase = 30000 y 
        //uno de instancia por el cual se cargan todos los atributos que tiene un administrativo

        static Administrativo() { 
            SalarioBase = 30000;
        }

        public Administrativo(string apellido, string nombre, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida, ECargo cargo) : base(apellido: apellido, nombre: nombre, dni: dni, femenino: femenino, horaEntrada:horaEntrada, horaSalida: horaSalida)
        {
           this.cargo = cargo;
        }

        public override double CalcularSalario()
        {
            return SalarioBase * (int)Cargo / 100;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine(Cargo.ToString());
            return sb.ToString();
        }
    }
}

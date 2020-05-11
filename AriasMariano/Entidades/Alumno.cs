using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        const float cuota = 1250;
        private EColores colorSala;
        private int legajo;
        private float precioCuota = cuota;
        private Responsable responsable;

        public EColores ColorSala
        {
            get { return colorSala; }
            set { this.colorSala = value; }
        }
        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        public float PrecioCuota
        {
            get { return precioCuota; }
            set { precioCuota = value; }
        }
        public Responsable Responsable
        {
            get { return responsable; }
            set { responsable = value; }
        }

        public Alumno(string apellido, string nombre, int dni, bool femenino, float precioCuota) : base(apellido: apellido, nombre: nombre, dni: dni, femenino: femenino)
        {
            this.precioCuota = precioCuota;
        }
        
       public static implicit operator Responsable(Alumno al){
        return al.responsable;
            }
            
        public static bool operator == (Alumno a1, Alumno a2)
        {
            
            if ((a1.Legajo == a2.Legajo))// && ( ))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return (!(a1 == a2));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine(base.ToString());
            sb.AppendLine(colorSala.ToString());
            sb.AppendLine("Legajo Nº " + legajo.ToString());
            sb.AppendLine(precioCuota.ToString());
          //  sb.AppendLine(Responsable.ToString());
            return sb.ToString();
        }

        public override string Listar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Legajo Nº " + legajo.ToString());
            sb.AppendLine(" - "+base.Listar());
            sb.AppendLine(" - DNIº " + Dni.ToString());
            //  sb.AppendLine(Responsable.ToString());
            return sb.ToString();
        }

    }
}

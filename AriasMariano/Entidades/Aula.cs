using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{ 
    public class Aula
    {
        private List<Alumno> alumnos;
        private EColores colorSala;
        private Docente docente;
        private Eturno turno;

        public List<Alumno> Alumnos
        {
            get
            {
                return alumnos;
            }
            set
            {
                alumnos = value;
            }
        }
     
        public EColores ColorSala
        {
            get { return colorSala; }
            set { colorSala = value; }
        }
        public Docente Docente
        {
            get { return docente; }
            set { docente = value; }
        }
        public Eturno Turno
        {
            get { return turno; }
            set { turno = value; }
        }

        public Aula(EColores colorSala, Eturno turno, Docente docente)
        {
            this.colorSala = colorSala;
            this.turno = turno;
            this.docente = docente;
        }

        public static bool operator +(Aula aula, Alumno alumno)
        {
            for (int i = 0; i < aula.alumnos.Count; i++)
            {
                if (aula.alumnos[i] == alumno)
                {
                    return false;
                }
            }
            if(aula.alumnos.Count <= 30)
            { 
                aula.alumnos.Add(alumno);
                return true;   
            }
            return false;          
        }
        /// <summary>
        /// Sobrecarga del metodo toString 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Sala Color :"+ColorSala);
            sb.Append("  -  Turno : " + Turno);
            sb.Append("  -  Docente : " + Docente.Listar());
            return sb.ToString();
        }
    }
}

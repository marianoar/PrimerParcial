using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public abstract class Persona
   {
        private string apellido;
        private string nombre;
        private int dni;
        private bool femenino;
        
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public bool Femenino
        {
            get { return femenino; }
            set { femenino = value; }
        }

        protected Persona(string apellido, string nombre, int dni, bool femenino):this(apellido, nombre, dni)
        {
            this.femenino = femenino;
        }

        protected Persona(string apellido, string nombre, int dni)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Apellido: "+Apellido);
            sb.AppendLine("Nombre: "+Nombre);
            sb.AppendLine("DNI N°"+Dni.ToString());
            if (femenino)
            {
                sb.AppendLine(" - Femenino");
            }
            else { sb.AppendLine(" - Masculino");
            }
            return sb.ToString();
        }

        public virtual string Listar()
        {
            StringBuilder sb = new StringBuilder();
           
            sb.Append(" "+Apellido.ToString());
            sb.AppendLine(", "+Nombre.ToString());
          
            //  sb.AppendLine(Responsable.ToString());
            return sb.ToString();
        }


    }
}

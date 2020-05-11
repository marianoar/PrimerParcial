using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Responsable : Persona
    {
        private EParentesco parentesco;
        private string telefono;

        public EParentesco Parentesco
        {
            get { return parentesco; }
            set { parentesco = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public Responsable(string apellido, string nombre, int dni, bool femenino, EParentesco parentesco, string telefono):base(apellido:apellido, nombre:nombre, dni: dni, femenino:femenino)
        {
            this.parentesco = parentesco;
            this.telefono = telefono;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Listar());
            sb.AppendLine("; Relacion: "+parentesco.ToString());
            sb.AppendLine(" - Tel.: "+telefono.ToString());
         
            return sb.ToString();
        }



    }
}

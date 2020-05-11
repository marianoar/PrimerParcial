using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Arias.Mariano
{
    public partial class FrmBuscarAlumno : FrmReportes
    {
        List<Alumno> alumnos;
        public FrmBuscarAlumno(List<Alumno> alumnos) :this()
        {
            this.alumnos = alumnos;
        }
        public FrmBuscarAlumno()
        {
            InitializeComponent();
            
          
        }

        private void FrmBuscarAlumno_Load(object sender, EventArgs e)
        {
            SetFormBuscar();
            labelBuscar.Text = "Ingrese Apellido :";
          

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(textBuscar.Text)) || (textBuscar.Text.Length < 3))
            {
                MessageBox.Show("Verifique datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < alumnos.Count; i++)
                {
                    if(string.Equals(alumnos[i].Apellido, textBuscar.Text, StringComparison.CurrentCultureIgnoreCase))
                    { 
                        MessageBox.Show("Se ha encontrado al siguiente alumno/a:\n\n"+alumnos[i].ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                MessageBox.Show("No se han encontrado coincidencias.");
            }
        }
    }
}

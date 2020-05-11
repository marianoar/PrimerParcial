using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arias.Mariano
{
    public partial class FrmReportes : Form
    {
        List<Aula> aulas;
        List<Docente> docentes;
        List<Administrativo> administrativos;
        string auxiliar;

        public FrmReportes(string aux, List<Administrativo> administrativos) : this()
        {
            auxiliar = aux;
            this.administrativos = administrativos;
            cmbAulas.Visible = false;
            lblTitulo.Visible = false;
            lblSala.Visible = false;
            labelTituloAula.Visible = false;
        }

        public FrmReportes(string aux, List<Docente> docentes):this()
        {
            auxiliar = aux;
            this.docentes = docentes;
            cmbAulas.Visible = false;
            lblTitulo.Visible = false;
            lblSala.Visible = false;
            labelTituloAula.Visible = false;
        }
      
        public FrmReportes(string aux, List<Aula> aulas) : this()
        {
            auxiliar = aux;
            this.aulas = aulas;
            cmbAulas.Visible = true;
            lblTitulo.Visible = true;
            labelTituloAula.Visible = false;
            
            for (int i = 0; i < aulas.Count; i++)
            {
                cmbAulas.Items.Add(aulas[i].ToString());
            }

        }
        
        public FrmReportes(string aux, Aula aula) :this()
        {
            auxiliar = aux;
                        
            lblSala.Text = aula.ColorSala.ToString();
            lblSala.Visible = false;
            listBoxCentral.BackColor = Color.Lavender;
            labelTituloAula.Text = "Sala: " + aula.ColorSala.ToString() + " del turno: " + aula.Turno.ToString()+ " a cargo del/la docente: " + aula.Docente.Listar() ;
            for (int i = 0; i < aula.Alumnos.Count; i++)
            {
                listBoxCentral.Items.Add(aula.Alumnos[i].Listar());
            }
            cmbAulas.Visible = false;
            lblTitulo.Visible = false;
        }
        public FrmReportes()
        {
            InitializeComponent();
            btnCalcular.Visible = false;
            btnCalcular.Enabled = false;
        }

        private void FrmAula_Load(object sender, EventArgs e)
        {

            if (auxiliar == "verAula")
            {
                if (lblSala.Text == "Naranja")
                {
                    BackColor = Color.Orange;
                }
                else if (lblSala.Text == "Rojo")
                {
                    BackColor = Color.Red;
                }
                else if (lblSala.Text == "Amarilla")
                {
                    BackColor = Color.Yellow;
                }
                else if (lblSala.Text == "Verde")
                {
                    BackColor = Color.Green;
                }
            }
            else if (auxiliar == "reporteResp")
            {
                labelLista.Text = "Datos de Contacto de Responsables";

            }
            else if (auxiliar == "sueldoDocente")
            {

                labelLista.Text = "Lista de Salarios docentes";
                for (int i = 0; i < docentes.Count; i++)
                {
                    listBoxCentral.Items.Add(docentes[i].Listar() + " - $" + docentes[i].CalcularSalario());
                }
            }
            else if (auxiliar == "sueldoAdmin")
            {
                labelLista.Text = "Lista de Salarios Personal Administrativo";
                for (int i = 0; i < administrativos.Count; i++)
                {
                    listBoxCentral.Items.Add(administrativos[i].Listar() + " - " + administrativos[i].Cargo.ToString() + " $" + administrativos[i].CalcularSalario());
                }
            }
            else if (auxiliar == "recaudacionAula")
            {
                labelLista.Text = "Datos de Recaudacion por Aula";
            }
            else if (auxiliar == "recaudacionTotal")
            {
                labelTituloAula.Visible = false;
                lblTitulo.Visible = false;
                labelLista.Visible = true;
                labelLista.Text = "Recaudacion total del Jardin";
                listBoxCentral.Visible = false;
                cmbAulas.Visible = false;
                btnCalcular.Visible = true;
                btnCalcular.Enabled = true;
                labelTituloPpal.Visible = true;
                iconLogo.Visible = true;
            }
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
                int acumulador = 0;
                int cuota;

                for (int i = 0; i < aulas.Count; i++)
                {
                    for (int j = 0; j < aulas[i].Alumnos.Count; j++)
                    {
                        //listBoxCentral.Items.Add("Alumno Legajo N°" + aulas[cmbAulas.SelectedIndex].Alumnos[i].Legajo.ToString() + " Valor cuota $" + aulas[cmbAulas.SelectedIndex].Alumnos[i].PrecioCuota.ToString());
                        cuota = (int)aulas[i].Alumnos[j].PrecioCuota;
                        acumulador = cuota + acumulador;
                    }
                }
                MessageBox.Show("La recaudacion total fue de $" + acumulador.ToString());
        }

        private void cmbAulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (auxiliar == "reporteResp")
            {
               // richTextBoxPadres.
                listBoxCentral.Items.Clear();
                for (int i = 0; i < aulas[cmbAulas.SelectedIndex].Alumnos.Count; i++)
                {
                    listBoxCentral.Items.Add("Alumno Legajo N°"+ aulas[cmbAulas.SelectedIndex].Alumnos[i].Legajo+" - "+aulas[cmbAulas.SelectedIndex].Alumnos[i].Responsable.ToString());
                }
            }
            else if (auxiliar == "sueldoDocente")
            {
                listBoxCentral.Items.Clear();
                for (int i = 0; i < docentes.Count; i++)
                {
                    listBoxCentral.Items.Add(docentes[i].CalcularSalario().ToString());

                }
            }else if (auxiliar =="recaudacionAula")
            {
                int acumulador=0;
                int cuota;
                listBoxCentral.Items.Clear();
                for (int i = 0; i < aulas[cmbAulas.SelectedIndex].Alumnos.Count; i++)
                {
                    listBoxCentral.Items.Add("Alumno Legajo N°"+aulas[cmbAulas.SelectedIndex].Alumnos[i].Legajo.ToString()+" Valor cuota $"+ aulas[cmbAulas.SelectedIndex].Alumnos[i].PrecioCuota.ToString());
                    cuota = (int)aulas[cmbAulas.SelectedIndex].Alumnos[i].PrecioCuota;
                    acumulador = cuota+acumulador;
                }

                MessageBox.Show("La recaudacion de esta sala es de $" + acumulador.ToString());

            }
            
        }
      
        /// <summary>
        /// Cierro el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}

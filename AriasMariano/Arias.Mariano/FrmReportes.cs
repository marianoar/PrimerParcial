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
        #region Constructores, cada cosntructor recibe un tipo de lista y un string auxiliar, en funcion del contenido del string se ejecutan partes del Load
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
            labelTituloJardin.Visible = true;
        }
        #endregion

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
                labelLista.Location = new System.Drawing.Point(165, 175);
                labelLista.Text = "Datos de Contacto de Responsables";

            }
            else if (auxiliar == "sueldoDocente")
            {
                labelLista.Location = new System.Drawing.Point(200, 175);
                labelLista.Text = "Lista de Salarios docentes";
                for (int i = 0; i < docentes.Count; i++)
                {
                    listBoxCentral.Items.Add(docentes[i].Listar() + " - $" + docentes[i].CalcularSalario());
                }
            }
            else if (auxiliar == "sueldoAdmin")
            {
                labelLista.Location = new System.Drawing.Point(165, 175);
                labelLista.Text = "Lista de Salarios Personal Administrativo";
                for (int i = 0; i < administrativos.Count; i++)
                {
                    listBoxCentral.Items.Add(administrativos[i].Listar() + " - " + administrativos[i].Cargo.ToString() + " $" + administrativos[i].CalcularSalario());
                }
            }
            else if (auxiliar == "recaudacionAula")
            {
                labelLista.Location = new System.Drawing.Point(175, 175);
                labelLista.Text = "Datos de Recaudacion por Aula";
            }
            else if (auxiliar == "recaudacionTotal")
            {
                labelTituloAula.Visible = false;
                lblTitulo.Visible = false;
                labelLista.Visible = true;
                labelLista.Location = new System.Drawing.Point(165, 175);
                labelLista.Text = "Recaudacion total del Jardin";
               // this.labelLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                listBoxCentral.Visible = false;
                cmbAulas.Visible = false;
                btnCalcular.Visible = true;
                btnCalcular.Enabled = true;
                labelTituloJardin.Visible = true;
            }
        }

        /// <summary>
        /// Recorro la lista de alumnos del aula  y acumulo el valor de las cuotas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        protected virtual void cmbAulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (auxiliar == "reporteResp")
            {
               
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
        /// Este metodo se llama desde el load del FormBuscarAlumnos y setea los controles en el form derivado
        /// </summary>
        protected void SetFormBuscar()
        {
            cmbAulas.Visible = false;
            listBoxCentral.Visible = false;
            labelTituloAula.Visible = false;
            labelLista.Visible = false;
            labelTituloJardin.Visible = false;
            lblTitulo.Location = new System.Drawing.Point(250,25);
            lblTitulo.BackColor = Color.CadetBlue;
            lblTitulo.Text = "Busqueda de Alumnos por Apellido";
            btnCerrar.Location = new System.Drawing.Point(300, 250);
            pictureBoxImg.Visible = false;
        }

        protected void SetFormVideos()
        {
            cmbAulas.Visible = true;
            listBoxCentral.Visible = false;
            labelTituloAula.Visible = true;
            labelLista.Visible = false;
            labelTituloJardin.Visible = true;
            lblSala.Visible = false;
            lblTitulo.Text = "Seleccione un video para reproducir";
            lblTitulo.Location = new System.Drawing.Point(175, 100);
            pictureBoxImg.Visible = true; ;
        }

        /// <summary>
        /// Cierro el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}

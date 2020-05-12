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
    public partial class FrmAdministrarAula : Form
    {
        Aula aula;
        List<Alumno> alumnosEnAulaLista;
        List<Docente> docentesLista;
        List<Alumno> alumnosSinAula;
        bool esModificar = false;
        
        /*
        public FrmAdministrarAula(Aula aula, int indice, List<Docente> docentes, List<Alumno> alumnosLista;):this(docentesLista:docentes, alumnosLista:alumnos)
        {
            esModificar = true;
            i = indice;

            btnAceptar.Text = "Guardar Cambios";
            labelIndice.Text = indice.ToString();

            lblSala.Text = aula.ColorSala.ToString();
            lblSala.Visible = false;
            labelTituloAula.Text = "Usted está en sala " + aula.ColorSala.ToString() + " del turno " + aula.Turno.ToString() + " a cargo del/la docente " + aula.Docente.Listar();
            Text = "Modificacion de aula";

            cmbSalita.Text =aula.ColorSala.ToString();
            cmbTurno.Text = aula.Turno.ToString();
            cmbDocentes.Text = aula.Docente.Listar();

            for (int i = 0; i < aula.Alumnos.Count; i++)
            {
                listBoxAlumnosEnAula.Items.Add(aula.Alumnos[i].Listar());
            }
           

        }*/
        #region Constructores
        public FrmAdministrarAula(List<Docente> docentesLista, List<Alumno> alumnos) :this()
        {     
            alumnosEnAulaLista =  new List<Alumno>();
            this.docentesLista = new List<Docente>(docentesLista); // innecesario?
            this.alumnosSinAula = new List<Alumno>(alumnos);
        }
        public FrmAdministrarAula()
        {
            InitializeComponent();
        }
        #endregion
        #region Propiedades
        public List<Alumno> AlumnoSinAula
        {
            get { return alumnosSinAula; }
            set { alumnosSinAula = value; }
        }
        public List<Docente> DocentesLista
        {
            get { return docentesLista; }
            set { docentesLista = value; }
        }
         public List<Alumno> AlumnosEnAulaLista
        {
            get { return alumnosEnAulaLista; }
            set { alumnosEnAulaLista = value; }
        }
        public Aula NuevaAula
        {
            get { return aula; }
            set { aula = value; }
        }
        #endregion

        private void Aula_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < docentesLista.Count; i++) // 
            {
                cmbDocentes.Items.Add(this.docentesLista[i].Listar());
            }
            foreach (var item in Enum.GetValues(typeof(EColores)))
            {
                cmbSalita.Items.Add(item);
            }

            foreach (var item in Enum.GetValues(typeof(Eturno)))
            {
                cmbTurno.Items.Add(item);
            }
           
            RecargarListas();
            BackColor = Color.Honeydew;          
        }
        /// <summary>
        /// Agrego un Alumno desde la lista de alumnos sin aula a la lista de alumnosesta aula.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (listBoxAlumnos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un alumno");
            }
            else
            {
                if (alumnosEnAulaLista.Count < 31)
                {
                    MessageBox.Show("Estas agregando al alumno/a: \n" + alumnosSinAula[listBoxAlumnos.SelectedIndex].ToString());
                      
                    alumnosEnAulaLista.Add(alumnosSinAula[listBoxAlumnos.SelectedIndex]);
                    alumnosSinAula.Remove(alumnosSinAula[listBoxAlumnos.SelectedIndex]);
                    RecargarListas();
                }
                else
                {
                    MessageBox.Show("La capacidad del aula esta completa. Pueden haber hasta 30 alumnoas/as.");
                }
            }
        }


        /// <summary>
        /// Remueve un alumno de la lista del nuevo aula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSacarAlumno_Click(object sender, EventArgs e)
        {
            if (listBoxAlumnosEnAula.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un alumno");
            }
            else
            {
                alumnosSinAula.Add(alumnosEnAulaLista[listBoxAlumnosEnAula.SelectedIndex]);
                alumnosEnAulaLista.Remove(alumnosEnAulaLista[listBoxAlumnosEnAula.SelectedIndex]);
                RecargarListas();
            }    
        }

        /// <summary>
        /// Cambia el color de fondo en funcion de item seleccionado en el combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalita_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbSalita.SelectedIndex == 0)
            {
                BackColor = Color.Orange;
            }else if(cmbSalita.SelectedIndex ==1)
            {
                BackColor = Color.Red;
            }else if(cmbSalita.SelectedIndex == 2)
            {
                BackColor = Color.Yellow;
            }
            else if(cmbSalita.SelectedIndex ==3)
            {
                BackColor = Color.Green;
            }
        }
        /// <summary>
        /// Creo nueva Aula previo validaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!esModificar)
            {

                if((cmbSalita.SelectedIndex != 0) && (cmbSalita.SelectedIndex != 1) && (cmbSalita.SelectedIndex != 2) && (cmbSalita.SelectedIndex != 3))
                {
                    MessageBox.Show("Debe seleccionar sala");
                    return;
                }else if (cmbTurno.SelectedIndex == -1)
                {
                     MessageBox.Show("Debe seleccionar turno");
                    return;
                }else if (cmbDocentes.SelectedIndex == -1)
                {
                     MessageBox.Show("Debe elegir un Docente");
                     return;
                }
            for (int i = 0; i < alumnosEnAulaLista.Count; i++)
                {
                    alumnosEnAulaLista[i].ColorSala =(EColores)cmbSalita.SelectedItem;
                }

            aula = new Aula((EColores)cmbSalita.SelectedItem, (Eturno)cmbTurno.SelectedItem, docentesLista[cmbDocentes.SelectedIndex]);
            aula.Alumnos = new List<Alumno>();    
            for (int i = 0; i < alumnosEnAulaLista.Count; i++)
            {
            // Utiliza la sobrecarga del operador +, verifica la cantidad < 30 y que no se repita 
                    if(aula + alumnosEnAulaLista[i]) 
                    {
                        continue;
                    }
                    else
                    {
                        MessageBox.Show("Error, el alumno ya se encuentra en el aula o el Aula ha llegado al limite de alumno.");
                    }
                }
            MessageBox.Show("Se ha creado una nueva aula.");
            this.DialogResult = DialogResult.OK;
            }
        }
        /// <summary>
        /// Muestra las listas de alumnos en los dos ListBox
        /// </summary>
        private void RecargarListas()
        {
            listBoxAlumnosEnAula.Items.Clear();
            for (int i = 0; i < alumnosEnAulaLista.Count; i++)
            {
                listBoxAlumnosEnAula.Items.Add(alumnosEnAulaLista[i].Listar());
            }
            listBoxAlumnos.Items.Clear();
            for (int i = 0; i < alumnosSinAula.Count; i++)
            {
                listBoxAlumnos.Items.Add(alumnosSinAula[i].Listar());
            }
        }
        /// <summary>
        /// Cierro el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

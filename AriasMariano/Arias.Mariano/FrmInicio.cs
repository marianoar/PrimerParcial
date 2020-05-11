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
    public partial class FrmInicio : Form
    {
        private static List<Docente> docentesLista;
        private static List<Docente> docentesSinSala;
        private static List<Administrativo> adminLista;
        private static List<Alumno> alumnosLista;
        private static List<Alumno> alumnosSinSala;
        private static List<Responsable> responsablesLista;
        private static List<Aula> aulasLista;      
       
        private int numeroLegajo;

        //string.IsNullOrEmpty(this.textBox1.Text) 
        bool flagSetPrueba = false;
        public FrmInicio()
        {
            InitializeComponent();
            BackColor = Color.Lavender;
            ForeColor = Color.DarkBlue;
            numeroLegajo = 1001;
            
            btnModificar.Enabled = false;
        }

        static FrmInicio()
        {
            docentesLista = new List<Docente>();

            docentesSinSala = new List<Docente>();

            alumnosLista = new List<Alumno>();

            alumnosSinSala = new List<Alumno>();

            aulasLista = new List<Aula>();

            adminLista = new List<Administrativo>();

            responsablesLista = new List<Responsable>();
        }
        public List<Docente> DocenteLista
        {
            get { return docentesLista; }
            set { docentesLista = value; }
        }

       // public List<Responsable> ResponsablesLista
        public int Legajo
        {
            get { return numeroLegajo; }
            set { numeroLegajo = value; }
        }
        private void altaDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string alta = "Docente";
            DialogResult resultado;
            FrmAltaPersona frmAltaDocente = new FrmAltaPersona(alta);
            resultado=frmAltaDocente.ShowDialog();
            if(resultado == DialogResult.OK)
            {
                docentesLista.Add(frmAltaDocente.NuevoDocente);
                docentesSinSala.Add(frmAltaDocente.NuevoDocente);
                MessageBox.Show("Se ha ingresado a la siguiente persona como Docente: \n" + frmAltaDocente.NuevoDocente.ToString());
            }
           
        }
        private void altaNoDocenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string alta = "No Docente";
            DialogResult resultado;
            FrmAltaPersona frmAltaNoDocente = new FrmAltaPersona(alta);
            resultado=frmAltaNoDocente.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                adminLista.Add(frmAltaNoDocente.NuevoNoDocente);
                MessageBox.Show("Se ha ingresado a la siguiente persona como Personal No Docente: \n\n"+frmAltaNoDocente.NuevoNoDocente.ToString());
            }
        }

        private void altaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            DialogResult resultado;
            FrmAltaAlumno frmAltaAlumno = new FrmAltaAlumno();
            resultado=frmAltaAlumno.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                frmAltaAlumno.NuevoAlumno.Legajo = numeroLegajo;
                alumnosLista.Add(frmAltaAlumno.NuevoAlumno);
                Legajo++;

                alumnosSinSala.Add(frmAltaAlumno.NuevoAlumno);
                
                responsablesLista.Add(frmAltaAlumno.NuevoAlumno.Responsable);
                MessageBox.Show("Alta de alumno exitosa. ");
            }
        }
    
        private void altaAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            if(docentesSinSala.Count== 0)
            {
                MessageBox.Show("No hay docentes disponibles.");
                return;
            }
            FrmAdministrarAula frmAula = new FrmAdministrarAula(docentesSinSala, alumnosSinSala);
            resultado=frmAula.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                aulasLista.Add(frmAula.NuevaAula);
                docentesSinSala.Remove(frmAula.NuevaAula.Docente);
                alumnosSinSala = frmAula.AlumnoSinAula;
                /*
                listBoxNominaAulas.Items.Clear();

                for (int i = 0; i < aulasLista.Count; i++)
                {
                    listBoxNominaAulas.Items.Add(aulasLista[i].ToString());
                }*/
            }
        }

        private void cargarPruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (!flagSetPrueba)
            {
                flagSetPrueba = CargarPrueba();
            }
            else
            {
                 MessageBox.Show("Los datos ya fueron cargados");
            }
            listBoxNominaAulas.Items.Clear();

            for (int i = 0; i < aulasLista.Count; i++)
            {
                listBoxNominaAulas.Items.Add(aulasLista[i].ToString());
            }

        }
       
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            listBoxNominaAulas.Items.Clear();

            for (int i = 0; i < aulasLista.Count; i++)
            {
                listBoxNominaAulas.Items.Add(aulasLista[i].ToString());
            }
        }
        /// <summary>
        /// Abre un nueva ventana para ver contenido del aula seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeleccionar_Click(object sender, EventArgs e) // Boton Ver Aula
        {
            string aux = "verAula";
            int indice = listBoxNominaAulas.SelectedIndex;
            if (indice != -1)
            {
                FrmReportes frmAula = new FrmReportes(aux, aulasLista[indice]);
                
                frmAula.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un aula");
            }

        }
        /*
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = listBoxNominaAulas.SelectedIndex;
            if (indice != -1)
            {

               // FrmAdministrarAula frmModificar = new FrmAdministrarAula(aulasLista[indice], indice);
                //  FrmAula frmAula = new FrmAula(indice,  aulasLista[listBoxNominaAulas.SelectedIndex].ColorSala.ToString(), aulasLista[listBoxNominaAulas.SelectedIndex].Turno.ToString(), aulasLista[listBoxNominaAulas.SelectedIndex].Docente.Listar()); ;
              //  frmModificar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un aula");
            }
            */
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = listBoxNominaAulas.SelectedIndex;
            if (indice != -1)
            {
                aulasLista.Remove(aulasLista[indice]);
                MessageBox.Show("El aula seleccionada ha sido eliminada");

                listBoxNominaAulas.Items.Clear();

                for (int i = 0; i < aulasLista.Count; i++)
                {
                    listBoxNominaAulas.Items.Add(aulasLista[i].ToString());
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un aula");
            }

        }

        private void informacionPadresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporte="reporteResp";
            FrmReportes frmReportes = new FrmReportes(reporte, aulasLista);
            frmReportes.ShowDialog();

        }
        private void sueldoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporte = "sueldoDocente";
            FrmReportes frmReportes = new FrmReportes( reporte, docentesLista);
            frmReportes.ShowDialog();
        }

        private void sueldoNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporte = "sueldoAdmin";
            FrmReportes frmReportes = new FrmReportes(reporte, adminLista);
            frmReportes.ShowDialog();

        }

        private void recaudacionPorAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporte = "recaudacionAula";
            FrmReportes frmReportes = new FrmReportes(reporte, aulasLista);
            frmReportes.ShowDialog();
        }

        private void recaudacionTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reporte = "recaudacionTotal";
            FrmReportes frmReportes = new FrmReportes(reporte, aulasLista);
            frmReportes.ShowDialog();
        }
        /// <summary>
        /// Carga datos en alumnos, docentes y padres para realizar pruebas
        /// </summary>
        /// <returns></returns>
        public bool CargarPrueba()
        {
            #region Cargo datos de 6 docentes
            int horaEntrada = 9;
            int horaSalida = 16;
            DateTime entrada = new DateTime(01, 01, 01, horaEntrada, 00, 00);
            DateTime salida = new DateTime(01, 01, 01, horaSalida, 00, 00);
            Random dni = new Random();

            Docente docente1 = new Docente("Zarate", "Laura", dni.Next(10000000, 35000000), true, entrada, salida, 250);
            Docente docente2 = new Docente("Alsina", "Laura", dni.Next(10000000, 35000000), true, entrada, salida, 250);
            Docente docente3 = new Docente("Arias", "Mariano", dni.Next(10000000, 35000000), false, entrada, salida, 315);
            Docente docente4 = new Docente("Gomez", "Oscar", dni.Next(10000000, 35000000), false, entrada, salida, 250);
            Docente docente5 = new Docente("Simpson", "Homero", dni.Next(10000000, 35000000), false, entrada, salida, 275);
            Docente docente6 = new Docente("Potus", "Juan", dni.Next(10000000, 35000000), false, entrada, salida, 255);
            docentesLista.Add(docente1);
            docentesSinSala.Add(docente1);
           
            docentesLista.Add(docente2);
            docentesSinSala.Add(docente2);
            docentesLista.Add(docente3);
            docentesSinSala.Add(docente3);
            docentesLista.Add(docente4);
            docentesSinSala.Add(docente4);
            docentesLista.Add(docente5);
            docentesSinSala.Add(docente5);
            docentesLista.Add(docente6);
            docentesSinSala.Add(docente6);
            #endregion
            #region Cargo datos personal administrativos
            horaEntrada = 6;
            horaSalida = 13;
             entrada = new DateTime(01, 01, 01, horaEntrada, 00, 00);
             salida = new DateTime(01, 01, 01, horaSalida, 00, 00);

            Administrativo admin = new Administrativo("Perez", "Juan", 12321123, true, entrada, salida, ECargo.Direccion);
            adminLista.Add(admin);
            horaEntrada = 8;
            horaSalida = 17;
            entrada = new DateTime(01, 01, 01, horaEntrada, 00, 00);
            salida = new DateTime(01, 01, 01, horaSalida, 00, 00);

            Administrativo adminA = new Administrativo("Bicicleta", "Juan", 12321123, false, entrada, salida, ECargo.Porteria);
            adminLista.Add(adminA);
            Administrativo adminB = new Administrativo("Gomez", "Maria", 12321123, true, entrada, salida, ECargo.Porteria);
            adminLista.Add(adminB);
            Administrativo adminC = new Administrativo("Danke", "Lucas", 12321123, false, entrada, salida, ECargo.Cocina);
            adminLista.Add(adminC);
            Administrativo adminD = new Administrativo("Celu", "Lorena", 12321123, true, entrada, salida, ECargo.Tesoreria);
            adminLista.Add(adminD);
            for (int i = 1; i < 6; i++)
            {
                Administrativo nuevoAdmin = new Administrativo("apellido" + i.ToString(), "Name" + i.ToString(), dni.Next(10000000, 40000000), true, entrada, salida, ECargo.Secretaria);
                adminLista.Add(nuevoAdmin);
            }
            #endregion
            #region Creo un mismo responsable para todos los alumnos
            Responsable responsableGenerico = new Responsable("White", "Walter", 10755999, false, EParentesco.Otro, "1155886699");
            responsablesLista.Add(responsableGenerico);
            #endregion

            for (int i = 1; i < 51; i++)
             {
               Alumno alumno = new Alumno("Apellido"+i.ToString(), "Nombre"+i.ToString(), dni.Next(45000000,52000000), true, 1250);
               alumno.Responsable = responsableGenerico;
               alumno.Legajo = numeroLegajo;
               numeroLegajo++;
               alumnosLista.Add(alumno);
               alumnosSinSala.Add(alumno);
            }

            Aula aula1 = new Aula(EColores.Amarilla, Eturno.Tarde, docentesLista[4]);
            docentesSinSala.Remove(docentesLista[4]);

            List<Alumno> listaAuxiliar = new List<Alumno>();
            for (int i = 0; i < 30; i+=3)
            {
                listaAuxiliar.Add(alumnosSinSala[i]);
 
                listaAuxiliar.Last<Alumno>().ColorSala = aula1.ColorSala;
                alumnosSinSala.Remove(alumnosSinSala[i]);
            }
            aula1.Alumnos = listaAuxiliar;
            aulasLista.Add(aula1);

            Aula aula2 = new Aula(EColores.Rojo, Eturno.Mañana, docentesLista[0]);
            docentesSinSala.Remove(docentesLista[0]);
            listaAuxiliar = new List<Alumno>();
            for (int i = 34; i < 37; i++)
            {
                listaAuxiliar.Add(alumnosSinSala[i]);

                listaAuxiliar.Last<Alumno>().ColorSala = aula2.ColorSala;
                alumnosSinSala.Remove(alumnosSinSala[i]);
            }
            aula2.Alumnos = listaAuxiliar;
            aulasLista.Add(aula2);

            Aula aula3 = new Aula(EColores.Verde, Eturno.Mañana, docentesLista[2]);
            docentesSinSala.Remove(docentesLista[2]);
            listaAuxiliar = new List<Alumno>();
            for (int i = alumnosSinSala.Count-6; i < alumnosSinSala.Count-3; i++)
            {
                listaAuxiliar.Add(alumnosSinSala[i]);
                listaAuxiliar.Last<Alumno>().ColorSala = aula1.ColorSala;
                alumnosSinSala.Remove(alumnosSinSala[i]);
            }
            aula3.Alumnos = listaAuxiliar;
            aulasLista.Add(aula3);
            return true;

        }

        #region metodos Cerrar programa
        /// <summary>
        /// Cierra el programa desde el boton Cerrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Cierra el programa desde el ToolStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}

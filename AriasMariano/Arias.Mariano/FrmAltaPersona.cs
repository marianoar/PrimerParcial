using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arias.Mariano
{
    public partial class FrmAltaPersona : Form
    {
        string tipoPersona;

        Docente nuevoDocente;
        Administrativo nuevoNoDocente;

        public Docente NuevoDocente
        {
            get { return nuevoDocente; }
            set { nuevoDocente = value; }
        }
        public Administrativo NuevoNoDocente { 
            get { return nuevoNoDocente; }
            set { nuevoNoDocente = value; }
        }

        public FrmAltaPersona(string quien):this()
        {
            this.tipoPersona = quien;
            Text = Text + quien;

            if (quien == "Docente")
            {

                groupBoxHorario.Visible = true;
                groupBoxHorario.Enabled = true;
                labelValorHora.Visible = true;
                labelValorHora.Enabled = true;
                txtValorHora.Visible = true;
                txtValorHora.Enabled = true;
             
            }
            else if (quien == "No Docente")
            {
                groupBoxHorario.Visible = true;
                groupBoxHorario.Enabled = true;
   
                labelVarios.Visible = true;
          
                cmbVarios.Visible = true;
                labelVarios.Enabled = true; //Cargo :
                labelVarios2.Enabled = false;
                labelVarios2.Visible = false;
                
                txtValorHora.Visible = false;
                txtVarios.Enabled = true;
                cmbVarios.Enabled = true;
                labelVarios.Text = "Cargo";
                foreach (var item in Enum.GetValues(typeof(ECargo)))
                {
                    cmbVarios.Items.Add(item);
                }
            }

        }
        public FrmAltaPersona()
        {
            InitializeComponent();
            BackColor = Color.WhiteSmoke;
            Text = "Formulario de Alta de ";
            groupBoxHorario.Text = "Horario (en enteros entre las 6hs y 24hs )";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool femeninoAux = false;
            int dni;
            if ((string.IsNullOrWhiteSpace(txtApellido.Text)) || (string.IsNullOrWhiteSpace(txtNombre.Text))
                   || (string.IsNullOrWhiteSpace(txtDni.Text)) || (string.IsNullOrWhiteSpace(txtEntrada.Text)) 
                   || (string.IsNullOrWhiteSpace(txtSalida.Text))) 
            {
                MessageBox.Show("Se encontraron datos sin completar");
                return;
            }
            if (txtDni.Text.Length != 8)
            {
                MessageBox.Show("El numero de DNI ingresado no tiene la cantidad correcta de  digitos.");
                return;
            }
            if (!int.TryParse(txtDni.Text, out dni))
            {
                MessageBox.Show("El campo DNI solo acepta numeros");
                return;
            }

            int horaEntrada;
            int horaSalida; ;
            if (!int.TryParse(txtEntrada.Text, out horaEntrada))
            {
                MessageBox.Show("El campo Horas solo acepta numeros");
                return;
            }
            if (!int.TryParse(txtSalida.Text, out horaSalida))
            {
                MessageBox.Show("El campo Horas solo acepta numeros");
                return;
            }
         

            DateTime entrada = new DateTime(01, 01, 01, horaEntrada, 00, 00);
            DateTime salida = new DateTime(01, 01, 01, horaSalida, 00, 00);

            if (horaSalida <= horaEntrada)
            {
                MessageBox.Show("La hora de salida no puede ser menor o igual a la hora de entrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if ((horaEntrada < 6) || (horaSalida > 24))
            {
                MessageBox.Show("Revise hora de ingreso o egreso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar genero.");
                return;
            }
            if (cmbGenero.SelectedItem.ToString() == "Femenino")
            {
                femeninoAux = true;
            }
            if (tipoPersona == "Docente")
            {
                if (string.IsNullOrWhiteSpace(txtValorHora.Text))
                {
                    MessageBox.Show("Se encontraron datos sin completar");
                    return;
                }
                double valorHora;
                if (!double.TryParse(txtValorHora.Text, out valorHora))
                {
                    MessageBox.Show("El campo Valor Horas solo acepta numeros");
                    return;
                }

                nuevoDocente = new Docente(txtApellido.Text, txtNombre.Text, dni, femeninoAux, entrada, salida, valorHora);
                
                DialogResult = DialogResult.OK;
            }else if (tipoPersona == "No Docente")
            {
                if (cmbVarios.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar Cargo");
                    return;
                }
                nuevoNoDocente = new Administrativo(txtApellido.Text, txtNombre.Text, dni, femeninoAux, entrada, salida, (ECargo)cmbVarios.SelectedItem);
                this.DialogResult = DialogResult.OK;
            }
        }
    
        /// <summary>
        /// Cierro eeste formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

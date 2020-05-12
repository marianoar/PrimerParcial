using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Arias.Mariano
{
    public partial class FrmAltaAlumno : Form
    {
        Alumno nuevoAlumno;
        Responsable nuevoResponsable;
        bool flagResponsable;
       
        public FrmAltaAlumno()
        {
            InitializeComponent();  
        }
        #region Propiedades
        public Alumno NuevoAlumno
        {
            get { return nuevoAlumno; }
            set { nuevoAlumno = value; }
        }

        public Responsable NuevoResponsable
        {
            get { return nuevoResponsable; }
            set { nuevoResponsable = value; }
        }
        #endregion
        private void FrmAltaAlumno_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(EParentesco)))
            {
                cmbBoxRelacion.Items.Add(item);
            }
            btnResponsable.Visible = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
                if((string.IsNullOrWhiteSpace(txtApellido.Text)) || (string.IsNullOrWhiteSpace(txtNombre.Text))
                    ||(string.IsNullOrWhiteSpace(txtDni.Text)) || (string.IsNullOrWhiteSpace(txtCuota.Text)))  
                {
                    MessageBox.Show("Se encontraron datos sin completar");
                    return;
                }
                if((txtApellido.Text.Length<3) || (txtNombre.Text.Length<3) || (txtApellido.Text.Length>20) || (txtNombre.Text.Length>20)){
                    MessageBox.Show("Apellido o Nombre no pueden contener menos de 3 o mas de 20 caracteres");
                    return;
                }
          
                bool femeninoAux = false;
            if (cmbGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar genero");
                return;
            }
                if (cmbGenero.SelectedItem.ToString() == "Femenino")
                {
                    femeninoAux = true;
                }
                int dni;
                if ((txtDni.Text.Length != 8)||(txtDniResp.Text.Length!=8))
                {
                    MessageBox.Show("El numero de DNI ingresado no tiene la cantidad correcta de  digitos.");
                    return;
                }
                if (!int.TryParse(txtDni.Text, out dni)){
                    MessageBox.Show("El campo DNI solo acepta numeros");
                    return;
                }
                float cuota;
                if (!float.TryParse(txtCuota.Text, out cuota))
                {
                    MessageBox.Show("El campo Cuota solo acepta numeros");
                    return;
                }
                if (cmbGenero.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar genero.");
                    return;
                }


            nuevoAlumno = new Alumno(txtApellido.Text, txtNombre.Text, dni, femeninoAux, cuota);
            if (!flagResponsable)
            {
                MessageBox.Show("Recuerde cargar datos del adulto responsable del Alumno");
                return;
            }
            else
            {
                int dniR;
                   if((string.IsNullOrWhiteSpace(txtApellidoResp.Text) || string.IsNullOrWhiteSpace(txtNombreResp.Text)
                        || string.IsNullOrWhiteSpace(txtDniResp.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text)))
                {
                    MessageBox.Show("Se encontraron datos sin completar");
                    return;
                }
                if( (txtApellidoResp.Text.Length < 3) || (txtNombreResp.Text.Length < 3) || (txtApellidoResp.Text.Length>20) || (txtNombreResp.Text.Length>20))
                {
                    MessageBox.Show("Apellido o Nombre no pueden contener menos de 3 o mas de 20 caracteres");
                    return;
                }
                    if (!int.TryParse(txtDniResp.Text, out dniR))
                {
                    MessageBox.Show("El campo DNI solo acepta numeros");
                    return;
                }
                if (cmbBoxGeneroResp.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar genero.");
                    return;
                }
                if (cmbBoxGeneroResp.SelectedItem.ToString() == "Femenino")
                {
                    femeninoAux = true;
                }
                if (txtTelefono.Text.Length < 6)
                {
                    MessageBox.Show("El campo telefono requiere al menos 6 numeros");
                    return;
                }
                int aux;
                if (!int.TryParse(txtTelefono.Text, out aux))
                {
                    MessageBox.Show("El campo Telefono solo acepta numeros");
                    return;
                }

                nuevoResponsable = new Responsable(txtApellidoResp.Text, txtNombreResp.Text, dniR, femeninoAux, (EParentesco)cmbBoxRelacion.SelectedItem, txtTelefono.Text);
                nuevoAlumno.Responsable = nuevoResponsable;

                DialogResult = DialogResult.OK;
            }
        }

     /// <summary>
     /// Habilita los txtBox para cargar Responsable de Alumnon
     /// </summary>
     /// <param name="sender"></param>
     /// <param name="e"></param>
        private void btnResponsable_Click(object sender, EventArgs e)
        {
            txtApellidoResp.Enabled = true;
            txtNombreResp.Enabled = true;
            txtDniResp.Enabled = true;
            cmbBoxGeneroResp.Enabled = true;
            cmbBoxRelacion.Enabled = true;
            txtTelefono.Enabled = true;
            flagResponsable = true;
        }
        /// <summary>
        /// Cierra este form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

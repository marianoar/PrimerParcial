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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            BackColor = Color.Lavender;
            labelTitulo.ForeColor= Color.BlueViolet;
            txtBoxUsuario.Text="admin";
            txtBoxPass.Text = "1234";
        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if((txtBoxUsuario.Text=="admin") && (txtBoxPass.Text == "1234")){
                FrmInicio frmInicio = new FrmInicio();
                frmInicio.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Clave incorrectos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using Entidades;

namespace Arias.Mariano
{
    public partial class FrmVideos : FrmReportes
    {
        private string video1 = "https://examenprog.000webhostapp.com/Tiburoncito.mp4";
        private string video2 = "https://examenprog.000webhostapp.com/Silbar.mp4";
        private string video3 = "https://examenprog.000webhostapp.com/BloopersTS2.mp4";

        public FrmVideos()
        {
            InitializeComponent();

            cmbAulas.Items.Add("Baby Shark");
            cmbAulas.Items.Add("Pepa Pig");
            cmbAulas.Items.Add("Toy Story ");
            SetFormVideos();
            cmbAulas.TabIndex = 1;
            
           
        }
        protected override void cmbAulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAulas.SelectedIndex == 0)
            {
                axWindowsMediaPlayer1.URL = video1;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else if (cmbAulas.SelectedIndex == 1)
            {
                axWindowsMediaPlayer1.URL = video2;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else if (cmbAulas.SelectedIndex == 2)
            {
                axWindowsMediaPlayer1.URL = video3;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
        protected override void btnCerrar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            Close();
        }
    }
}

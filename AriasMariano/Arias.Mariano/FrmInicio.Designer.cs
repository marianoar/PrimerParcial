namespace Arias.Mariano
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaNoDocenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionPadresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoNoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudacionPorAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudacionTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarPruebaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxNominaAulas = new System.Windows.Forms.ListBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblSalas = new System.Windows.Forms.Label();
            this.btnVerAula = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelTituloPpal = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.cargarPruebaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDocenteToolStripMenuItem,
            this.altaNoDocenteToolStripMenuItem1,
            this.altaAlumnoToolStripMenuItem,
            this.altaAulaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // altaDocenteToolStripMenuItem
            // 
            this.altaDocenteToolStripMenuItem.Name = "altaDocenteToolStripMenuItem";
            this.altaDocenteToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.altaDocenteToolStripMenuItem.Text = "Alta Docente";
            this.altaDocenteToolStripMenuItem.Click += new System.EventHandler(this.altaDocenteToolStripMenuItem_Click);
            // 
            // altaNoDocenteToolStripMenuItem1
            // 
            this.altaNoDocenteToolStripMenuItem1.Name = "altaNoDocenteToolStripMenuItem1";
            this.altaNoDocenteToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.altaNoDocenteToolStripMenuItem1.Text = "Alta No Docente";
            this.altaNoDocenteToolStripMenuItem1.Click += new System.EventHandler(this.altaNoDocenteToolStripMenuItem1_Click);
            // 
            // altaAlumnoToolStripMenuItem
            // 
            this.altaAlumnoToolStripMenuItem.Name = "altaAlumnoToolStripMenuItem";
            this.altaAlumnoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.altaAlumnoToolStripMenuItem.Text = "Alta Alumno";
            this.altaAlumnoToolStripMenuItem.Click += new System.EventHandler(this.altaAlumnoToolStripMenuItem_Click);
            // 
            // altaAulaToolStripMenuItem
            // 
            this.altaAulaToolStripMenuItem.Name = "altaAulaToolStripMenuItem";
            this.altaAulaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.altaAulaToolStripMenuItem.Text = "Crear Nueva Aula";
            this.altaAulaToolStripMenuItem.Click += new System.EventHandler(this.altaAulaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionPadresToolStripMenuItem,
            this.sueldoDocenteToolStripMenuItem,
            this.sueldoNoDocenteToolStripMenuItem,
            this.recaudacionPorAulaToolStripMenuItem,
            this.recaudacionTotalToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // informacionPadresToolStripMenuItem
            // 
            this.informacionPadresToolStripMenuItem.Name = "informacionPadresToolStripMenuItem";
            this.informacionPadresToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.informacionPadresToolStripMenuItem.Text = "Informacion Padres";
            this.informacionPadresToolStripMenuItem.Click += new System.EventHandler(this.informacionPadresToolStripMenuItem_Click);
            // 
            // sueldoDocenteToolStripMenuItem
            // 
            this.sueldoDocenteToolStripMenuItem.Name = "sueldoDocenteToolStripMenuItem";
            this.sueldoDocenteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.sueldoDocenteToolStripMenuItem.Text = "Sueldo Docente";
            this.sueldoDocenteToolStripMenuItem.Click += new System.EventHandler(this.sueldoDocenteToolStripMenuItem_Click);
            // 
            // sueldoNoDocenteToolStripMenuItem
            // 
            this.sueldoNoDocenteToolStripMenuItem.Name = "sueldoNoDocenteToolStripMenuItem";
            this.sueldoNoDocenteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.sueldoNoDocenteToolStripMenuItem.Text = "Sueldo No Docente";
            this.sueldoNoDocenteToolStripMenuItem.Click += new System.EventHandler(this.sueldoNoDocenteToolStripMenuItem_Click);
            // 
            // recaudacionPorAulaToolStripMenuItem
            // 
            this.recaudacionPorAulaToolStripMenuItem.Name = "recaudacionPorAulaToolStripMenuItem";
            this.recaudacionPorAulaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.recaudacionPorAulaToolStripMenuItem.Text = "Recaudacion por Aula";
            this.recaudacionPorAulaToolStripMenuItem.Click += new System.EventHandler(this.recaudacionPorAulaToolStripMenuItem_Click);
            // 
            // recaudacionTotalToolStripMenuItem
            // 
            this.recaudacionTotalToolStripMenuItem.Name = "recaudacionTotalToolStripMenuItem";
            this.recaudacionTotalToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.recaudacionTotalToolStripMenuItem.Text = "Recaudacion Total ";
            this.recaudacionTotalToolStripMenuItem.Click += new System.EventHandler(this.recaudacionTotalToolStripMenuItem_Click);
            // 
            // cargarPruebaToolStripMenuItem
            // 
            this.cargarPruebaToolStripMenuItem.Name = "cargarPruebaToolStripMenuItem";
            this.cargarPruebaToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.cargarPruebaToolStripMenuItem.Text = "Cargar Prueba";
            this.cargarPruebaToolStripMenuItem.Click += new System.EventHandler(this.cargarPruebaToolStripMenuItem_Click);
            // 
            // listBoxNominaAulas
            // 
            this.listBoxNominaAulas.FormattingEnabled = true;
            this.listBoxNominaAulas.Location = new System.Drawing.Point(204, 208);
            this.listBoxNominaAulas.Name = "listBoxNominaAulas";
            this.listBoxNominaAulas.Size = new System.Drawing.Size(493, 212);
            this.listBoxNominaAulas.TabIndex = 1;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(368, 179);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(160, 23);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar Listado Aulas";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblSalas
            // 
            this.lblSalas.AutoSize = true;
            this.lblSalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSalas.Location = new System.Drawing.Point(363, 147);
            this.lblSalas.Name = "lblSalas";
            this.lblSalas.Size = new System.Drawing.Size(176, 25);
            this.lblSalas.TabIndex = 3;
            this.lblSalas.Text = "Salas existentes:";
            // 
            // btnVerAula
            // 
            this.btnVerAula.Location = new System.Drawing.Point(534, 426);
            this.btnVerAula.Name = "btnVerAula";
            this.btnVerAula.Size = new System.Drawing.Size(160, 23);
            this.btnVerAula.TabIndex = 4;
            this.btnVerAula.Text = "Ver Aula";
            this.btnVerAula.UseVisualStyleBackColor = true;
            this.btnVerAula.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(202, 426);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar Aula";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(368, 426);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(160, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar Aula";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(368, 496);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(160, 23);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar Programa";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Image = global::Arias.Mariano.Properties.Resources._1492531735_icon_sets_school_outline_hand_drawn_iconfinder01_83191;
            this.pictureBoxLogo.Location = new System.Drawing.Point(425, 55);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLogo.TabIndex = 8;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelTituloPpal
            // 
            this.labelTituloPpal.AutoSize = true;
            this.labelTituloPpal.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloPpal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTituloPpal.Location = new System.Drawing.Point(295, 108);
            this.labelTituloPpal.Name = "labelTituloPpal";
            this.labelTituloPpal.Size = new System.Drawing.Size(311, 23);
            this.labelTituloPpal.TabIndex = 9;
            this.labelTituloPpal.Text = "Jardin de Infantes Los Pichoncitos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(368, 461);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(160, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar Alumno";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.labelTituloPpal);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnVerAula);
            this.Controls.Add(this.lblSalas);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.listBoxNominaAulas);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jardin de Infantes Los Pichoncitos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaNoDocenteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem altaAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionPadresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoNoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudacionPorAulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudacionTotalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarPruebaToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxNominaAulas;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblSalas;
        private System.Windows.Forms.Button btnVerAula;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelTituloPpal;
        private System.Windows.Forms.Button btnBuscar;
    }
}


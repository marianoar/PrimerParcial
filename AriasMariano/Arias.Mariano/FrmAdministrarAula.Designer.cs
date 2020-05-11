namespace Arias.Mariano
{
    partial class FrmAdministrarAula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministrarAula));
            this.lblDocente = new System.Windows.Forms.Label();
            this.cmbDocentes = new System.Windows.Forms.ComboBox();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.cmbSalita = new System.Windows.Forms.ComboBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.listBoxAlumnos = new System.Windows.Forms.ListBox();
            this.listBoxAlumnosEnAula = new System.Windows.Forms.ListBox();
            this.lblAlumnosTodos = new System.Windows.Forms.Label();
            this.lblAlumnosAula = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.labelIndice = new System.Windows.Forms.Label();
            this.labelTituloAula = new System.Windows.Forms.Label();
            this.btnSacarAlumno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocente.Location = new System.Drawing.Point(601, 36);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(74, 20);
            this.lblDocente.TabIndex = 1;
            this.lblDocente.Text = "Docente:";
            // 
            // cmbDocentes
            // 
            this.cmbDocentes.FormattingEnabled = true;
            this.cmbDocentes.Location = new System.Drawing.Point(681, 36);
            this.cmbDocentes.Name = "cmbDocentes";
            this.cmbDocentes.Size = new System.Drawing.Size(178, 21);
            this.cmbDocentes.TabIndex = 3;
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSala.Location = new System.Drawing.Point(23, 36);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(57, 20);
            this.lblSala.TabIndex = 4;
            this.lblSala.Text = "Salita :";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.Location = new System.Drawing.Point(325, 36);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(58, 20);
            this.lblTurno.TabIndex = 5;
            this.lblTurno.Text = "Turno :";
            // 
            // cmbSalita
            // 
            this.cmbSalita.FormattingEnabled = true;
            this.cmbSalita.Location = new System.Drawing.Point(86, 36);
            this.cmbSalita.Name = "cmbSalita";
            this.cmbSalita.Size = new System.Drawing.Size(121, 21);
            this.cmbSalita.TabIndex = 1;
            this.cmbSalita.SelectedIndexChanged += new System.EventHandler(this.cmbSalita_SelectedIndexChanged);
            // 
            // cmbTurno
            // 
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(389, 36);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(121, 21);
            this.cmbTurno.TabIndex = 2;
            // 
            // listBoxAlumnos
            // 
            this.listBoxAlumnos.FormattingEnabled = true;
            this.listBoxAlumnos.Location = new System.Drawing.Point(26, 120);
            this.listBoxAlumnos.Name = "listBoxAlumnos";
            this.listBoxAlumnos.Size = new System.Drawing.Size(325, 277);
            this.listBoxAlumnos.TabIndex = 4;
            // 
            // listBoxAlumnosEnAula
            // 
            this.listBoxAlumnosEnAula.FormattingEnabled = true;
            this.listBoxAlumnosEnAula.Location = new System.Drawing.Point(534, 120);
            this.listBoxAlumnosEnAula.Name = "listBoxAlumnosEnAula";
            this.listBoxAlumnosEnAula.Size = new System.Drawing.Size(325, 277);
            this.listBoxAlumnosEnAula.TabIndex = 6;
            // 
            // lblAlumnosTodos
            // 
            this.lblAlumnosTodos.AutoSize = true;
            this.lblAlumnosTodos.Location = new System.Drawing.Point(24, 92);
            this.lblAlumnosTodos.Name = "lblAlumnosTodos";
            this.lblAlumnosTodos.Size = new System.Drawing.Size(89, 13);
            this.lblAlumnosTodos.TabIndex = 10;
            this.lblAlumnosTodos.Text = "Nomina Alumnos ";
            // 
            // lblAlumnosAula
            // 
            this.lblAlumnosAula.AutoSize = true;
            this.lblAlumnosAula.Location = new System.Drawing.Point(531, 92);
            this.lblAlumnosAula.Name = "lblAlumnosAula";
            this.lblAlumnosAula.Size = new System.Drawing.Size(86, 13);
            this.lblAlumnosAula.TabIndex = 11;
            this.lblAlumnosAula.Text = "Alumnos en Aula";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(725, 411);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(134, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Crear Aula";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(534, 411);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(375, 136);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar Alumno >>";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // labelIndice
            // 
            this.labelIndice.AutoSize = true;
            this.labelIndice.Location = new System.Drawing.Point(13, 13);
            this.labelIndice.Name = "labelIndice";
            this.labelIndice.Size = new System.Drawing.Size(0, 13);
            this.labelIndice.TabIndex = 15;
            // 
            // labelTituloAula
            // 
            this.labelTituloAula.AutoSize = true;
            this.labelTituloAula.Location = new System.Drawing.Point(55, 13);
            this.labelTituloAula.Name = "labelTituloAula";
            this.labelTituloAula.Size = new System.Drawing.Size(0, 13);
            this.labelTituloAula.TabIndex = 16;
            // 
            // btnSacarAlumno
            // 
            this.btnSacarAlumno.Location = new System.Drawing.Point(375, 174);
            this.btnSacarAlumno.Name = "btnSacarAlumno";
            this.btnSacarAlumno.Size = new System.Drawing.Size(135, 23);
            this.btnSacarAlumno.TabIndex = 7;
            this.btnSacarAlumno.Text = "<< Remover Alumno";
            this.btnSacarAlumno.UseVisualStyleBackColor = true;
            this.btnSacarAlumno.Click += new System.EventHandler(this.btnSacarAlumno_Click);
            // 
            // FrmAdministrarAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.btnSacarAlumno);
            this.Controls.Add(this.labelTituloAula);
            this.Controls.Add(this.labelIndice);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblAlumnosAula);
            this.Controls.Add(this.lblAlumnosTodos);
            this.Controls.Add(this.listBoxAlumnosEnAula);
            this.Controls.Add(this.listBoxAlumnos);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.cmbSalita);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.cmbDocentes);
            this.Controls.Add(this.lblDocente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdministrarAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Aula";
            this.Load += new System.EventHandler(this.Aula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.ComboBox cmbDocentes;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ComboBox cmbSalita;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.ListBox listBoxAlumnos;
        private System.Windows.Forms.ListBox listBoxAlumnosEnAula;
        private System.Windows.Forms.Label lblAlumnosTodos;
        private System.Windows.Forms.Label lblAlumnosAula;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label labelIndice;
        private System.Windows.Forms.Label labelTituloAula;
        private System.Windows.Forms.Button btnSacarAlumno;
    }
}
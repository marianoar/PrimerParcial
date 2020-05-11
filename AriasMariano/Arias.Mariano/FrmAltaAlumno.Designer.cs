namespace Arias.Mariano
{
    partial class FrmAltaAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaAlumno));
            this.btnResponsable = new System.Windows.Forms.Button();
            this.txtApellidoResp = new System.Windows.Forms.TextBox();
            this.labelVarios2 = new System.Windows.Forms.Label();
            this.labelVarios = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txtDniResp = new System.Windows.Forms.TextBox();
            this.labelGenero = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.txtNombreResp = new System.Windows.Forms.TextBox();
            this.cmbBoxGeneroResp = new System.Windows.Forms.ComboBox();
            this.cmbBoxRelacion = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.labelApellidoResp = new System.Windows.Forms.Label();
            this.labelNombreResp = new System.Windows.Forms.Label();
            this.labelDniResp = new System.Windows.Forms.Label();
            this.labelGeneroResp = new System.Windows.Forms.Label();
            this.labelParentesco = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelCuota = new System.Windows.Forms.Label();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnResponsable
            // 
            this.btnResponsable.Location = new System.Drawing.Point(179, 185);
            this.btnResponsable.Name = "btnResponsable";
            this.btnResponsable.Size = new System.Drawing.Size(132, 23);
            this.btnResponsable.TabIndex = 6;
            this.btnResponsable.Text = "Cargar Responsable";
            this.btnResponsable.UseVisualStyleBackColor = true;
            this.btnResponsable.Visible = false;
            this.btnResponsable.Click += new System.EventHandler(this.btnResponsable_Click);
            // 
            // txtApellidoResp
            // 
            this.txtApellidoResp.Enabled = false;
            this.txtApellidoResp.Location = new System.Drawing.Point(178, 219);
            this.txtApellidoResp.Name = "txtApellidoResp";
            this.txtApellidoResp.Size = new System.Drawing.Size(132, 20);
            this.txtApellidoResp.TabIndex = 7;
            // 
            // labelVarios2
            // 
            this.labelVarios2.AutoSize = true;
            this.labelVarios2.Enabled = false;
            this.labelVarios2.Location = new System.Drawing.Point(54, 215);
            this.labelVarios2.Name = "labelVarios2";
            this.labelVarios2.Size = new System.Drawing.Size(0, 13);
            this.labelVarios2.TabIndex = 36;
            this.labelVarios2.Visible = false;
            // 
            // labelVarios
            // 
            this.labelVarios.AutoSize = true;
            this.labelVarios.Enabled = false;
            this.labelVarios.Location = new System.Drawing.Point(54, 178);
            this.labelVarios.Name = "labelVarios";
            this.labelVarios.Size = new System.Drawing.Size(0, 13);
            this.labelVarios.TabIndex = 35;
            this.labelVarios.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(75, 426);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cmbGenero.Location = new System.Drawing.Point(179, 119);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(132, 21);
            this.cmbGenero.TabIndex = 4;
            // 
            // txtDniResp
            // 
            this.txtDniResp.Enabled = false;
            this.txtDniResp.Location = new System.Drawing.Point(178, 287);
            this.txtDniResp.Name = "txtDniResp";
            this.txtDniResp.Size = new System.Drawing.Size(131, 20);
            this.txtDniResp.TabIndex = 9;
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenero.Location = new System.Drawing.Point(60, 123);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(48, 15);
            this.labelGenero.TabIndex = 29;
            this.labelGenero.Text = "Genero";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(179, 88);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(132, 20);
            this.txtDni.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(179, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(179, 26);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(132, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDNI.Location = new System.Drawing.Point(60, 92);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(50, 15);
            this.labelDNI.TabIndex = 23;
            this.labelDNI.Text = "D.N.I Nº";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(60, 61);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(52, 15);
            this.labelNombre.TabIndex = 22;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(60, 30);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(51, 15);
            this.labelApellido.TabIndex = 19;
            this.labelApellido.Text = "Apellido";
            // 
            // txtNombreResp
            // 
            this.txtNombreResp.Enabled = false;
            this.txtNombreResp.Location = new System.Drawing.Point(178, 253);
            this.txtNombreResp.Name = "txtNombreResp";
            this.txtNombreResp.Size = new System.Drawing.Size(132, 20);
            this.txtNombreResp.TabIndex = 8;
            // 
            // cmbBoxGeneroResp
            // 
            this.cmbBoxGeneroResp.Enabled = false;
            this.cmbBoxGeneroResp.FormattingEnabled = true;
            this.cmbBoxGeneroResp.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cmbBoxGeneroResp.Location = new System.Drawing.Point(178, 321);
            this.cmbBoxGeneroResp.Name = "cmbBoxGeneroResp";
            this.cmbBoxGeneroResp.Size = new System.Drawing.Size(131, 21);
            this.cmbBoxGeneroResp.TabIndex = 10;
            // 
            // cmbBoxRelacion
            // 
            this.cmbBoxRelacion.Enabled = false;
            this.cmbBoxRelacion.FormattingEnabled = true;
            this.cmbBoxRelacion.Location = new System.Drawing.Point(178, 356);
            this.cmbBoxRelacion.Name = "cmbBoxRelacion";
            this.cmbBoxRelacion.Size = new System.Drawing.Size(132, 21);
            this.cmbBoxRelacion.TabIndex = 11;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(178, 391);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(131, 20);
            this.txtTelefono.TabIndex = 12;
            // 
            // labelApellidoResp
            // 
            this.labelApellidoResp.AutoSize = true;
            this.labelApellidoResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidoResp.Location = new System.Drawing.Point(60, 222);
            this.labelApellidoResp.Name = "labelApellidoResp";
            this.labelApellidoResp.Size = new System.Drawing.Size(51, 15);
            this.labelApellidoResp.TabIndex = 41;
            this.labelApellidoResp.Text = "Apellido";
            // 
            // labelNombreResp
            // 
            this.labelNombreResp.AutoSize = true;
            this.labelNombreResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreResp.Location = new System.Drawing.Point(60, 255);
            this.labelNombreResp.Name = "labelNombreResp";
            this.labelNombreResp.Size = new System.Drawing.Size(52, 15);
            this.labelNombreResp.TabIndex = 42;
            this.labelNombreResp.Text = "Nombre";
            // 
            // labelDniResp
            // 
            this.labelDniResp.AutoSize = true;
            this.labelDniResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDniResp.Location = new System.Drawing.Point(60, 288);
            this.labelDniResp.Name = "labelDniResp";
            this.labelDniResp.Size = new System.Drawing.Size(44, 15);
            this.labelDniResp.TabIndex = 43;
            this.labelDniResp.Text = "DNI Nº";
            // 
            // labelGeneroResp
            // 
            this.labelGeneroResp.AutoSize = true;
            this.labelGeneroResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGeneroResp.Location = new System.Drawing.Point(60, 321);
            this.labelGeneroResp.Name = "labelGeneroResp";
            this.labelGeneroResp.Size = new System.Drawing.Size(48, 15);
            this.labelGeneroResp.TabIndex = 44;
            this.labelGeneroResp.Text = "Genero";
            // 
            // labelParentesco
            // 
            this.labelParentesco.AutoSize = true;
            this.labelParentesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParentesco.Location = new System.Drawing.Point(60, 354);
            this.labelParentesco.Name = "labelParentesco";
            this.labelParentesco.Size = new System.Drawing.Size(69, 15);
            this.labelParentesco.TabIndex = 45;
            this.labelParentesco.Text = "Parentesco";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.Location = new System.Drawing.Point(60, 387);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(55, 15);
            this.labelTelefono.TabIndex = 46;
            this.labelTelefono.Text = "Telefono";
            // 
            // labelCuota
            // 
            this.labelCuota.AutoSize = true;
            this.labelCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuota.Location = new System.Drawing.Point(60, 154);
            this.labelCuota.Name = "labelCuota";
            this.labelCuota.Size = new System.Drawing.Size(39, 15);
            this.labelCuota.TabIndex = 47;
            this.labelCuota.Text = "Cuota";
            // 
            // txtCuota
            // 
            this.txtCuota.Location = new System.Drawing.Point(180, 151);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(131, 20);
            this.txtCuota.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(234, 426);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmAltaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtCuota);
            this.Controls.Add(this.labelCuota);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelParentesco);
            this.Controls.Add(this.labelGeneroResp);
            this.Controls.Add(this.labelDniResp);
            this.Controls.Add(this.labelNombreResp);
            this.Controls.Add(this.labelApellidoResp);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.cmbBoxRelacion);
            this.Controls.Add(this.cmbBoxGeneroResp);
            this.Controls.Add(this.txtNombreResp);
            this.Controls.Add(this.btnResponsable);
            this.Controls.Add(this.txtApellidoResp);
            this.Controls.Add(this.labelVarios2);
            this.Controls.Add(this.labelVarios);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.txtDniResp);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelApellido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAltaAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Nuevo Alumno";
            this.Load += new System.EventHandler(this.FrmAltaAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResponsable;
        private System.Windows.Forms.TextBox txtApellidoResp;
        private System.Windows.Forms.Label labelVarios2;
        private System.Windows.Forms.Label labelVarios;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.TextBox txtDniResp;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox txtNombreResp;
        private System.Windows.Forms.ComboBox cmbBoxGeneroResp;
        private System.Windows.Forms.ComboBox cmbBoxRelacion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label labelApellidoResp;
        private System.Windows.Forms.Label labelNombreResp;
        private System.Windows.Forms.Label labelDniResp;
        private System.Windows.Forms.Label labelGeneroResp;
        private System.Windows.Forms.Label labelParentesco;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelCuota;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.Button btnCancelar;
    }
}
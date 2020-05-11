namespace Arias.Mariano
{
    partial class FrmAltaPersona
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
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.labelGenero = new System.Windows.Forms.Label();
            this.groupBoxHorario = new System.Windows.Forms.GroupBox();
            this.labelHoraSalida = new System.Windows.Forms.Label();
            this.labeHoraEntrada = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.labelValorHora = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labelVarios = new System.Windows.Forms.Label();
            this.labelVarios2 = new System.Windows.Forms.Label();
            this.cmbVarios = new System.Windows.Forms.ComboBox();
            this.txtVarios = new System.Windows.Forms.TextBox();
            this.groupBoxHorario.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(64, 44);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 0;
            this.labelApellido.Text = "Apellido";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(64, 81);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(64, 118);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(47, 13);
            this.labelDNI.TabIndex = 2;
            this.labelDNI.Text = "D.N.I Nº";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(188, 40);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(132, 20);
            this.txtApellido.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(188, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(188, 114);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(132, 20);
            this.txtDni.TabIndex = 2;
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(64, 155);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(42, 13);
            this.labelGenero.TabIndex = 8;
            this.labelGenero.Text = "Genero";
            // 
            // groupBoxHorario
            // 
            this.groupBoxHorario.Controls.Add(this.labelHoraSalida);
            this.groupBoxHorario.Controls.Add(this.labeHoraEntrada);
            this.groupBoxHorario.Controls.Add(this.txtEntrada);
            this.groupBoxHorario.Controls.Add(this.txtSalida);
            this.groupBoxHorario.Enabled = false;
            this.groupBoxHorario.Location = new System.Drawing.Point(67, 227);
            this.groupBoxHorario.Name = "groupBoxHorario";
            this.groupBoxHorario.Size = new System.Drawing.Size(273, 53);
            this.groupBoxHorario.TabIndex = 9;
            this.groupBoxHorario.TabStop = false;
            this.groupBoxHorario.Text = "Horario";
            this.groupBoxHorario.Visible = false;
            // 
            // labelHoraSalida
            // 
            this.labelHoraSalida.AutoSize = true;
            this.labelHoraSalida.Location = new System.Drawing.Point(153, 25);
            this.labelHoraSalida.Name = "labelHoraSalida";
            this.labelHoraSalida.Size = new System.Drawing.Size(42, 13);
            this.labelHoraSalida.TabIndex = 3;
            this.labelHoraSalida.Text = "Salida :";
            // 
            // labeHoraEntrada
            // 
            this.labeHoraEntrada.AutoSize = true;
            this.labeHoraEntrada.Location = new System.Drawing.Point(43, 26);
            this.labeHoraEntrada.Name = "labeHoraEntrada";
            this.labeHoraEntrada.Size = new System.Drawing.Size(50, 13);
            this.labeHoraEntrada.TabIndex = 2;
            this.labeHoraEntrada.Text = "Entrada :";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(99, 19);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(36, 20);
            this.txtEntrada.TabIndex = 6;
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(223, 19);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(44, 20);
            this.txtSalida.TabIndex = 7;
            // 
            // txtValorHora
            // 
            this.txtValorHora.Enabled = false;
            this.txtValorHora.Location = new System.Drawing.Point(188, 298);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(131, 20);
            this.txtValorHora.TabIndex = 8;
            this.txtValorHora.Visible = false;
            // 
            // labelValorHora
            // 
            this.labelValorHora.AutoSize = true;
            this.labelValorHora.Enabled = false;
            this.labelValorHora.Location = new System.Drawing.Point(102, 301);
            this.labelValorHora.Name = "labelValorHora";
            this.labelValorHora.Size = new System.Drawing.Size(57, 13);
            this.labelValorHora.TabIndex = 11;
            this.labelValorHora.Text = "Valor Hora";
            this.labelValorHora.Visible = false;
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cmbGenero.Location = new System.Drawing.Point(188, 151);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(132, 21);
            this.cmbGenero.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(77, 426);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(244, 426);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelVarios
            // 
            this.labelVarios.AutoSize = true;
            this.labelVarios.Enabled = false;
            this.labelVarios.Location = new System.Drawing.Point(64, 192);
            this.labelVarios.Name = "labelVarios";
            this.labelVarios.Size = new System.Drawing.Size(0, 13);
            this.labelVarios.TabIndex = 17;
            this.labelVarios.Visible = false;
            // 
            // labelVarios2
            // 
            this.labelVarios2.AutoSize = true;
            this.labelVarios2.Enabled = false;
            this.labelVarios2.Location = new System.Drawing.Point(64, 229);
            this.labelVarios2.Name = "labelVarios2";
            this.labelVarios2.Size = new System.Drawing.Size(0, 13);
            this.labelVarios2.TabIndex = 18;
            this.labelVarios2.Visible = false;
            // 
            // cmbVarios
            // 
            this.cmbVarios.Enabled = false;
            this.cmbVarios.FormattingEnabled = true;
            this.cmbVarios.Location = new System.Drawing.Point(188, 189);
            this.cmbVarios.Name = "cmbVarios";
            this.cmbVarios.Size = new System.Drawing.Size(132, 21);
            this.cmbVarios.TabIndex = 4;
            this.cmbVarios.Visible = false;
            // 
            // txtVarios
            // 
            this.txtVarios.Enabled = false;
            this.txtVarios.Location = new System.Drawing.Point(188, 227);
            this.txtVarios.Name = "txtVarios";
            this.txtVarios.Size = new System.Drawing.Size(132, 20);
            this.txtVarios.TabIndex = 5;
            this.txtVarios.Visible = false;
            // 
            // FrmAltaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.cmbVarios);
            this.Controls.Add(this.txtVarios);
            this.Controls.Add(this.labelVarios2);
            this.Controls.Add(this.labelVarios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.labelValorHora);
            this.Controls.Add(this.txtValorHora);
            this.Controls.Add(this.groupBoxHorario);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelApellido);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAltaPersona";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBoxHorario.ResumeLayout(false);
            this.groupBoxHorario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.GroupBox groupBoxHorario;
        private System.Windows.Forms.TextBox txtValorHora;
        private System.Windows.Forms.Label labelValorHora;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Label labelVarios;
        private System.Windows.Forms.Label labelVarios2;
        private System.Windows.Forms.ComboBox cmbVarios;
        private System.Windows.Forms.Label labelHoraSalida;
        private System.Windows.Forms.Label labeHoraEntrada;
        private System.Windows.Forms.TextBox txtVarios;
    }
}
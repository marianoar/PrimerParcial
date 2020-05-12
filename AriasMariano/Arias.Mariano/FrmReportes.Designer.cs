namespace Arias.Mariano
{
    partial class FrmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            this.listBoxCentral = new System.Windows.Forms.ListBox();
            this.labelLista = new System.Windows.Forms.Label();
            this.labelTituloAula = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cmbAulas = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.labelTituloJardin = new System.Windows.Forms.Label();
            this.pictureBoxImg = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCentral
            // 
            this.listBoxCentral.FormattingEnabled = true;
            this.listBoxCentral.Location = new System.Drawing.Point(96, 198);
            this.listBoxCentral.Name = "listBoxCentral";
            this.listBoxCentral.Size = new System.Drawing.Size(400, 316);
            this.listBoxCentral.TabIndex = 1;
            // 
            // labelLista
            // 
            this.labelLista.AutoSize = true;
            this.labelLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLista.Location = new System.Drawing.Point(200, 164);
            this.labelLista.Name = "labelLista";
            this.labelLista.Size = new System.Drawing.Size(187, 20);
            this.labelLista.TabIndex = 2;
            this.labelLista.Text = "Alumnos/as en esta aula:";
            // 
            // labelTituloAula
            // 
            this.labelTituloAula.AutoSize = true;
            this.labelTituloAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloAula.Location = new System.Drawing.Point(12, 164);
            this.labelTituloAula.Name = "labelTituloAula";
            this.labelTituloAula.Size = new System.Drawing.Size(108, 20);
            this.labelTituloAula.TabIndex = 4;
            this.labelTituloAula.Text = "datos ver aula";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(13, 13);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(0, 13);
            this.lblSala.TabIndex = 5;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(189, 543);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(222, 23);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Volver";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cmbAulas
            // 
            this.cmbAulas.FormattingEnabled = true;
            this.cmbAulas.Location = new System.Drawing.Point(134, 130);
            this.cmbAulas.Name = "cmbAulas";
            this.cmbAulas.Size = new System.Drawing.Size(325, 21);
            this.cmbAulas.TabIndex = 8;
            this.cmbAulas.SelectedIndexChanged += new System.EventHandler(this.cmbAulas_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(194, 103);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(204, 20);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Seleccione Aula a visualizar";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(246, 255);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 100);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // labelTituloJardin
            // 
            this.labelTituloJardin.AutoSize = true;
            this.labelTituloJardin.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloJardin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTituloJardin.Location = new System.Drawing.Point(141, 71);
            this.labelTituloJardin.Name = "labelTituloJardin";
            this.labelTituloJardin.Size = new System.Drawing.Size(311, 23);
            this.labelTituloJardin.TabIndex = 15;
            this.labelTituloJardin.Text = "Jardin de Infantes Los Pichoncitos";
            this.labelTituloJardin.Visible = false;
            // 
            // pictureBoxImg
            // 
            this.pictureBoxImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImg.Image = global::Arias.Mariano.Properties.Resources._1492531735_icon_sets_school_outline_hand_drawn_iconfinder01_83191;
            this.pictureBoxImg.Location = new System.Drawing.Point(271, 18);
            this.pictureBoxImg.Name = "pictureBoxImg";
            this.pictureBoxImg.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxImg.TabIndex = 17;
            this.pictureBoxImg.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Image = global::Arias.Mariano.Properties.Resources._1492531735_icon_sets_school_outline_hand_drawn_iconfinder01_83191;
            this.pictureBoxLogo.Location = new System.Drawing.Point(271, 18);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(50, 0);
            this.pictureBoxLogo.TabIndex = 16;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 607);
            this.Controls.Add(this.pictureBoxImg);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelTituloJardin);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cmbAulas);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.labelTituloAula);
            this.Controls.Add(this.labelLista);
            this.Controls.Add(this.listBoxCentral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizacion de Reportes";
            this.Load += new System.EventHandler(this.FrmAula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxCentral;
        private System.Windows.Forms.Label labelLista;
        private System.Windows.Forms.Label labelTituloAula;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label labelTituloJardin;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxImg;
        protected System.Windows.Forms.ComboBox cmbAulas;
    }
}
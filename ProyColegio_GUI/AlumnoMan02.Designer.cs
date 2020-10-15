namespace ProyColegio_GUI
{
    partial class AlumnoMan02
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
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.cboSupervisor = new System.Windows.Forms.ComboBox();
            this.mskSueldo = new System.Windows.Forms.MaskedTextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.dtpFecIng = new System.Windows.Forms.DateTimePicker();
            this.optSupervisor = new System.Windows.Forms.RadioButton();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtape = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.optEjecutivo = new System.Windows.Forms.RadioButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.chkActivo);
            this.grpDatos.Controls.Add(this.cboSupervisor);
            this.grpDatos.Controls.Add(this.mskSueldo);
            this.grpDatos.Controls.Add(this.btnGrabar);
            this.grpDatos.Controls.Add(this.Label1);
            this.grpDatos.Controls.Add(this.dtpFecIng);
            this.grpDatos.Controls.Add(this.optSupervisor);
            this.grpDatos.Controls.Add(this.txtnom);
            this.grpDatos.Controls.Add(this.txtEmail);
            this.grpDatos.Controls.Add(this.txtape);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Controls.Add(this.optEjecutivo);
            this.grpDatos.Controls.Add(this.Label2);
            this.grpDatos.Controls.Add(this.Label3);
            this.grpDatos.Controls.Add(this.Label4);
            this.grpDatos.Controls.Add(this.btnCancelar);
            this.grpDatos.Location = new System.Drawing.Point(11, 11);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(453, 351);
            this.grpDatos.TabIndex = 1;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(80, 279);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(62, 17);
            this.chkActivo.TabIndex = 9;
            this.chkActivo.Text = "Activo?";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // cboSupervisor
            // 
            this.cboSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupervisor.Enabled = false;
            this.cboSupervisor.FormattingEnabled = true;
            this.cboSupervisor.Location = new System.Drawing.Point(80, 237);
            this.cboSupervisor.Name = "cboSupervisor";
            this.cboSupervisor.Size = new System.Drawing.Size(352, 21);
            this.cboSupervisor.TabIndex = 7;
            // 
            // mskSueldo
            // 
            this.mskSueldo.Location = new System.Drawing.Point(80, 88);
            this.mskSueldo.Mask = "9999.99";
            this.mskSueldo.Name = "mskSueldo";
            this.mskSueldo.Size = new System.Drawing.Size(62, 20);
            this.mskSueldo.TabIndex = 2;
            this.mskSueldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(338, 278);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(72, 24);
            this.btnGrabar.TabIndex = 10;
            this.btnGrabar.Text = "Grabar";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(8, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 16);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Nombre:";
            // 
            // dtpFecIng
            // 
            this.dtpFecIng.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIng.Location = new System.Drawing.Point(80, 120);
            this.dtpFecIng.Name = "dtpFecIng";
            this.dtpFecIng.Size = new System.Drawing.Size(120, 20);
            this.dtpFecIng.TabIndex = 3;
            // 
            // optSupervisor
            // 
            this.optSupervisor.Checked = true;
            this.optSupervisor.Location = new System.Drawing.Point(27, 160);
            this.optSupervisor.Name = "optSupervisor";
            this.optSupervisor.Size = new System.Drawing.Size(96, 24);
            this.optSupervisor.TabIndex = 4;
            this.optSupervisor.TabStop = true;
            this.optSupervisor.Text = "Supervisor";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(80, 24);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(192, 20);
            this.txtnom.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(80, 201);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtape
            // 
            this.txtape.Location = new System.Drawing.Point(80, 56);
            this.txtape.Name = "txtape";
            this.txtape.Size = new System.Drawing.Size(192, 20);
            this.txtape.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Supervisor:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email:";
            // 
            // optEjecutivo
            // 
            this.optEjecutivo.Location = new System.Drawing.Point(138, 162);
            this.optEjecutivo.Name = "optEjecutivo";
            this.optEjecutivo.Size = new System.Drawing.Size(96, 24);
            this.optEjecutivo.TabIndex = 5;
            this.optEjecutivo.Text = "Ejecutivo";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(8, 56);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 16);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Apellido:";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(8, 88);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 16);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Sueldo:";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(8, 120);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 16);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "F. Ingreso:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(338, 308);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 24);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            // 
            // AlumnoMan02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(474, 372);
            this.Controls.Add(this.grpDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlumnoMan02";
            this.Text = "Editar Alumno";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.ComboBox cboSupervisor;
        private System.Windows.Forms.MaskedTextBox mskSueldo;
        internal System.Windows.Forms.Button btnGrabar;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DateTimePicker dtpFecIng;
        internal System.Windows.Forms.RadioButton optSupervisor;
        internal System.Windows.Forms.TextBox txtnom;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.TextBox txtape;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.RadioButton optEjecutivo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnCancelar;
    }
}
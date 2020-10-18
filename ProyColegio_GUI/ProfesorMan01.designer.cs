namespace ProyColegio_GUI
{
    partial class ProfesorMan01
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
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgProfesor = new System.Windows.Forms.DataGridView();
            this.IDPROFESOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHANACIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CELULAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAREGISTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIOREGISTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAULTMOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USU_ULT_MOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfesor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertar.Location = new System.Drawing.Point(538, 472);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(619, 472);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(700, 472);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(201, 12);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(283, 20);
            this.txtFiltro.TabIndex = 10;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ingrese iniciales de apellidos:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(721, 431);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(54, 23);
            this.lblRegistros.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Registros:";
            // 
            // dtgProfesor
            // 
            this.dtgProfesor.AllowUserToAddRows = false;
            this.dtgProfesor.AllowUserToDeleteRows = false;
            this.dtgProfesor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProfesor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProfesor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPROFESOR,
            this.NOMBRE,
            this.DNI,
            this.FECHANACIMIENTO,
            this.TELEFONO,
            this.CELULAR,
            this.DIRECCION,
            this.FECHAREGISTRO,
            this.USUARIOREGISTRO,
            this.FECHAULTMOD,
            this.USU_ULT_MOD,
            this.ESTADO});
            this.dtgProfesor.Location = new System.Drawing.Point(12, 38);
            this.dtgProfesor.Name = "dtgProfesor";
            this.dtgProfesor.ReadOnly = true;
            this.dtgProfesor.RowHeadersVisible = false;
            this.dtgProfesor.RowTemplate.Height = 24;
            this.dtgProfesor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProfesor.Size = new System.Drawing.Size(762, 379);
            this.dtgProfesor.TabIndex = 13;
            // 
            // IDPROFESOR
            // 
            this.IDPROFESOR.DataPropertyName = "IDPROFESOR";
            this.IDPROFESOR.HeaderText = "ID";
            this.IDPROFESOR.Name = "IDPROFESOR";
            this.IDPROFESOR.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "APELLNOMBRES";
            this.NOMBRE.HeaderText = "NOMBRES";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "DNI";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // FECHANACIMIENTO
            // 
            this.FECHANACIMIENTO.DataPropertyName = "FECHANACI";
            this.FECHANACIMIENTO.HeaderText = "FECHA NACIMIENTO";
            this.FECHANACIMIENTO.Name = "FECHANACIMIENTO";
            this.FECHANACIMIENTO.ReadOnly = true;
            // 
            // TELEFONO
            // 
            this.TELEFONO.DataPropertyName = "TELEFONO";
            this.TELEFONO.HeaderText = "TELEFONO";
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.ReadOnly = true;
            // 
            // CELULAR
            // 
            this.CELULAR.DataPropertyName = "CELULAR";
            this.CELULAR.HeaderText = "CELULAR";
            this.CELULAR.Name = "CELULAR";
            this.CELULAR.ReadOnly = true;
            // 
            // DIRECCION
            // 
            this.DIRECCION.DataPropertyName = "DIRECCION";
            this.DIRECCION.HeaderText = "DIRECCION";
            this.DIRECCION.Name = "DIRECCION";
            this.DIRECCION.ReadOnly = true;
            // 
            // FECHAREGISTRO
            // 
            this.FECHAREGISTRO.DataPropertyName = "FECHA_REGISTRO";
            this.FECHAREGISTRO.HeaderText = "FECHA REGISTRO";
            this.FECHAREGISTRO.Name = "FECHAREGISTRO";
            this.FECHAREGISTRO.ReadOnly = true;
            // 
            // USUARIOREGISTRO
            // 
            this.USUARIOREGISTRO.DataPropertyName = "USUARIO_REGISTRO";
            this.USUARIOREGISTRO.HeaderText = "USUARIO REGISTRO";
            this.USUARIOREGISTRO.Name = "USUARIOREGISTRO";
            this.USUARIOREGISTRO.ReadOnly = true;
            // 
            // FECHAULTMOD
            // 
            this.FECHAULTMOD.DataPropertyName = "FECHA_ULT_MODIFICACION";
            this.FECHAULTMOD.HeaderText = "FECHA ULTIMA MODIFICACION";
            this.FECHAULTMOD.Name = "FECHAULTMOD";
            this.FECHAULTMOD.ReadOnly = true;
            // 
            // USU_ULT_MOD
            // 
            this.USU_ULT_MOD.DataPropertyName = "USUARIO_ULT_MODIFICACION";
            this.USU_ULT_MOD.HeaderText = "USUARIO ULTIMA MODIFICACION";
            this.USU_ULT_MOD.Name = "USU_ULT_MOD";
            this.USU_ULT_MOD.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // ProfesorMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(786, 507);
            this.Controls.Add(this.dtgProfesor);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Name = "ProfesorMan01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Profesores";
            this.Load += new System.EventHandler(this.ProfesorMan01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfesor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPROFESOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHANACIMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CELULAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAREGISTRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIOREGISTRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAULTMOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn USU_ULT_MOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}
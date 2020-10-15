namespace ProyColegio_GUI {
    partial class CursoMan01 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dtgCurso = new System.Windows.Forms.DataGridView();
            this.IDCURSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRECURSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORAS_SEMANALES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO_REGISTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_REGISTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO_ULT_MODIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_ULT_MODIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese nombre del curso";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(156, 14);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(322, 20);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // dtgCurso
            // 
            this.dtgCurso.AllowUserToAddRows = false;
            this.dtgCurso.AllowUserToDeleteRows = false;
            this.dtgCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCurso.BackgroundColor = System.Drawing.Color.DimGray;
            this.dtgCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCURSO,
            this.NOMBRECURSO,
            this.DESCRIPCION,
            this.HORAS_SEMANALES,
            this.NomTipo,
            this.USUARIO_REGISTRO,
            this.FECHA_REGISTRO,
            this.USUARIO_ULT_MODIFICACION,
            this.FECHA_ULT_MODIFICACION,
            this.ESTADO});
            this.dtgCurso.Location = new System.Drawing.Point(15, 54);
            this.dtgCurso.Name = "dtgCurso";
            this.dtgCurso.ReadOnly = true;
            this.dtgCurso.RowHeadersVisible = false;
            this.dtgCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCurso.Size = new System.Drawing.Size(1051, 437);
            this.dtgCurso.TabIndex = 2;
            // 
            // IDCURSO
            // 
            this.IDCURSO.DataPropertyName = "IDCURSO";
            this.IDCURSO.HeaderText = "ID";
            this.IDCURSO.Name = "IDCURSO";
            this.IDCURSO.ReadOnly = true;
            // 
            // NOMBRECURSO
            // 
            this.NOMBRECURSO.DataPropertyName = "NOMBRECURSO";
            this.NOMBRECURSO.HeaderText = "Nombre";
            this.NOMBRECURSO.Name = "NOMBRECURSO";
            this.NOMBRECURSO.ReadOnly = true;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "DESCRIPCION";
            this.DESCRIPCION.HeaderText = "Descripcion";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            // 
            // HORAS_SEMANALES
            // 
            this.HORAS_SEMANALES.DataPropertyName = "HORAS_SEMANALES";
            this.HORAS_SEMANALES.HeaderText = "Horas Semanales";
            this.HORAS_SEMANALES.Name = "HORAS_SEMANALES";
            this.HORAS_SEMANALES.ReadOnly = true;
            // 
            // NomTipo
            // 
            this.NomTipo.DataPropertyName = "NomTipo";
            this.NomTipo.HeaderText = "Tipo";
            this.NomTipo.Name = "NomTipo";
            this.NomTipo.ReadOnly = true;
            // 
            // USUARIO_REGISTRO
            // 
            this.USUARIO_REGISTRO.DataPropertyName = "USUARIO_REGISTRO";
            this.USUARIO_REGISTRO.HeaderText = "Usuario Registro";
            this.USUARIO_REGISTRO.Name = "USUARIO_REGISTRO";
            this.USUARIO_REGISTRO.ReadOnly = true;
            // 
            // FECHA_REGISTRO
            // 
            this.FECHA_REGISTRO.DataPropertyName = "FECHA_REGISTRO";
            this.FECHA_REGISTRO.HeaderText = "Fecha Registro";
            this.FECHA_REGISTRO.Name = "FECHA_REGISTRO";
            this.FECHA_REGISTRO.ReadOnly = true;
            // 
            // USUARIO_ULT_MODIFICACION
            // 
            this.USUARIO_ULT_MODIFICACION.DataPropertyName = "USUARIO_ULT_MODIFICACION";
            this.USUARIO_ULT_MODIFICACION.HeaderText = "Usu. Ult. Modif.";
            this.USUARIO_ULT_MODIFICACION.Name = "USUARIO_ULT_MODIFICACION";
            this.USUARIO_ULT_MODIFICACION.ReadOnly = true;
            // 
            // FECHA_ULT_MODIFICACION
            // 
            this.FECHA_ULT_MODIFICACION.DataPropertyName = "FECHA_ULT_MODIFICACION";
            this.FECHA_ULT_MODIFICACION.HeaderText = "Fecha Modif.";
            this.FECHA_ULT_MODIFICACION.Name = "FECHA_ULT_MODIFICACION";
            this.FECHA_ULT_MODIFICACION.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "Estado";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(887, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registros:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(979, 14);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(87, 23);
            this.lblRegistros.TabIndex = 1;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInsertar.BackColor = System.Drawing.Color.Gray;
            this.btnInsertar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsertar.Location = new System.Drawing.Point(298, 520);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(150, 34);
            this.btnInsertar.TabIndex = 3;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnActualizar.BackColor = System.Drawing.Color.Gray;
            this.btnActualizar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.Location = new System.Drawing.Point(469, 520);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(150, 34);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(640, 520);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 34);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // CursoMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 566);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgCurso);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label1);
            this.Name = "CursoMan01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Curso";
            this.Load += new System.EventHandler(this.CursoMan01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dtgCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCURSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRECURSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORAS_SEMANALES;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO_REGISTRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_REGISTRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO_ULT_MODIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_ULT_MODIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}
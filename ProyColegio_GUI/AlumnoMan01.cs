using ProyColegio_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyColegio_GUI
{
    public partial class AlumnoMan01 : Form { 

        AlumnoBL objAlumnoBL = new AlumnoBL();
        DataView dtv;
    
        public AlumnoMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos(String strFiltro)
        {
            dtv.RowFilter = "APEPATERNO like '%" + strFiltro + "%'";
            dtgAlumno.DataSource = dtv;
            lblRegistros.Text = dtgAlumno.Rows.Count.ToString();
        }

        private void AlumnoMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgAlumno.AutoGenerateColumns = false;
                dtv = new DataView(objAlumnoBL.ListarAlumno());
                CargarDatos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            AlumnoMan02 alumnoMan02 = new AlumnoMan02();
            alumnoMan02.ShowDialog();

            txtFiltro.Text = "";
            dtv = new DataView(objAlumnoBL.ListarAlumno());
            CargarDatos("");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                AlumnoMan03 alumnoMan03 = new AlumnoMan03();

                String strId = dtgAlumno.CurrentRow.Cells[0].Value.ToString();
                alumnoMan03.Id = strId;

                txtFiltro.Text = "";
                dtv = new DataView(objAlumnoBL.ListarAlumno());
                CargarDatos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}

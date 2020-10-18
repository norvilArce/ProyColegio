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
    public partial class ProfesorMan01 : Form
    {

        ProfesorBL objProfesorBL = new ProfesorBL();
        DataView dtv;

        public ProfesorMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos(String strFiltro)
        {
            dtv.RowFilter = "APELLNOMBRES like '%" + strFiltro + "%'";
            dtgProfesor.DataSource = dtv;
            lblRegistros.Text = dtgProfesor.Rows.Count.ToString();
        }

        private void ProfesorMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtv = new DataView(objProfesorBL.ListarProfesor());
                CargarDatos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            ProfesorMan02 profesorMan02 = new ProfesorMan02();
            profesorMan02.ShowDialog();

            txtFiltro.Text = "";
            dtv = new DataView(objProfesorBL.ListarProfesor());
            CargarDatos("");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ProfesorMan03 profesorMan03 = new ProfesorMan03();

                String strId = dtgProfesor.CurrentRow.Cells[0].Value.ToString();
                profesorMan03.Id = strId;
                profesorMan03.ShowDialog();
                txtFiltro.Text = "";
                dtv = new DataView(objProfesorBL.ListarProfesor());
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


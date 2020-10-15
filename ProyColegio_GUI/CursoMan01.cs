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

namespace ProyColegio_GUI {
    public partial class CursoMan01 : Form {

        CursoBL objCursoBL = new CursoBL();
        DataView dtv;

        public CursoMan01() {
            InitializeComponent();
        }

        public void SetearEstilos() {
            //Setear estilo de DTG
            dtgCurso.DefaultCellStyle.Font = new Font("Tahoma", 8);
            dtgCurso.DefaultCellStyle.ForeColor = Color.Black;
            dtgCurso.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dtgCurso.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8);
            dtgCurso.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 5, 0, 5);

        }

        public void CargarDatos(String strFiltro) {
            //Codifique
            dtv.RowFilter = "NOMBRECURSO like '%" + strFiltro + "%'";
            dtgCurso.DataSource = dtv;
            lblRegistros.Text = dtgCurso.Rows.Count.ToString();
        }

        private void CursoMan01_Load(object sender, EventArgs e) {
            SetearEstilos();

            try {
                dtgCurso.AutoGenerateColumns = false;
                dtv = new DataView(objCursoBL.ListarCurso());
                CargarDatos("");
            }

            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
           
        }

        private void btnInsertar_Click(object sender, EventArgs e) {
            try {
                CursoMan02 man2 = new CursoMan02();
                man2.ShowDialog();
                txtFiltro.Text = "";
                dtv = new DataView(objCursoBL.ListarCurso());
                CargarDatos("");
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e) {
            try {
                CursoMan03 man3 = new CursoMan03();
                int id = Convert.ToInt16(dtgCurso.CurrentRow.Cells[0].Value);
                man3.Id = id;
                man3.ShowDialog();
                txtFiltro.Text = "";
                dtv = new DataView(objCursoBL.ListarCurso());
                CargarDatos("");
            }

            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e) {
            try {
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

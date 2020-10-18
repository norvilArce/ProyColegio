using ProyColegio_BE;
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
    public partial class AlumnoMan03 : Form
    {
        AlumnoBL objAlumnoBL = new AlumnoBL();
        AlumnoBE objAlumnoBE = new AlumnoBE();
        PadreBL objPadreBL = new PadreBL();
        PeriodoBL objPeriodoBL = new PeriodoBL();

        public AlumnoMan03()
        {
            InitializeComponent();
        }

        private String _Id;
        public String Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private void AlumnoMan03_Load(object sender, EventArgs e)
        {
            try
            {
                objAlumnoBE = objAlumnoBL.ConsultarAlumno(this.Id);

                lblId.Text = objAlumnoBE.IdAlumno.ToString();
                txtNombre.Text = objAlumnoBE.NomAlumno;
                txtApePat.Text = objAlumnoBE.ApePatAlumno;
                txtApeMat.Text = objAlumnoBE.ApeMatAlumno;
                txtEmail.Text = objAlumnoBE.EmailAlumno;
                dtpFecNac.Value = objAlumnoBE.FecNacAlumno;
                txtTel.Text = objAlumnoBE.TelAlumno;
                mskDni.Text = objAlumnoBE.DniAlumno;
                txtDir.Text = objAlumnoBE.DirAlumno;
                chkEstado.Checked = Convert.ToBoolean(objAlumnoBE.Est_Alum);
                String idUbigeo = objAlumnoBE.Id_Ubigeo;
                Int16 idPadre = objAlumnoBE.IdPadre;
                Int16 idPeriodo = objAlumnoBE.IdPeriodo;
                
                cargarPeriodos(idPeriodo);
                cargarPadres(idPadre);
                CargarUbigeo(idUbigeo.Substring(0, 2), idUbigeo.Substring(2, 2), idUbigeo.Substring(4, 2));
                if (chkEstado.Checked) 
                {
                    cboPeriodo.Enabled = true;
                    
                }
                else
                {
                    cboPeriodo.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                objAlumnoBE.NomAlumno = txtNombre.Text.Trim();
                objAlumnoBE.ApePatAlumno = txtApePat.Text.Trim();
                objAlumnoBE.ApeMatAlumno = txtApeMat.Text.Trim();
                objAlumnoBE.EmailAlumno = txtEmail.Text.Trim();
                objAlumnoBE.FecNacAlumno = dtpFecNac.Value;
                objAlumnoBE.TelAlumno = txtTel.Text.Trim();
                objAlumnoBE.DniAlumno = mskDni.Text;
                objAlumnoBE.IdPadre = Convert.ToInt16(cboPadre.SelectedValue);
                objAlumnoBE.DirAlumno = txtDir.Text.Trim();
                objAlumnoBE.Id_Ubigeo = cboDepartamento.SelectedValue.ToString()
                    + cboProvincia.SelectedValue.ToString()
                    + cboDistrito.SelectedValue.ToString();
                objAlumnoBE.IdPeriodo = Convert.ToInt16(cboPeriodo.SelectedValue);
                objAlumnoBE.Est_Alum = Convert.ToInt16(chkEstado.Checked);
                objAlumnoBE.Usu_Ult_Mod = clsCredenciales.Usuario;

                if (txtNombre.Text == "")
                {
                    throw new Exception("El campo nombre no puede estar vacio");
                }

                if (txtApePat.Text == "" | txtApeMat.Text == "")
                {
                    throw new Exception("Debe ingresar ambos apellidos");
                }

                if (!mskDni.MaskFull)
                {
                    throw new Exception("El DNI debe tener 8 caracteres");
                }

                if (objAlumnoBL.ActualizarAlumno(objAlumnoBE))
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("Error: No se pudo actualizar aliumno");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {
            UbigeoBL objUbigeoBL = new UbigeoBL();
            cboDepartamento.DataSource = objUbigeoBL.Ubigeo_Departamentos();
            cboDepartamento.ValueMember = "IdDepa";
            cboDepartamento.DisplayMember = "Departamento";
            cboDepartamento.SelectedValue = IdDepa;

            cboProvincia.DataSource = objUbigeoBL.Ubigeo_ProvinciasDepartamento(IdDepa);
            cboProvincia.ValueMember = "IdProv";
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.SelectedValue = IdProv;

            cboDistrito.DataSource = objUbigeoBL.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            cboDistrito.ValueMember = "IdDist";
            cboDistrito.DisplayMember = "Distrito";
            cboDistrito.SelectedValue = IdDist;
        }

        public void cargarPadres(Int16 strIdAlumno)
        {
            cboPadre.DataSource = objPadreBL.ListarPadre();
            cboPadre.ValueMember = "IDPADRE";
            cboPadre.DisplayMember = "ApellNombres";
            cboPadre.SelectedValue = strIdAlumno;
        }

        public void cargarPeriodos(Int16 strIdPeriodo)
        {
            cboPeriodo.DataSource = objPeriodoBL.ListarPeriodos();
            cboPeriodo.ValueMember = "IDPERIODO";
            cboPeriodo.DisplayMember = "ANUAL";
            cboPeriodo.SelectedValue = strIdPeriodo;
        }

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");
        }

        private void chkEstado_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkEstado.Checked)
            {
                cboPeriodo.Enabled = true;
            }
            else
            {
                cboPeriodo.Enabled = false;
            }
        }
    }
}

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
    public partial class AlumnoMan02 : Form
    {
        AlumnoBL objAlumnoBL = new AlumnoBL();
        AlumnoBE objAlumnoBE = new AlumnoBE();
        PadreBL objPadreBL = new PadreBL();
        PeriodoBL objPeriodoBL = new PeriodoBL();
        

        public AlumnoMan02()
        {
            InitializeComponent();
        }
        private void AlumnoMan02_Load(object sender, EventArgs e)
        {
            try
            {
                cargarPadres(1);
                cargarPeriodos(1);
                CargarUbigeo("14", "01", "01");                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex.Message);
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
                objAlumnoBE.Usu_Registro = clsCredenciales.Usuario;
                objAlumnoBE.Usu_Ult_Mod = clsCredenciales.Usuario;

                //agregar validaciones
                if (txtNombre.Text=="")
                {
                    throw new Exception("El campo nombre no puede estar vacio");
                }

                if(txtApePat.Text == "" | txtApeMat.Text == "")
                {
                    throw new Exception("Debe ingresar ambos apellidos");
                }

                if (!mskDni.MaskFull)
                {
                    throw new Exception("El DNI debe tener 8 caracteres");
                }

                if (objAlumnoBL.InsertarAlumno(objAlumnoBE))
                {
                    this.Close();
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
    }
}

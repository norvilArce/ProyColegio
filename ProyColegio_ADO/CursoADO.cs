using ProyColegio_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyColegio_ADO {

    public class CursoADO {

        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public Boolean InsertarCurso(CursoBE objCursoBE) {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_InsertarCurso";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vnom", objCursoBE.Nombre);
                cmd.Parameters.AddWithValue("@vdesc", objCursoBE.Descripcion);
                cmd.Parameters.AddWithValue("@horas", objCursoBE.HorasSemanales);
                cmd.Parameters.AddWithValue("@tipo", objCursoBE.TipoCurso);
                cmd.Parameters.AddWithValue("@vUsu_registro", objCursoBE.UsuRegistro);
                cmd.Parameters.AddWithValue("@vEst", objCursoBE.Estado);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x) {
                throw new Exception(x.Message);

            }
            finally {
                if (cnx.State == ConnectionState.Open) {
                    cnx.Close();
                }
            }
        }

        public Boolean ActualizarCurso(CursoBE objCursoBE) {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarCurso";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vid", objCursoBE.Id);
                cmd.Parameters.AddWithValue("@vnom", objCursoBE.Nombre);
                cmd.Parameters.AddWithValue("@vdesc", objCursoBE.Descripcion);
                cmd.Parameters.AddWithValue("@horas", objCursoBE.HorasSemanales);
                cmd.Parameters.AddWithValue("@tipo", objCursoBE.TipoCurso);
                cmd.Parameters.AddWithValue("@vUsu_registro", objCursoBE.UsuRegistro);
                cmd.Parameters.AddWithValue("@vEst", objCursoBE.Estado);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x) {
                throw new Exception(x.Message);
            }
            finally {
                if (cnx.State == ConnectionState.Open) {
                    cnx.Close();
                }
            }
        }

        public Boolean EliminarCurso(int id) {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_EliminarCurso";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vid", id);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x) {
                throw new Exception(x.Message);

            }
            finally {
                if (cnx.State == ConnectionState.Open) {
                    cnx.Close();
                }

            }


        }

        public CursoBE ConsultarCurso(int id) {
            CursoBE objCursoBE = new CursoBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarCurso";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vid", id);
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true) {
                    dtr.Read();
                    objCursoBE.Id = Convert.ToInt16(dtr["IDCURSO"]);
                    objCursoBE.Nombre = dtr["NOMBRECURSO"].ToString();
                    objCursoBE.Descripcion = dtr["DESCRIPCION"].ToString();
                    objCursoBE.HorasSemanales = Convert.ToInt16(dtr["HORAS_SEMANALES"]);
                    objCursoBE.TipoCurso = Convert.ToInt16(dtr["TIPOCURSO"]);
                    objCursoBE.UsuRegistro = dtr["USUARIO_REGISTRO"].ToString();
                    objCursoBE.FechaRegistro = Convert.ToDateTime(dtr["FECHA_REGISTRO"]);
                    objCursoBE.UsuUltMod = dtr["USUARIO_ULT_MODIFICACION"].ToString();
                    objCursoBE.FechaUltMod = Convert.ToDateTime(dtr["FECHA_ULT_MODIFICACION"]);
                    objCursoBE.Estado = Convert.ToInt16(dtr["ESTADO"]);
                }
                dtr.Close();
                return objCursoBE;
            }
            catch (SqlException ex) {
                throw new Exception(ex.Message);
            }
            finally {
                if (cnx.State == ConnectionState.Open) {
                    cnx.Close();
                }

            }

        }
        public DataTable ListarCurso() {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarCurso";

            try {
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Cursos");
            }
            catch (SqlException ex) {
                throw new Exception(ex.Message);
            }
            return dts.Tables["Cursos"];
        }


    }
}

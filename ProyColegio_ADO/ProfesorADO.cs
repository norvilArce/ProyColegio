using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyColegio_BE;

namespace ProyColegio_ADO
{
    public class AlumnoADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public Boolean InsertarAlumno(AlumnoBE objAlumnoBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_InsertarAlumno";

            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vdni", objAlumnoBE.DniAlumno);
                cmd.Parameters.AddWithValue("@vnom", objAlumnoBE.NomAlumno);
                cmd.Parameters.AddWithValue("@vape_pat", objAlumnoBE.ApePatAlumno);
                cmd.Parameters.AddWithValue("@vape_mat", objAlumnoBE.ApeMatAlumno);
                cmd.Parameters.AddWithValue("@vemail", objAlumnoBE.EmailAlumno);
                cmd.Parameters.AddWithValue("@vfec_nac", objAlumnoBE.FecNacAlumno);
                cmd.Parameters.AddWithValue("@vtel", objAlumnoBE.TelAlumno);
                cmd.Parameters.AddWithValue("@vid_padre", objAlumnoBE.IdPadre);
                cmd.Parameters.AddWithValue("@vdir", objAlumnoBE.DirAlumno);
                cmd.Parameters.AddWithValue("@vid_ubigeo", objAlumnoBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@vUsu_registro", objAlumnoBE.Usu_Registro);
                cmd.Parameters.AddWithValue("@vEst_Alum", objAlumnoBE.Est_Alum);
                cmd.Parameters.AddWithValue("@vid_per", objAlumnoBE.IdPeriodo);

                //ejecutmos
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }


        public Boolean ActualizarAlumno(AlumnoBE objAlumnoBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarAlumno";

            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vid_Alum", objAlumnoBE.IdAlumno);
                cmd.Parameters.AddWithValue("@vdni", objAlumnoBE.DniAlumno);
                cmd.Parameters.AddWithValue("@vnom", objAlumnoBE.NomAlumno);
                cmd.Parameters.AddWithValue("@vape_pat", objAlumnoBE.ApePatAlumno);
                cmd.Parameters.AddWithValue("@vape_mat", objAlumnoBE.ApeMatAlumno);
                cmd.Parameters.AddWithValue("@vemail", objAlumnoBE.EmailAlumno);
                cmd.Parameters.AddWithValue("@vfec_nac", objAlumnoBE.FecNacAlumno);
                cmd.Parameters.AddWithValue("@vtel", objAlumnoBE.TelAlumno);
                cmd.Parameters.AddWithValue("@vid_padre", objAlumnoBE.IdPadre);
                cmd.Parameters.AddWithValue("@vdir", objAlumnoBE.DirAlumno);
                cmd.Parameters.AddWithValue("@vid_ubigeo", objAlumnoBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@vUsu_ult_mod", objAlumnoBE.Usu_Ult_Mod);
                cmd.Parameters.AddWithValue("@vEst_Alum", objAlumnoBE.Est_Alum);
                cmd.Parameters.AddWithValue("@vid_per", objAlumnoBE.IdPeriodo);

                //ejecuta
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }


        }

        public Boolean EliminarAlumno(String strId)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_EliminarAlumno";

            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod", strId);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }


        }

        public AlumnoBE ConsultarAlumno(String strId)
        {
            AlumnoBE objAlumnoBE = new AlumnoBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarAlumno";
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vid", strId);

                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows)
                {
                    dtr.Read();
                    objAlumnoBE.IdAlumno = Convert.ToInt16(dtr["IDALUMNO"]);
                    objAlumnoBE.DniAlumno = dtr["DNI"].ToString();
                    objAlumnoBE.NomAlumno = dtr["NOMBRES"].ToString();
                    objAlumnoBE.ApePatAlumno = dtr["APEPATERNO"].ToString();
                    objAlumnoBE.ApeMatAlumno = dtr["APEMATERNO"].ToString();
                    objAlumnoBE.EmailAlumno = dtr["EMAIL"].ToString();
                    objAlumnoBE.FecNacAlumno = Convert.ToDateTime(dtr["FECHANACI"]);
                    objAlumnoBE.TelAlumno = dtr["TELEFONO"].ToString();
                    objAlumnoBE.IdPadre = Convert.ToInt16(dtr["IDPADRE"]);
                    objAlumnoBE.DirAlumno = dtr["DIRECCION"].ToString();
                    objAlumnoBE.Id_Ubigeo = dtr["IdUbigeo"].ToString();
                    objAlumnoBE.Usu_Registro = dtr["USUARIO_REGISTRO"].ToString();
                    objAlumnoBE.Fec_Registro = Convert.ToDateTime(dtr["FECHA_REGISTRO"]);
                    objAlumnoBE.Usu_Ult_Mod = dtr["USUARIO_ULT_MODIFICACION"].ToString();
                    objAlumnoBE.Fec_Ult_Mod = Convert.ToDateTime(dtr["FECHA_ULT_MODIFICACION"]);
                    objAlumnoBE.Est_Alum = Convert.ToInt16(dtr["ESTADO"]);
                    objAlumnoBE.IdPeriodo = Convert.ToInt16(dtr["IDPERIODO"]);

                }
                dtr.Close();
                return objAlumnoBE;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }

        }

        public DataTable ListarAlumno()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarAlumno";
            try
            {
                cmd.Parameters.Clear();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dts, "Alumnos");

                return dts.Tables["Alumnos"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dts.Tables["Alumnos"];
        }

        public Int16 contarAlumnos()
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ContarAlumnos";

            try
            {
                cmd.Parameters.Clear();
                cnx.Open();

                Int16 intCuenta = Convert.ToInt16(cmd.ExecuteScalar());
                return intCuenta;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }

    }
}

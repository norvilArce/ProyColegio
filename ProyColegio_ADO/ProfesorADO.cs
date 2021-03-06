﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyColegio_BE;

namespace ProyColegio_ADO
{
    public class ProfesorADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public Boolean InsertarProfesor(ProfesorBE objProfesorBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_InsertarProfesor";

            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vdni", objProfesorBE.DniProfesor);
                cmd.Parameters.AddWithValue("@vnom", objProfesorBE.NomProfesor);
                cmd.Parameters.AddWithValue("@vape_pat", objProfesorBE.ApePatProfesor);
                cmd.Parameters.AddWithValue("@vape_mat", objProfesorBE.ApeMatProfesor);
                cmd.Parameters.AddWithValue("@vemail", objProfesorBE.EmailProfesor);
                cmd.Parameters.AddWithValue("@vfec_nac", objProfesorBE.FecNacProfesor);
                cmd.Parameters.AddWithValue("@vtel", objProfesorBE.TelProfesor);
                cmd.Parameters.AddWithValue("@cel", objProfesorBE.CelProfesor);
                cmd.Parameters.AddWithValue("@vdir", objProfesorBE.DirProfesor);
                cmd.Parameters.AddWithValue("@vid_ubigeo", objProfesorBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@vUsu_registro", objProfesorBE.Usu_Registro);
                cmd.Parameters.AddWithValue("@vEst_Prof", objProfesorBE.Est_Prof);
                cmd.Parameters.AddWithValue("@vid_Curso", objProfesorBE.idCurso);

                //ejecutmos
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);

            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }


        public Boolean ActualizarProfesor(ProfesorBE objProfesorBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarProfesor";

            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vid_Prof", objProfesorBE.IdProfesor);
                cmd.Parameters.AddWithValue("@vdni", objProfesorBE.DniProfesor);
                cmd.Parameters.AddWithValue("@vnom", objProfesorBE.NomProfesor);
                cmd.Parameters.AddWithValue("@vape_pat", objProfesorBE.ApePatProfesor);
                cmd.Parameters.AddWithValue("@vape_mat", objProfesorBE.ApeMatProfesor);
                cmd.Parameters.AddWithValue("@vemail", objProfesorBE.EmailProfesor);
                cmd.Parameters.AddWithValue("@vfec_nac", objProfesorBE.FecNacProfesor);
                cmd.Parameters.AddWithValue("@vtel", objProfesorBE.TelProfesor);
                cmd.Parameters.AddWithValue("@cel", objProfesorBE.CelProfesor);
                cmd.Parameters.AddWithValue("@vdir", objProfesorBE.DirProfesor);
                cmd.Parameters.AddWithValue("@vid_ubigeo", objProfesorBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@vUsu_ult_mod", objProfesorBE.Usu_Ult_Mod);
                cmd.Parameters.AddWithValue("@vEst_Prof", objProfesorBE.Est_Prof);
                cmd.Parameters.AddWithValue("@vid_Curso", objProfesorBE.idCurso);

                //ejecuta
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);

            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }


        }

        public Boolean EliminarProfesor(String strId)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_EliminarProfesor";

            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vid", strId);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);

            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }


        }

        public ProfesorBE ConsultarProfesor(String strId)
        {
            ProfesorBE objProfesorBE = new ProfesorBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarProfesor";
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vid", strId);

                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows)
                {
                    dtr.Read();
                    objProfesorBE.IdProfesor = Convert.ToInt16(dtr["IDPROFESOR"]);
                    objProfesorBE.DniProfesor = dtr["DNI"].ToString();
                    objProfesorBE.NomProfesor = dtr["NOMBRES"].ToString();
                    objProfesorBE.ApePatProfesor = dtr["APEPATERNO"].ToString();
                    objProfesorBE.ApeMatProfesor = dtr["APEMATERNO"].ToString();
                    objProfesorBE.EmailProfesor = dtr["EMAIL"].ToString();
                    objProfesorBE.FecNacProfesor = Convert.ToDateTime(dtr["FECHANACI"]);
                    objProfesorBE.TelProfesor = dtr["TELEFONO"].ToString();
                    objProfesorBE.CelProfesor = dtr["CELULAR"].ToString();
                    objProfesorBE.DirProfesor = dtr["DIRECCION"].ToString();
                    objProfesorBE.Id_Ubigeo = dtr["IdUbigeo"].ToString();
                    objProfesorBE.Usu_Registro = dtr["USUARIO_REGISTRO"].ToString();
                    objProfesorBE.Fec_Registro = Convert.ToDateTime(dtr["FECHA_REGISTRO"]);
                    objProfesorBE.Usu_Ult_Mod = dtr["USUARIO_ULT_MODIFICACION"].ToString();
                    objProfesorBE.Fec_Ult_Mod = Convert.ToDateTime(dtr["FECHA_ULT_MODIFICACION"]);
                    objProfesorBE.Est_Prof = Convert.ToInt16(dtr["ESTADO"]);
                    objProfesorBE.idCurso = Convert.ToInt16(dtr["IDCURSO"]);

                }
                dtr.Close();
                return objProfesorBE;
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

        public DataTable ListarProfesor()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarProfesor";
            try
            {
                cmd.Parameters.Clear();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dts, "Profesores");

                return dts.Tables["Profesores"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Int16 contarProfesores()
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ContarProfesor";

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

        public DataTable ListarCursosPorProfesor(int idProfesor) {

            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarCursosPorProfesor";
            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vidProfesor", idProfesor);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dts, "CursosProfesor");

                return dts.Tables["CursosProfesor"];
            }
            catch (SqlException ex) {
                throw new Exception(ex.Message);
            }
        }
    }
}

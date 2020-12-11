using ProyColegio_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyColegio_ADO
{
    public class MatriculaADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public Int16 RegistrarMatricula(MatriculaBE objMatriculaBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_RegistrarMatricula";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vIdPeriodo", objMatriculaBE.idPeriodo);
                cmd.Parameters.AddWithValue("@vIdAlumno", objMatriculaBE.idAlumno);
                cmd.Parameters.AddWithValue("@vUsu_registro", objMatriculaBE.UsuRegistro);

                cmd.Parameters.Add(new SqlParameter("@vNumMatricula", SqlDbType.Int));
                cmd.Parameters["@cNumMatricula"].Direction = ParameterDirection.Output;

                cmd.Parameters.Add(new SqlParameter("@detalles", SqlDbType.Structured));
                cmd.Parameters["@detalles"].Value = objMatriculaBE.DetalleMatricula;
                cnx.Open();
                cmd.ExecuteNonQuery();
                return (Int16)cmd.Parameters["@cNumMatricula"].Value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }
    }
}

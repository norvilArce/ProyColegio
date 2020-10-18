using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProyColegio_BE;

namespace ProyColegio_ADO
{
    public class UsuarioADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public UsuarioBE ConsultarUsuario(String strLogin)
        {
            UsuarioBE objUsuarioBE = new UsuarioBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarUsuario";

            try
            {
                //agregamos el paramtro
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Login_Usuario", strLogin);
                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows)
                {
                    dtr.Read();
                    objUsuarioBE.LogUsu = dtr["LoginUsu"].ToString();
                    objUsuarioBE.PassUsu = dtr["PassUsu"].ToString();
                    objUsuarioBE.NivUsu = Convert.ToInt16(dtr["NivUsu"]);
                    objUsuarioBE.FecReg = Convert.ToDateTime(dtr["FecReg"]);
                    objUsuarioBE.UsuReg = dtr["UsuReg"].ToString();
                    objUsuarioBE.EstUsu = Convert.ToInt16(dtr["EstUsu"]);
                }
                dtr.Close();
                return objUsuarioBE;

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

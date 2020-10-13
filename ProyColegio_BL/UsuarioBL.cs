using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyColegio_ADO;
using ProyColegio_BE;

namespace ProyColegio_BL
{
    public class UsuarioBL
    {
        UsuarioADO objUsuarioAdo = new UsuarioADO();

        public UsuarioBE ConsultarUsuario(String strLogin)
        {
            return objUsuarioAdo.ConsultarUsuario(strLogin);
        }

    }
}

using ProyColegio_ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyColegio_BL
{
    public class SalonBL
    {
        SalonADO objClienteAdo = new SalonADO();

        public DataTable ListarSalon()
        {
            return objClienteAdo.ListarSalon();
        }

        public DataTable ListarPromediosSalon(Int16 codSalon)
        {
            return objClienteAdo.ListarPromediosSalon(codSalon);
        }
    }
}
